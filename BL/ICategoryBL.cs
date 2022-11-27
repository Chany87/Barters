using DAL.Models;
using DTO;
using System.Collections.Generic;

namespace BL
{
    public interface ICategoryBL
    {
        List<CategoryDTO> GetAllCategories();
        CategoryDTO GetCategoryById(int id);
        bool UpdateCategory(int id, CategoryDTO categoryDTO);
        bool AddCategory(CategoryDTO categoryDTO);
        bool DeleteCategory(int id);
    }
}