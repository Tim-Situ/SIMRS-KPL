using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
public class DokterController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    public static List<Dokter> dataDokter = new List<Dokter>()
    {
        new Dokter("12345", "Dr. Felix", new Poli("Gigi", "KU1.03.01"), "07-11-1876", "08964586868", SIMRS_API.User.EnumJenisKelamin.PRIA, "Bandung"),
        new Dokter("54321", "Dr. Ayu", new Poli("THT", "TULT0309"), "01-08-1876", "08473758", SIMRS_API.User.EnumJenisKelamin.WANITA, "Jakarta")
    };


    [HttpGet]
    public ActionResult<ApiResponse<Object>> Get()
    {
        response.message = "Data dokter berhasil ditampilkan";
        response.data = dataDokter;

        return Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult<ApiResponse<Object>> Get(int id)
    {
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
    public ActionResult<ApiResponse<Object>> Post([FromBody] Dokter value)
    {
        dataDokter.Add(value);
        response.message = "Data dokter berhasil ditambahkan";
        response.data = dataDokter.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{id}")]
    public ActionResult<ApiResponse<Object>> Put(int id, [FromBody] Dokter value)
    {
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

