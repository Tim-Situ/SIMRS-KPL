using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
public class PemeriksaanController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    //public static List<Obat> obatPasien = new List<Obat>()
    //{
    //    ObatController.dataObat[1]
    //};

    private static List<Pemeriksaan> dataPemeriksaan;
    //    = new List<Pemeriksaan>()s
    //{
    //    new Pemeriksaan("PRS01", PasienController.dataPasien[0], DokterController.dataDokter[0], "29-04-2024", 200, 60, 12, "Pusing", "Kebanyakan Tubes", obatPasien),
    //    new Pemeriksaan("PRS02", PasienController.dataPasien[0], DokterController.dataDokter[0], "30-04-2024", 200, 60, 12, "Sakit Gigi", "Gigi Berlubang", obatPasien)
    //};


    [HttpGet]
    public ActionResult<ApiResponse<Object>> Get()
    {
        response.message = "Data pemeriksaan berhasil ditampilkan";
        response.data = dataPemeriksaan;

        return Ok(response);
    }

    [HttpGet("{id}")]
    public ActionResult<ApiResponse<Object>> Get(int id)
    {
        if (id >= dataPemeriksaan.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pemeriksaan dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        response.message = "Data pemeriksaan ditemukan";
        response.data = dataPemeriksaan[id];

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<Object>> Post([FromBody] Pemeriksaan value)
    {
        dataPemeriksaan.Add(value);
        response.message = "Data pemeriksaan berhasil ditambahkan";
        response.data = dataPemeriksaan.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    [HttpPut("{id}")]
    public ActionResult<ApiResponse<Object>> Put(int id, [FromBody] Pemeriksaan value)
    {
        if (id >= dataPemeriksaan.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pemeriksaan dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataPemeriksaan[id] = value;
        response.message = "Data pemeriksaan berhasil diubah";
        response.data = dataPemeriksaan[id];

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public ActionResult<ApiResponse<Object>> Delete(int id)
    {
        if (id >= dataPemeriksaan.Count || id < 0)
        {
            response.success = false;
            response.message = $"Data pemeriksaan dengan Index : {id} tidak ditemukan";

            return NotFound(response);
        }

        dataPemeriksaan.RemoveAt(id);
        response.message = "Data pemeriksaan berhasil dihapus";

        return Ok(response);
    }
}

