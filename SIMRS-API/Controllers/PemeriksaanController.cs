using Microsoft.AspNetCore.Mvc;
using SIMRS_LIB;

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
public class PemeriksaanController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    private static string jsonFilePath = "Data/DataPemeriksaan.json";
    private static List<Pemeriksaan> dataPemeriksaan;


    [HttpGet]
    public ActionResult<ApiResponse<List<Pemeriksaan>>> Get()
    {
        dataPemeriksaan = JsonUtils<List<Pemeriksaan>>.ReadJsonFromFile(jsonFilePath);
        response.message = "Data pemeriksaan berhasil ditampilkan";
        response.data = dataPemeriksaan;

        return Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult<ApiResponse<Pemeriksaan>> Get(int id)
    {
        if (id >= dataPemeriksaan.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pemeriksaan dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        response.message = "Data pemeriksaan ditemukan";
        response.data = dataPemeriksaan[id];

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<Pemeriksaan>> Post([FromBody] Pemeriksaan value)
    {
        dataPemeriksaan = JsonUtils<List<Pemeriksaan>>.ReadJsonFromFile(jsonFilePath);
        dataPemeriksaan.Add(value);
        JsonUtils<List<Pemeriksaan>>.WriteJsonFile(dataPemeriksaan, jsonFilePath);
        response.message = "Data pemeriksaan berhasil ditambahkan";
        response.data = dataPemeriksaan.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{id}")]
    public ActionResult<ApiResponse<Pemeriksaan>> Put(int id, [FromBody] Pemeriksaan value)
    {
        dataPemeriksaan = JsonUtils<List<Pemeriksaan>>.ReadJsonFromFile(jsonFilePath);
        if (id >= dataPemeriksaan.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pemeriksaan dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataPemeriksaan[id] = value;
        JsonUtils<List<Pemeriksaan>>.WriteJsonFile(dataPemeriksaan, jsonFilePath);
        response.message = "Data pemeriksaan berhasil diubah";
        response.data = dataPemeriksaan[id];

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public ActionResult<ApiResponse<Object>> Delete(int id)
    {
        dataPemeriksaan = JsonUtils<List<Pemeriksaan>>.ReadJsonFromFile(jsonFilePath);

        if (id >= dataPemeriksaan.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pemeriksaan dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataPemeriksaan.RemoveAt(id);
        JsonUtils<List<Pemeriksaan>>.WriteJsonFile(dataPemeriksaan, jsonFilePath);
        response.message = "Data pemeriksaan berhasil dihapus";

        return Ok(response);
    }
}

