using LittleMiddleHospital.BL.DTOs;
using LittleMiddleHospital.Core.Entities;

namespace LittleMiddleHospital.BL.Service.PatienceService;

public interface IPatienceService
{
    Task CreatePatience(PatientCreateDTO dto);
    Task DeletePatience(int id);
    List<Patient> GetAllPatience();
    Task<Patient?> GetPatienceById(int id);
}