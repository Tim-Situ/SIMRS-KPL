using Microsoft.AspNetCore.Mvc;
using SIMRS_LIB;
using System.Linq;

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
public class DokterController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    private static string jsonFilePath = "Data/DataDokter.json";
    private static List<Dokter> dataDokter;


    [HttpGet]
    public ActionResult<ApiResponse<List<Dokter>>> Get()
    {
        dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(jsonFilePath);
        response.message = "Data dokter berhasil ditampilkan";
        response.data = dataDokter;

        return Ok(response);
    }

    [HttpGet("{nip}")]
    public ActionResult<ApiResponse<Dokter>> Get(string nip)
    {
        dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(jsonFilePath);
        Dokter cariDokter = dataDokter.FirstOrDefault(item => item.nip == nip);

        if (cariDokter == null)
        {
            response.success = false;
            response.message = $"Data dokter dengan NIP : {nip} tidak ditemukan";

            return NotFound(response);
        }

        response.message = "Data dokter ditemukan";
        response.data = cariDokter;

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<Dokter>> Post([FromBody] Dokter value)
    {
        dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(jsonFilePath);
        dataDokter.Add(value);
        JsonUtils<List<Dokter>>.WriteJsonFile(dataDokter, jsonFilePath);

        response.message = "Data dokter berhasil ditambahkan";
        response.data = dataDokter.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{nip}")]
    public ActionResult<ApiResponse<Dokter>> Put(string nip, [FromBody] Dokter value)
    {
        dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(jsonFilePath);
        Dokter cariDokter = dataDokter.FirstOrDefault(item => item.nip == nip);

        if (cariDokter == null)
        {
            response.success = false;
            response.message = $"Data dokter dengan NIP : {nip} tidak ditemukan";

            return NotFound(response);
        }

        int index = dataDokter.FindIndex(item => item.nip == nip);
        dataDokter[index] = value;
        JsonUtils<List<Dokter>>.WriteJsonFile(dataDokter, jsonFilePath);

        response.message = "Data dokter berhasil diubah";
        response.data = dataDokter[index];

        return Ok(response);
    }

    [HttpDelete("{nip}")]
    public ActionResult<ApiResponse<Object>> Delete(string nip)
    {
        dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(jsonFilePath);
        Dokter cariDokter = dataDokter.FirstOrDefault(item => item.nip == nip);

        if (cariDokter == null)
        {
            response.success = false;
            response.message = $"Data dokter dengan NIP : {nip} tidak ditemukan";

            return NotFound(response);
        }

        int index = dataDokter.FindIndex(item => item.nip == nip);
        dataDokter.RemoveAt(index);
        JsonUtils<List<Dokter>>.WriteJsonFile(dataDokter, jsonFilePath);

        response.message = "Data dokter berhasil dihapus";

        return Ok(response);
    }
}

