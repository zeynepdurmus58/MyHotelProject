using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceController : ControllerBase
{
    private readonly IServiceService _serviceService;

    public ServiceController(IServiceService serviceService)
    {
        _serviceService = serviceService;
    }

    //verileri getirme
    [HttpGet]
    public IActionResult ServiceList()
    {
        var values = _serviceService.TGetList();
        return Ok(values);
    }

    //yeni veri ekleme
    [HttpPost]
    public IActionResult AddService(Service service)
    {
        _serviceService.TInsert(service);
        return Ok();
    }

    //veri silme
    [HttpDelete]
    public IActionResult DeleteService(int id)
    {
        var values = _serviceService.TGetByID(id);
        _serviceService.TDelete(values);
        return Ok();
    }

    //veri güncelleme
    [HttpPut]
    public IActionResult UpdateService(Service service)
    {
        _serviceService.TUpdate(service);
        return Ok();
    }

    //id'ye göre veri getirme
    [HttpGet("{id}")]
    public IActionResult GetService(int id)
    {
        var values = _serviceService.TGetByID(id);
        return Ok(values);
    }
}
