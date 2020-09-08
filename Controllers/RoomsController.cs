using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApiPractice.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class RoomsController : ControllerBase
    {
        [HttpGet(Name = nameof(GetRooms))]
        public IActionResult GetRooms()
        {
            throw new NotImplementedException();
        }
    }
}