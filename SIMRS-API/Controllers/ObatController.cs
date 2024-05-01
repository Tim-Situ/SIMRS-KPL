using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
public class ObatController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    public static List<Obat> dataObat = new List<Obat>()
    {
        new Obat("OBT01", "Obat Sakit Gigi", 10000, Obat.EnumObat.PIL),
        new Obat("OBT02", "Obat Batuk", 15000, Obat.EnumObat.SIRUP),
    };


    [HttpGet]
    public ActionResult<ApiResponse<Object>> Get()
    {
        response.message = "Data obat berhasil ditampilkan";
        response.data = dataObat;

        return Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult<ApiResponse<Object>> Get(int id)
    {
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
    public ActionResult<ApiResponse<Object>> Post([FromBody] Obat value)
    {
        dataObat.Add(value);
        response.message = "Data obat berhasil ditambahkan";
        response.data = dataObat.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{id}")]
    public ActionResult<ApiResponse<Object>> Put(int id, [FromBody] Obat value)
    {
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

