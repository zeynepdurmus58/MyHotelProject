using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribeController : ControllerBase
{
    private readonly ISubscribeService _subscribeService;

    public SubscribeController(ISubscribeService subscribeService)
    {
        _subscribeService = subscribeService;
    }

    //verileri getirme
    [HttpGet]
    public IActionResult SubscribeList()
    {
        var values = _subscribeService.TGetList();
        return Ok(values);
    }

    //yeni veri ekleme
    [HttpPost]
    public IActionResult AddSubscribe(Subscribe subscribe)
    {
        _subscribeService.TInsert(subscribe);
        return Ok();
    }

    //veri silme
    [HttpDelete]
    public IActionResult DeleteSubscribe(int id)
    {
        var values = _subscribeService.TGetByID(id);
        _subscribeService.TDelete(values);
        return Ok();
    }

    //veri güncelleme
    [HttpPut]
    public IActionResult UpdateSubscribe(Subscribe subscribe)
    {
        _subscribeService.TUpdate(subscribe);
        return Ok();
    }

    //id'ye göre veri getirme
    [HttpGet("{id}")]
    public IActionResult GetSubscribe(int id)
    {
        var values = _subscribeService.TGetByID(id);
        return Ok(values);
    }
}
