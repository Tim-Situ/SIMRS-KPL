using Microsoft.AspNetCore.Mvc;
using SIMRS_LIB;

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
public class PasienController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    private static string jsonFilePath = "Data/DataPasien.json";
    private static List<Pasien> dataPasien;

    [HttpGet]
    public ActionResult<ApiResponse<List<Pasien>>> Get()
    {
        dataPasien = JsonUtils<List<Pasien>>.ReadJsonFromFile(jsonFilePath);
        response.message = "Data pasien berhasil ditampilkan";
        response.data = dataPasien;

        return Ok(response);
    }

    [HttpGet("{nik}")]
    public ActionResult<ApiResponse<List<Pasien>>> Get(string nik)
    {
        dataPasien = JsonUtils<List<Pasien>>.ReadJsonFromFile(jsonFilePath);
        Pasien cariPasien = dataPasien.FirstOrDefault(item => item.nik == nik);

        if (cariPasien == null)
        {
            response.success = false;
            response.message = $"Data pasien dengan NIK : {nik} tidak ditemukan";

            return NotFound(response);
        }

        response.message = "Data pasien ditemukan";
        response.data = cariPasien;

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<List<Pasien>>> Post([FromBody] Pasien value)
    {
        dataPasien = JsonUtils<List<Pasien>>.ReadJsonFromFile(jsonFilePath);
        dataPasien.Add(value);
        JsonUtils<List<Pasien>>.WriteJsonFile(dataPasien, jsonFilePath);
        response.message = "Data pasien berhasil ditambahkan";
        response.data = dataPasien.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{nik}")]
    public ActionResult<ApiResponse<Object>> Put(string nik, [FromBody] Pasien value)
    {
        dataPasien = JsonUtils<List<Pasien>>.ReadJsonFromFile(jsonFilePath);
        Pasien cariPasien = dataPasien.FirstOrDefault(item => item.nik == nik);

        if (cariPasien == null)
        {
            response.success = false;
            response.message = $"Data pasien dengan NIK : {nik} tidak ditemukan";

            return NotFound(response);
        }

        int idx = dataPasien.FindIndex(item => item.nik == nik);
        dataPasien[idx] = value;
        JsonUtils<List<Pasien>>.WriteJsonFile(dataPasien, jsonFilePath);
        response.message = "Data pasien berhasil diubah";
        response.data = dataPasien[idx];

        return Ok(response);
    }

    [HttpDelete("{nik}")]
    public ActionResult<ApiResponse<Object>> Delete(string nik)
    {
        dataPasien = JsonUtils<List<Pasien>>.ReadJsonFromFile(jsonFilePath);
        Pasien cariPasien = dataPasien.FirstOrDefault(item => item.nik == nik);

        if (cariPasien == null)
        {
            response.success = false;
            response.message = $"Data pasien dengan NIK : {nik} tidak ditemukan";

            return NotFound(response);
        }

        int idx = dataPasien.FindIndex(item => item.nik == nik);
        dataPasien.RemoveAt(idx);
        JsonUtils<List<Pasien>>.WriteJsonFile(dataPasien, jsonFilePath);
        response.message = "Data pasien berhasil dihapus";

        return Ok(response);
    }
}

