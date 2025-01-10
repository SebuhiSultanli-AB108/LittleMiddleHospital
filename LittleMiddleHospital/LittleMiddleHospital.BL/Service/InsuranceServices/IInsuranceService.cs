using LittleMiddleHospital.BL.DTOs;
using LittleMiddleHospital.Core.Entities;

namespace LittleMiddleHospital.BL.Service.InsuranceServices;

public interface IInsuranceService
{
    Task CreatePatience(InsuranceCreateDTO dto);
    Task DeletePatience(int id);
    List<Insurance> GetAllPatience();
    Task<Insurance?> GetPatienceById(int id);
}
