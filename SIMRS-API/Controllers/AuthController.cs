using Microsoft.AspNetCore.Mvc;
using SIMRS_API.helpers;
using SIMRS_LIB;

namespace SIMRS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private static string _jsonFilePath = "Data/DataAdmin.json";
        private static List<Admin> _dataAdmin;
        ApiResponse<Object> response = new ApiResponse<object>();

        [HttpPost("register")]
        public ActionResult<ApiResponse<Admin>> Register([FromBody] Admin value)
        {
            _dataAdmin = JsonUtils<List<Admin>>.ReadJsonFromFile(_jsonFilePath);
            Admin cariAdmin = _dataAdmin.FirstOrDefault(item => item.username == value.username);

            if (cariAdmin != null)
            {
                response.success = false;
                response.message = "Username sudah digunakan";

                return BadRequest(response);
            }

            value.password = PasswordHelper.HashPassword(value.password);

            _dataAdmin.Add(value);
            JsonUtils<List<Admin>>.WriteJsonFile(_dataAdmin, _jsonFilePath);

            response.message = "Register Berhasil...";

            return Ok(response);
        }

        [HttpPost("login")]
        public ActionResult<ApiResponse<Object>> Login([FromBody] Admin value)
        {

            _dataAdmin = JsonUtils<List<Admin>>.ReadJsonFromFile(_jsonFilePath);
            Admin cariAdmin = _dataAdmin.FirstOrDefault(item => item.username == value.username);


            if (cariAdmin == null || !PasswordHelper.VerifyPassword(value.password, cariAdmin.password))
            {
                response.success = false;
                response.message = "Username atau Password Salah...";
                return Unauthorized(response);
            }

            var token = JwtTokenHelper.GenerateToken(value.username);

            response.message = "Login Berhasil...";
            response.data = new { token = token };

            return Ok(response);
        }
    }
}

