using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIMRS_LIB;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIMRS_API;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class PembayaranController : Controller
{
    ApiResponse<Object> response = new ApiResponse<object>();

    private static string jsonFilePath = "Data/DataPembayaran.json";
    private static List<Pembayaran> dataPembayaran;

    [HttpGet]
    public ActionResult<ApiResponse<List<Pembayaran>>> Get()
    {
        dataPembayaran = JsonUtils<List<Pembayaran>>.ReadJsonFromFile(jsonFilePath);
        response.message = "Data pembayaran berhasil ditampilkan";
        response.data = dataPembayaran;

        return Ok(response);
    }

    [HttpGet("{kode}")]
    public ActionResult<ApiResponse<Pembayaran>> Get(string kode)
    {
        dataPembayaran = JsonUtils<List<Pembayaran>>.ReadJsonFromFile(jsonFilePath);

        if (!dataPembayaran.Any(item => item.kode == kode))
        {
            response.success = false;
            response.message = $"Data pembayaran dengan kode : {kode} tidak ditemukan";
            response.data = null;

            return NotFound(response);
        }

        response.message = "Data pembayaran ditemukan";
        response.data = dataPembayaran.FirstOrDefault(item => item.kode == kode);

        return Ok(response);
    }

    [HttpPost]
    public ActionResult<ApiResponse<Pembayaran>> Post([FromBody] Pembayaran value)
    {
        dataPembayaran = JsonUtils<List<Pembayaran>>.ReadJsonFromFile(jsonFilePath);
        dataPembayaran.Add(value);
        JsonUtils<List<Pembayaran>>.WriteJsonFile(dataPembayaran, jsonFilePath);
        response.message = "Data pembayaran berhasil ditambahkan";
        response.data = dataPembayaran.Last();

        return CreatedAtAction(nameof(Get), response);
    }

    //[HttpPut("{kode}")]
    //public ActionResult<ApiResponse<Pembayaran>> Put(string kode, [FromBody] Pembayaran value)
    //{
    //    dataPembayaran = JsonUtils<List<Pembayaran>>.ReadJsonFromFile(jsonFilePath);

    //    if (!dataPembayaran.Any(item => item.kode == kode))
    //    {
    //        response.success = false;
    //        response.message = $"Data pembayaran dengan kode : {kode} tidak ditemukan";
    //        response.data = null;

    //        return NotFound(response);
    //    }

    //    int idx = dataPembayaran.FindIndex(item => item.kode == kode);
    //    dataPembayaran[idx] = value;
    //    JsonUtils<List<Pembayaran>>.WriteJsonFile(dataPembayaran, jsonFilePath);

    //    response.message = "Data pembayaran berhasil diubah";
    //    response.data = dataPembayaran[idx];

    //    return Ok(response);
    //}

    [HttpDelete("{kode}")]
    public ActionResult<ApiResponse<Object>> Delete(string kode)
    {
        dataPembayaran = JsonUtils<List<Pembayaran>>.ReadJsonFromFile(jsonFilePath);

        if (!dataPembayaran.Any(item => item.kode == kode))
        {
            response.success = false;
            response.message = $"Data pembayaran dengan kode : {kode} tidak ditemukan";
            response.data = null;

            return NotFound(response);
        }

        int idx = dataPembayaran.FindIndex(item => item.kode == kode);
        dataPembayaran.RemoveAt(idx);
        JsonUtils<List<Pembayaran>>.WriteJsonFile(dataPembayaran, jsonFilePath);
        response.message = "Data pembayaran berhasil dihapus";

        return Ok(response);
    }
}

