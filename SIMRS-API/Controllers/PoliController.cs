using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIMRS_LIB;

namespace SIMRS_API;


[ApiController]
[Route("api/[controller]")]
[Authorize]
public class PoliController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    private static string jsonFilePath = "Data/DataPoli.json";
    private static string jsonFilePathDokter = "Data/DataDokter.json";
    private static List<Poli> dataPoli;

    [HttpGet]
    public ActionResult<ApiResponse<List<Poli>>> GetAll([FromQuery] string search = null)
    {
        // Load data dari json
        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);

        try
        {
            // Precondition : parameter search tidak null
            if (search != null)
            {
                // mencari data poli
                dataPoli = new List<Poli>
            {
                dataPoli.FirstOrDefault(item => item.namaPoli.ToLower() == search.ToLower())
            };

                // Postcondition: Pastikan setidaknya satu data poli ditemukan
                if (dataPoli[0] == null)
                {
                    response.success = false;
                    response.message = "Data poli tidak ditemukan";
                    response.data = dataPoli;

                    return NotFound(response);
                }
            }

            // Response: Tampilkan data poli yang berhasil ditemukan
            response.message = "Data poli berhasil ditampilkan";
            response.data = dataPoli;

            return Ok(response);

        }
        catch (Exception ex)
        {
            // Exception Handling
            response.success = false;
            response.message = "Terjadi kesalahan saat memproses permintaan";
            response.data = null; // Optionally, you can provide more specific error data.

            return StatusCode(500, response);
        }
    }

    [HttpGet("{kode}")]
    public ActionResult<ApiResponse<Poli>> Get(string kode)
    {
        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);

        if (!dataPoli.Any(item => item.kode == kode))
        {
            response.success = false;
            response.message = $"Data poli dengan kode : {kode} tidak ditemukan";
            response.data = null;

            return NotFound(response);
        }

        response.message = "Data poli ditemukan";
        response.data = dataPoli.FirstOrDefault(item => item.kode == kode);

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<Poli>> Post([FromBody] Poli value)
    {
        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);
        dataPoli.Add(value);
        JsonUtils<List<Poli>>.WriteJsonFile(dataPoli, jsonFilePath);
        response.message = "Data poli berhasil ditambahkan";
        response.data = dataPoli.Last();

        return CreatedAtAction(nameof(GetAll), response);
    }

    [HttpPut("{kode}")]
    public ActionResult<ApiResponse<Poli>> Put(string kode, [FromBody] Poli value)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);

        if (!dataPoli.Any(item => item.kode == kode))
        {
            response.success = false;
            response.message = $"Data poli dengan kode : {kode} tidak ditemukan";
            response.data = null;

            stopwatch.Stop();
            Console.WriteLine($"Waktu eksekusi: {stopwatch.ElapsedMilliseconds} ms");

            return NotFound(response);
        }

        List<Dokter> dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(jsonFilePathDokter);
        foreach (var item in dataDokter)
        {
            if (item.poli.kode == value.kode)
            {
                item.poli = value;
            }
        }

        int idx = dataPoli.FindIndex(item => item.kode == kode);
        dataPoli[idx] = value;
        JsonUtils<List<Poli>>.WriteJsonFile(dataPoli, jsonFilePath);
        JsonUtils<List<Dokter>>.WriteJsonFile(dataDokter, jsonFilePathDokter);

        stopwatch.Stop();
        Console.WriteLine($"Waktu eksekusi: {stopwatch.ElapsedMilliseconds} ms");

        response.message = "Data poli berhasil diubah";
        response.data = dataPoli[idx];

        return Ok(response);
    }

    [HttpDelete("{kode}")]
    public ActionResult<ApiResponse<Object>> Delete(string kode)
    {
        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);

        if (!dataPoli.Any(item => item.kode == kode))
        {
            response.success = false;
            response.message = $"Data poli dengan kode : {kode} tidak ditemukan";
            response.data = null;

            return NotFound(response);
        }

        int idx = dataPoli.FindIndex(item => item.kode == kode);
        dataPoli.RemoveAt(idx);
        JsonUtils<List<Poli>>.WriteJsonFile(dataPoli, jsonFilePath);
        response.message = "Data poli berhasil dihapus";

        return Ok(response);
    }
}


