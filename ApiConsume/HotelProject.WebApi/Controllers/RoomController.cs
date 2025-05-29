using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomController : ControllerBase
{
    //verileri getirme
    [HttpGet]
    public IActionResult RoomList()
    {
        return Ok();
    }

    //yeni veri ekleme
    [HttpPost]
    public IActionResult AddRoom()
    {
        return Ok();
    }

    //veri silme
    [HttpDelete]
    public IActionResult DeleteRoom()
    {
        return Ok();
    }

    //veri güncelleme
    [HttpPut]
    public IActionResult UpdateRoom()
    {
        return Ok();
    }

    //id'ye göre veri getirme
    [HttpGet("{id}")]
    public IActionResult GetRoom()
    {
        return Ok();
    }
}
