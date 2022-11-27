using AutoMapper;
using DAL;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;

namespace BL
{
    public class CategoryBL : ICategoryBL
    {


        ICategoryDAL _categoryDAL;
        IMapper mapper;
        public CategoryBL(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        public List<CategoryDTO> GetAllCategories()
        {

            List<Category>listCategory= _categoryDAL.GetAllCategories();
            return mapper.Map<List<CategoryDTO>>(listCategory);
        }
        public bool UpdateCategory(int id, CategoryDTO categoryDTO)
        {
            try
            {
               Category category= mapper.Map<Category>(categoryDTO);
                return _categoryDAL.UpdateCategory(id, category);


            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool AddCategory(CategoryDTO categoryDTO)
        {
            //פונקצית הוספה
            try
            {
                Category category = mapper.Map<Category>(categoryDTO);
                return _categoryDAL.AddCategory(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteCategory(int id)
        {
            // פונקצית מחיקה
            try
            {

                return _categoryDAL.DeleteCategory(id);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public CategoryDTO GetCategoryById(int id)
        {
            //select * from Users; 
            try
            {
                Category category = _categoryDAL.GetCategoryById(id);
                return mapper.Map<CategoryDTO>(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

