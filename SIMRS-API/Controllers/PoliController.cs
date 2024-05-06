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
    public ActionResult<ApiResponse<List<Poli>>> Get()
    {
        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);
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

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{kode}")]
    public ActionResult<ApiResponse<Poli>> Put(string kode, [FromBody] Poli value)
    {
        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);

        if (id >= dataPoli.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data poli dengan Index : {id} tidak ditemukan";
            response.data = null;

            return NotFound(response);
        }

        dataPoli[id] = value;
        JsonUtils<List<Poli>>.WriteJsonFile(dataPoli, jsonFilePath);

        response.message = "Data poli berhasil diubah";
        response.data = dataPoli[id];

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public ActionResult<ApiResponse<Object>> Delete(int id)
    {
        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);

        if (id >= dataPoli.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data poli dengan Index : {id} tidak ditemukan";
            response.data = null;

            return NotFound(response);
        }

        dataPoli.RemoveAt(id);
        JsonUtils<List<Poli>>.WriteJsonFile(dataPoli, jsonFilePath);
        response.message = "Data poli berhasil dihapus";

        return Ok(response);
    }
}


