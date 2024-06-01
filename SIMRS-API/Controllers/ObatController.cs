using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIMRS_LIB;

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ObatController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    private static string jsonFilePath = "Data/DataObat.json";
    private static List<Obat> dataObat;


    [HttpGet]
    public ActionResult<ApiResponse<List<Obat>>> Get()
    {
        dataObat = JsonUtils<List<Obat>>.ReadJsonFromFile(jsonFilePath);
        response.message = "Data obat berhasil ditampilkan";
        response.data = dataObat;

        return Ok(response);
    }

    [HttpGet("{kode}")]
    public ActionResult<ApiResponse<Obat>> Get(string kode)
    {
        dataObat = JsonUtils<List<Obat>>.ReadJsonFromFile(jsonFilePath);
        Obat cariObat = dataObat.FirstOrDefault(item => item.kode == kode);
        if (cariObat == null)
        {
            response.success = false;
            response.message = $"Data obat dengan kode : {kode} tidak ditemukan";

            return NotFound(response);
        }

        response.message = "Data obat ditemukan";
        response.data = cariObat;

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<Obat>> Post([FromBody] Obat value)
    {
        dataObat = JsonUtils<List<Obat>>.ReadJsonFromFile(jsonFilePath);
        dataObat.Add(value);
        JsonUtils<List<Obat>>.WriteJsonFile(dataObat, jsonFilePath);
        response.message = "Data obat berhasil ditambahkan";
        response.data = value;

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{kode}")]
    public ActionResult<ApiResponse<Obat>> Put(string kode, [FromBody] Obat value)
    {
        dataObat = JsonUtils<List<Obat>>.ReadJsonFromFile(jsonFilePath);
        Obat cariObat = dataObat.FirstOrDefault(item => item.kode == kode);
        if (cariObat == null)
        {
            response.success = false;
            response.message = $"Data obat dengan kode : {kode} tidak ditemukan";

            return NotFound(response);
        }

        int idx = dataObat.FindIndex(item => item.kode == kode);

        dataObat[idx] = value;
        JsonUtils<List<Obat>>.WriteJsonFile(dataObat, jsonFilePath);

        response.message = "Data obat berhasil diubah";
        response.data = dataObat[idx];

        return Ok(response);
    }

    [HttpDelete("{kode}")]
    public ActionResult<ApiResponse<Object>> Delete(string kode)
    {
        dataObat = JsonUtils<List<Obat>>.ReadJsonFromFile(jsonFilePath);
        Obat cariObat = dataObat.FirstOrDefault(item => item.kode == kode);

        if (cariObat == null)
        {
            response.success = false;
            response.message = $"Data obat dengan kode : {kode} tidak ditemukan";

            return NotFound(response);
        }

        int idx = dataObat.FindIndex(item => item.kode == kode);

        dataObat.RemoveAt(idx);
        JsonUtils<List<Obat>>.WriteJsonFile(dataObat, jsonFilePath);
        response.message = "Data obat berhasil dihapus";

        return Ok(response);
    }
}

