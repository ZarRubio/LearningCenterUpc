using System;

namespace LearningCenter.Infraestructure;

public class BaseModel
{
    public DateTime DateCreted { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool IsActive { get; set; }
}