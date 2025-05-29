using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomController : ControllerBase
{
    private readonly IRoomService _roomService;

    public RoomController(IRoomService roomService)
    {
        _roomService = roomService;
    }

    //verileri getirme
    [HttpGet]
    public IActionResult RoomList()
    {
        var values = _roomService.TGetList();
        return Ok(values);
    }

    //yeni veri ekleme
    [HttpPost]
    public IActionResult AddRoom(Room room)
    {
        _roomService.TInsert(room);
        return Ok();
    }

    //veri silme
    [HttpDelete]
    public IActionResult DeleteRoom(int id)
    {
        var values = _roomService.TGetByID(id);
        _roomService.TDelete(values);
        return Ok();
    }

    //veri güncelleme
    [HttpPut]
    public IActionResult UpdateRoom(Room room)
    {
        _roomService.TUpdate(room);
        return Ok();
    }

    //id'ye göre veri getirme
    [HttpGet("{id}")]
    public IActionResult GetRoom(int id)
    {
        var values = _roomService.TGetByID(id);
        return Ok(values);
    }
}
