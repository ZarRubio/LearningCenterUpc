using System;
using System.Collections.Generic;

namespace LearningCenter.Infraestructure
{
    public interface ICategoryRepository
    {
        List<string> getAll();

        string getCategoryById(int id);

        Boolean createCategory(string name);
    }
}