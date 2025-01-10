namespace LittleMiddleHospital.BL.DTOs;

public class PatientCreateDTO
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Gender { get; set; }
    public int BloodGroup { get; set; }
    public string PhoneNumber { get; set; }
    public string SeriaNumber { get; set; }
    public string RegistrationAddress { get; set; }
    public string CurrentAddress { get; set; }
    public int InsuranceId { get; set; }
    public string Email { get; set; }
}
