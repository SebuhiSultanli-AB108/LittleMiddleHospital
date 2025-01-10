﻿using LittleMiddleHospital.Core.Enums;

namespace LittleMiddleHospital.Core.Entities;

public class Patient : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public BloodGroup BloodGroup { get; set; }
    public string PhoneNumber { get; set; }
    public string SeriaNumber { get; set; }
    public string RegistrationAddress { get; set; }
    public string CurrentAddress { get; set; }
    public int InsuranceId { get; set; }
    public Insurance Insurance { get; set; }
    public string Email { get; set; }
}
