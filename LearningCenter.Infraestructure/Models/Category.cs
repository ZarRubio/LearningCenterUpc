using System.Collections.Generic;
using System.Dynamic;

namespace LearningCenter.Infraestructure
{
    public class Category
    {
        public int id{get; set; }
        public string name {get; set; }
        public List<Tutorial> Tutorials { get; set; }
    }
}