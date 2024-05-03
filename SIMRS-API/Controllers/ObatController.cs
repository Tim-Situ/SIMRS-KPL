using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReadJsonLib;
using SIMRS_LIB;

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
public class ObatController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    //private static ReadJsonLib<List<Obat>> libReadJson = new ReadJsonLib<List<Obat>>();
    private static string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/DataObat.json");
    private static List<Obat> dataObat;


    [HttpGet]
    public ActionResult<ApiResponse<List<Obat>>> Get()
    {
        //dataObat = libReadJson.ReadJsonFromFile(jsonFilePath);
        dataObat = JsonUtils<List<Obat>>.ReadJsonFromFile(jsonFilePath);
        response.message = "Data obat berhasil ditampilkan";
        response.data = dataObat;

        return Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult<ApiResponse<Obat>> Get(int id)
    {
        dataObat = JsonUtils<List<Obat>>.ReadJsonFromFile(jsonFilePath);
        if (id >= dataObat.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data obat dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        response.message = "Data obat ditemukan";
        response.data = dataObat[id];

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<Obat>> Post([FromBody] Obat value)
    {
        dataObat.Add(value);
        response.message = "Data obat berhasil ditambahkan";
        response.data = dataObat.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{id}")]
    public ActionResult<ApiResponse<Obat>> Put(int id, [FromBody] Obat value)
    {
        dataObat = JsonUtils<List<Obat>>.ReadJsonFromFile(jsonFilePath);
        if (id >= dataObat.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data obat dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataObat[id] = value;
        response.message = "Data obat berhasil diubah";
        response.data = dataObat[id];

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public ActionResult<ApiResponse<Object>> Delete(int id)
    {
        dataObat = JsonUtils<List<Obat>>.ReadJsonFromFile(jsonFilePath);
        if (id >= dataObat.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data obat dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataObat.RemoveAt(id);
        response.message = "Data obat berhasil dihapus";

        return Ok(response);
    }
}

