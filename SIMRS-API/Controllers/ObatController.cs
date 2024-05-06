using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SIMRS_LIB;

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
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
        dataObat = JsonUtils<List<Obat>>.ReadJsonFromFile(jsonFilePath);
        dataObat.Add(value);
        JsonUtils<List<Obat>>.WriteJsonFile(dataObat, jsonFilePath);
        response.message = "Data obat berhasil ditambahkan";
        response.data = value;

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
        JsonUtils<List<Obat>>.WriteJsonFile(dataObat, jsonFilePath);

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
        JsonUtils<List<Obat>>.WriteJsonFile(dataObat, jsonFilePath);
        response.message = "Data obat berhasil dihapus";

        return Ok(response);
    }
}

