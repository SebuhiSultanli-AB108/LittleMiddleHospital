namespace LittleMiddleHospital.Core.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? DeletedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
