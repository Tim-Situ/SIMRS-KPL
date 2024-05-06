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

    [HttpGet("{id}")]
    public ActionResult<ApiResponse<List<Pasien>>> Get(int id)
    {
        dataPasien = JsonUtils<List<Pasien>>.ReadJsonFromFile(jsonFilePath);
        if (id >= dataPasien.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pasien dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        response.message = "Data pasien ditemukan";
        response.data = dataPasien[id];

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

    [HttpPut("{id}")]
    public ActionResult<ApiResponse<Object>> Put(int id, [FromBody] Pasien value)
    {
        dataPasien = JsonUtils<List<Pasien>>.ReadJsonFromFile(jsonFilePath);
        if (id >= dataPasien.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pasien dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataPasien[id] = value;
        JsonUtils<List<Pasien>>.WriteJsonFile(dataPasien, jsonFilePath);
        response.message = "Data pasien berhasil diubah";
        response.data = dataPasien[id];

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public ActionResult<ApiResponse<Object>> Delete(int id)
    {
        dataPasien = JsonUtils<List<Pasien>>.ReadJsonFromFile(jsonFilePath);

        if (id >= dataPasien.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pasien dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataPasien.RemoveAt(id);
        JsonUtils<List<Pasien>>.WriteJsonFile(dataPasien, jsonFilePath);
        response.message = "Data pasien berhasil dihapus";

        return Ok(response);
    }
}

