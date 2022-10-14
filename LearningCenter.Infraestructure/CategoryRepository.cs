using System.Collections.Generic;

namespace LearningCenter.Infraestructure
{
    public class CategoryRepository:ICategoryRepository
    {
        public List<string> getAll()
        {
            return new List<string>() { "value1 v2 repository ", "value2 v2 repository" };
            
        }

        public string getCategoryById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool createCategory(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}