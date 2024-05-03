using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using SIMRS_LIB;

namespace SIMRS_API;


[ApiController]
[Route("api/[controller]")]
public class PoliController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    //private static ReadJsonLib<List<Poli>> libReadJson = new ReadJsonLib<List<Poli>>();
    private static string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/DataPoli.json");
    private static List<Poli> dataPoli;

    [HttpGet]
    public ActionResult<ApiResponse<List<Poli>>> Get()
    {
        //dataPoli = libReadJson.ReadJsonFromFile(jsonFilePath);
        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);
        response.message = "Data poli berhasil ditampilkan";
        response.data = dataPoli;

        return Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult<ApiResponse<Poli>> Get(int id)
    {
        dataPoli = JsonUtils<List<Poli>>.ReadJsonFromFile(jsonFilePath);

        if (id >= dataPoli.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data poli dengan Index : {id} tidak ditemukan";
            response.data = null;

            return NotFound(response);
        }

        response.message = "Data poli ditemukan";
        response.data = dataPoli[id];

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<Poli>> Post([FromBody] Poli value)
    {
        dataPoli.Add(value);
        response.message = "Data poli berhasil ditambahkan";
        response.data = dataPoli.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{id}")]
    public ActionResult<ApiResponse<Poli>> Put(int id, [FromBody] Poli value)
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
        response.message = "Data poli berhasil dihapus";

        return Ok(response);
    }
}


