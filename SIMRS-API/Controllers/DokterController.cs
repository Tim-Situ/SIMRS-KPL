using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReadJsonLib;

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
public class DokterController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    private static ReadJsonLib<List<Dokter>> libReadJson = new ReadJsonLib<List<Dokter>>();
    private static string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/DataDokter.json");
    private static List<Dokter> dataDokter;


    [HttpGet]
    public ActionResult<ApiResponse<List<Dokter>>> Get()
    {
        dataDokter = libReadJson.ReadJsonFromFile(jsonFilePath);
        response.message = "Data dokter berhasil ditampilkan";
        response.data = dataDokter;

        return Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult<ApiResponse<Dokter>> Get(int id)
    {
        dataDokter = libReadJson.ReadJsonFromFile(jsonFilePath);
        if (id >= dataDokter.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data dokter dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        response.message = "Data dokter ditemukan";
        response.data = dataDokter[id];

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<Dokter>> Post([FromBody] Dokter value)
    {
        dataDokter.Add(value);
        response.message = "Data dokter berhasil ditambahkan";
        response.data = dataDokter.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{id}")]
    public ActionResult<ApiResponse<Dokter>> Put(int id, [FromBody] Dokter value)
    {
        dataDokter = libReadJson.ReadJsonFromFile(jsonFilePath);
        if (id >= dataDokter.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data dokter dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataDokter[id] = value;
        response.message = "Data dokter berhasil diubah";
        response.data = dataDokter[id];

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public ActionResult<ApiResponse<Object>> Delete(int id)
    {
        dataDokter = libReadJson.ReadJsonFromFile(jsonFilePath);
        if (id >= dataDokter.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data dokter dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataDokter.RemoveAt(id);
        response.message = "Data dokter berhasil dihapus";

        return Ok(response);
    }
}

