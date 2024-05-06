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

    [HttpGet("{kode}")]
    public ActionResult<ApiResponse<Pemeriksaan>> Get(string kode)
    {
        dataPemeriksaan = JsonUtils<List<Pemeriksaan>>.ReadJsonFromFile(jsonFilePath);
        Pemeriksaan cariPemeriksaan = dataPemeriksaan.FirstOrDefault(item => item.kode == kode);

        if (dataPemeriksaan.Any(item => item.kode == kode))
        {
            response.success = false;
            response.message = $"Data pemeriksaan dengan kode : {kode} tidak ditemukan";

            return NotFound(response);
        }

        response.message = "Data pemeriksaan ditemukan";
        response.data = dataPemeriksaan.FirstOrDefault(item => item.kode == kode);

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

    //[HttpPut("{kode}")]
    //public ActionResult<ApiResponse<Pemeriksaan>> Put(string kode, [FromBody] Pemeriksaan value)
    //{
    //    dataPemeriksaan = JsonUtils<List<Pemeriksaan>>.ReadJsonFromFile(jsonFilePath);

    //    if (!dataPemeriksaan.Any(item => item.kode == kode))
    //    {
    //        response.success = false;
    //        response.message = $"Data pemeriksaan dengan kode : {kode} tidak ditemukan";

    //        return NotFound(response);
    //    }

    //    int idx = dataPemeriksaan.FindIndex(item => item.kode == kode);
    //    dataPemeriksaan[idx] = value;
    //    JsonUtils<List<Pemeriksaan>>.WriteJsonFile(dataPemeriksaan, jsonFilePath);
    //    response.message = "Data pemeriksaan berhasil diubah";
    //    response.data = dataPemeriksaan[idx];

    //    return Ok(response);
    //}

    [HttpDelete("{kode}")]
    public ActionResult<ApiResponse<Object>> Delete(string kode)
    {
        dataPemeriksaan = JsonUtils<List<Pemeriksaan>>.ReadJsonFromFile(jsonFilePath); 

        if (!dataPemeriksaan.Any(item => item.kode == kode))
        {
            response.success = false;
            response.message = $"Data pemeriksaan dengan kode : {kode} tidak ditemukan";

            return NotFound(response);
        }

        int idx = dataPemeriksaan.FindIndex(item => item.kode == kode);
        dataPemeriksaan.RemoveAt(idx);
        JsonUtils<List<Pemeriksaan>>.WriteJsonFile(dataPemeriksaan, jsonFilePath);
        response.message = "Data pemeriksaan berhasil dihapus";

        return Ok(response);
    }
}

