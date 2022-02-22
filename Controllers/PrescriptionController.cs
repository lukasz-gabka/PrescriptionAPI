using Microsoft.AspNetCore.Mvc;
using PrescriptionAPI.Models;
using PrescriptionAPI.Services;

namespace PrescriptionAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PrescriptionController : ControllerBase
{
    private readonly PrescriptionService _service;

    public PrescriptionController(PrescriptionService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult Create(CreatePrescriptionDto dto)
    {
        var id = _service.Create(dto);

        return Created($"api/prescpiption/{id}", null);
    }

    [HttpGet]
    public ActionResult<IEnumerable<PrescriptionDto>> Get()
    {
        var dtos = _service.GetAll();

        return dtos is null || dtos.Count() == 0 ? NoContent() : Ok(dtos);
    }

    [HttpGet("{id}")]
    public ActionResult<PrescriptionDto> Get([FromRoute] int id)
    {
        var dto = _service.GetById(id);

        return dto is null ? NotFound() : dto;
    }

    [HttpPut("{id}")]
    public ActionResult Update([FromRoute] int id, [FromBody] PrescriptionDto dto)
    {
        var isUpdated = _service.Update(id, dto);

        return isUpdated ? NoContent() : NotFound();
    }
}
