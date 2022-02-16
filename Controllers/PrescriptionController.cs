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
}
