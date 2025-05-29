using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StaffController : ControllerBase
{
    private readonly IStaffService _staffService;

    public StaffController(IStaffService staffService)
    {
        _staffService = staffService;
    }

    //verileri getirme
    [HttpGet]
    public IActionResult StaffList()
    {
        var values = _staffService.TGetList();
        return Ok(values);
    }

    //yeni veri ekleme
    [HttpPost]
    public IActionResult AddStaff(Staff staff)
    {
        _staffService.TInsert(staff);
        return Ok();
    }

    //veri silme
    [HttpDelete]
    public IActionResult DeleteStaff(int id)
    {
        var values = _staffService.TGetByID(id);
        _staffService.TDelete(values);
        return Ok();
    }

    //veri güncelleme
    [HttpPut]
    public IActionResult UpdateStaff(Staff staff)
    {
        _staffService.TUpdate(staff);
        return Ok();
    }

    //id'ye göre veri getirme
    [HttpGet("{id}")]
    public IActionResult GetStaff(int id)
    {
        var values = _staffService.TGetByID(id);
        return Ok(values);
    }
}
