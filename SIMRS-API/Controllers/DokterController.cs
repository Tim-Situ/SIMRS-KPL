using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIMRS_LIB;
using System.Linq;

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class DokterController : Controller
{
    private static string _jsonFilePath = "Data/DataDokter.json";
    private static List<Dokter> _dataDokter;


    [HttpGet]
    public ActionResult<ApiResponse<List<Dokter>>> Get()
    {
        ApiResponse<Object> response = new ApiResponse<object>();

        _dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(_jsonFilePath);
        response.message = "Data dokter berhasil ditampilkan";
        response.data = _dataDokter;

        return Ok(response);
    }

    [HttpGet("{nip}")]
    public ActionResult<ApiResponse<Dokter>> Get(string nip)
    {
        ApiResponse<Object> response = new ApiResponse<object>();

        _dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(_jsonFilePath);
        Dokter cariDokter = _dataDokter.FirstOrDefault(item => item.nip == nip);

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
        ApiResponse<Object> response = new ApiResponse<object>();

        _dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(_jsonFilePath);
        _dataDokter.Add(value);
        JsonUtils<List<Dokter>>.WriteJsonFile(_dataDokter, _jsonFilePath);

        response.message = "Data dokter berhasil ditambahkan";
        response.data = _dataDokter.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{nip}")]
    public ActionResult<ApiResponse<Dokter>> Put(string nip, [FromBody] Dokter value)
    {
        ApiResponse<Object> response = new ApiResponse<object>();

        _dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(_jsonFilePath);
        Dokter cariDokter = _dataDokter.FirstOrDefault(item => item.nip == nip);

        if (cariDokter == null)
        {
            response.success = false;
            response.message = $"Data dokter dengan NIP : {nip} tidak ditemukan";

            return NotFound(response);
        }

        int index = _dataDokter.FindIndex(item => item.nip == nip);
        _dataDokter[index] = value;
        JsonUtils<List<Dokter>>.WriteJsonFile(_dataDokter, _jsonFilePath);

        response.message = "Data dokter berhasil diubah";
        response.data = _dataDokter[index];

        return Ok(response);
    }

    [HttpDelete("{nip}")]
    public ActionResult<ApiResponse<Object>> Delete(string nip)
    {
        ApiResponse<Object> response = new ApiResponse<object>();

        _dataDokter = JsonUtils<List<Dokter>>.ReadJsonFromFile(_jsonFilePath);
        Dokter cariDokter = _dataDokter.FirstOrDefault(item => item.nip == nip);

        if (cariDokter == null)
        {
            response.success = false;
            response.message = $"Data dokter dengan NIP : {nip} tidak ditemukan";

            return NotFound(response);
        }

        int index = _dataDokter.FindIndex(item => item.nip == nip);
        _dataDokter.RemoveAt(index);
        JsonUtils<List<Dokter>>.WriteJsonFile(_dataDokter, _jsonFilePath);

        response.message = "Data dokter berhasil dihapus";

        return Ok(response);
    }
}

