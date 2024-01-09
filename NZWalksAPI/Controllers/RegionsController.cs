using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Controllers
{
    ///https://localhost:7061/api/regions             khi url gọi đến tên sau gạch chéo regions sẽ tương ứng với bộ điều khiển RegionsController và phương thức bên dưới sẽ hoạt động
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet] //đang tạo phương thức lấy tất cả nên sẽ dùng httpget
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Name",
                    Code = "123",
                    RegionImageUrl ="fsdfgsfgsgsgsdg"
                }
            };
            return Ok(regions);
    

        }
    }
}
