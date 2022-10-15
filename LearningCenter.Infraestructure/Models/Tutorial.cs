namespace LearningCenter.Infraestructure;

public class Tutorial:BaseModel
{
    public int id {get; set; }
    public string Title {get; set; }
    public int year {get; set; }
    
    public int categoryID {get; set; }
    public Category Category {get; set; }
}