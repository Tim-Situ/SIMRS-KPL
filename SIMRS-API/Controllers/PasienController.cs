using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
public class PasienController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    public static List<Pasien> dataPasien = new List<Pasien>()
    {
        new Pasien("PSN01", "Fauzein Mulya Warman", "02-12-2003", "086377392", SIMRS_API.User.EnumJenisKelamin.PRIA, "Padang"),
        new Pasien("PSN02", "Muhammad Haulul Azkiyaa", "11-11-1111", "085785823", SIMRS_API.User.EnumJenisKelamin.PRIA, "Bandung"),
    };


    [HttpGet]
    public ActionResult<ApiResponse<Object>> Get()
    {
        response.message = "Data pasien berhasil ditampilkan";
        response.data = dataPasien;

        return Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult<ApiResponse<Object>> Get(int id)
    {
        if (id >= dataPasien.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pasien dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        response.message = "Data pasien ditemukan";
        response.data = dataPasien[id];

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<Object>> Post([FromBody] Pasien value)
    {
        dataPasien.Add(value);
        response.message = "Data pasien berhasil ditambahkan";
        response.data = dataPasien.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{id}")]
    public ActionResult<ApiResponse<Object>> Put(int id, [FromBody] Pasien value)
    {
        if (id >= dataPasien.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pasien dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataPasien[id] = value;
        response.message = "Data pasien berhasil diubah";
        response.data = dataPasien[id];

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public ActionResult<ApiResponse<Object>> Delete(int id)
    {
        if (id >= dataPasien.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pasien dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataPasien.RemoveAt(id);
        response.message = "Data pasien berhasil dihapus";

        return Ok(response);
    }
}

