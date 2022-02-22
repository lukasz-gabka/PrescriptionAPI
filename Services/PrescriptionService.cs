using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PrescriptionAPI.Entities;
using PrescriptionAPI.Models;

namespace PrescriptionAPI.Services;

public class PrescriptionService
{
    private readonly ApiDbContext _dbContext;
    private readonly IMapper _mapper;

    public PrescriptionService(ApiDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public int Create(CreatePrescriptionDto dto)
    {
        var prescription = _mapper.Map<Prescription>(dto);

        _dbContext.Add(prescription);
        _dbContext.SaveChanges();

        return prescription.Id;
    }

    public IEnumerable<PrescriptionDto> GetAll()
    {
        var prescriptions = _dbContext.Prescriptions
            .Include(p => p.Patients)
            .ThenInclude(p => p.Medicines)
            .ToList();

        var dtos = _mapper.Map<IEnumerable<PrescriptionDto>>(prescriptions);

        return dtos;
    }

    public PrescriptionDto GetById(int id)
    {
        var prescription = _dbContext.Prescriptions
            .Where(p => p.Id == id)
            .Include(p => p.Patients)
            .ThenInclude(p => p.Medicines)
            .FirstOrDefault();

        var dto = _mapper.Map<PrescriptionDto>(prescription);

        return dto;
    }

    public bool Update(int id, PrescriptionDto dto)
    {
        var prescription = _dbContext.Prescriptions
            .Where(p => id == p.Id)
            .Include(p => p.Patients)
            .ThenInclude(p => p.Medicines)
            .FirstOrDefault();

        if (prescription is null)
        {
            return false;
        }

        prescription.IsActive = dto.IsActive;
        prescription.Patients = _mapper.Map<IEnumerable<Patient>>(dto.Patients);

        _dbContext.SaveChanges();

        return true;
    }
}
