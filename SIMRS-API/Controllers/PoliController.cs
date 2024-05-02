using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using ReadJsonLib;

namespace SIMRS_API;


[ApiController]
[Route("api/[controller]")]
public class PoliController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    private static ReadJsonLib<List<Poli>> libReadJson = new ReadJsonLib<List<Poli>>();
    private static string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/DataPoli.json");
    private static List<Poli> dataPoli = libReadJson.ReadJsonFromFile(jsonFilePath);


    [HttpGet]
    public ActionResult<ApiResponse<List<Poli>>> Get()
    {
        response.message = "Data poli berhasil ditampilkan";
        response.data = dataPoli;

        return Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult<ApiResponse<Object>> Get(int id)
    {
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
    public ActionResult<ApiResponse<Object>> Post([FromBody] Poli value)
    {
        dataPoli.Add(value);
        response.message = "Data poli berhasil ditambahkan";
        response.data = dataPoli.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{id}")]
    public ActionResult<ApiResponse<Object>> Put(int id, [FromBody] Poli value)
    {
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


