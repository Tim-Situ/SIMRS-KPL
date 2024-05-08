using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SIMRS_LIB;

namespace SIMRS_API;


[ApiController]
[Route("api/[controller]")]
public class PoliController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    private static string jsonFilePath = "Data/DataPoli.json";
    private static List<Poli> dataPoli;

    [HttpGet]
    public ActionResult<ApiResponse<List<Poli>>> GetAll([FromQuery] string search = null)
    {
        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);

        if (search != null)
        {
            dataPoli = new List<Poli>
            {
                dataPoli.FirstOrDefault(item => item.namaPoli.ToLower() == search.ToLower())
            };

            if (dataPoli[0] == null)
            {
                response.success = false;
                response.message = "Data poli tidak ditemukan";
                response.data = dataPoli;

                return NotFound(response);
            }
        }

        response.message = "Data poli berhasil ditampilkan";
        response.data = dataPoli;

        return Ok(response);
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

        int idx = dataPoli.FindIndex(item => item.kode == kode);
        dataPoli[idx] = value;
        JsonUtils<List<Poli>>.WriteJsonFile(dataPoli, jsonFilePath);

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


