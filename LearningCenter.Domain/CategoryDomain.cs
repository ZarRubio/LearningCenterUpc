using System;
using System.Collections.Generic;
using LearningCenter.Infraestructure;

namespace LearningCenter.Domain
{
    public class CategoryDomain : ICategoryDomain

    {
        private ICategoryRepository _categoryRepository;

        public CategoryDomain(ICategoryRepository categoryRepository)

        {

            _categoryRepository = categoryRepository;

        }


        public List<string> getAll()

        {

            return _categoryRepository.getAll();
        }



        public string getCategoryById(int id)

        {

            return "body from Domain  " + id.ToString();

        }



        public bool createCategory(string name)

        {

            throw new NotImplementedException();

        }

    }
}