using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestimonialController : ControllerBase
{
    private readonly ITestimonialService _testimonialService;

    public TestimonialController(ITestimonialService testimonialService)
    {
        _testimonialService = testimonialService;
    }

    //verileri getirme
    [HttpGet]
    public IActionResult TestimonialList()
    {
        var values = _testimonialService.TGetList();
        return Ok(values);
    }

    //yeni veri ekleme
    [HttpPost]
    public IActionResult AddTestimonial(Testimonial testimonial)
    {
        _testimonialService.TInsert(testimonial);
        return Ok();
    }

    //veri silme
    [HttpDelete]
    public IActionResult DeleteTestimonial(int id)
    {
        var values = _testimonialService.TGetByID(id);
        _testimonialService.TDelete(values);
        return Ok();
    }

    //veri güncelleme
    [HttpPut]
    public IActionResult UpdateTestimonial(Testimonial testimonial)
    {
        _testimonialService.TUpdate(testimonial);
        return Ok();
    }

    //id'ye göre veri getirme
    [HttpGet("{id}")]
    public IActionResult GetTestimonial(int id)
    {
        var values = _testimonialService.TGetByID(id);
        return Ok(values);
    }
}
