using System;

namespace LearningCenter.Infraestructure;

public abstract  class BaseModel
{
    public DateTime DateCreted { get; set; }
    public DateTime DateUpdated { get; set; }
    public bool IsActive { get; set; }
}