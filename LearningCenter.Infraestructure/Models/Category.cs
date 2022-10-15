using System.Collections.Generic;
using System.Dynamic;

namespace LearningCenter.Infraestructure
{
    public class Category:BaseModel
    {
        public int id{get; set; }
        public string name {get; set; }
        public List<Tutorial> Tutorials { get; set; }
    }
}