using BL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryBL _categoryBL;
        public CategoryController(ICategoryBL categoryBL)
        {
            _categoryBL = categoryBL;
        }
        [HttpGet]
        [Route("GetAllCategories")]
        public ActionResult<List<CategoryDTO>> GetAllcategories()
        {
            List<CategoryDTO> categories = _categoryBL.GetAllCategories();
            if (categories == null)
                return NotFound();
            return Ok(categories);
        }
        [HttpGet]
        [Route("GetCategoryById")]
        public ActionResult<CategoryDTO> GetcategoryById(int id)
        {
           CategoryDTO category = _categoryBL.GetCategoryById(id);
            if (category == null)
                return NotFound();
            return Ok(category);
        }
        [HttpPut]
        [Route("UpDate/{id}")]
        public ActionResult<bool> Updatecategory(int id, [FromBody] CategoryDTO categoryDTO)
        {
            if (categoryDTO.Id != id)
                return StatusCode(400, "קוד קטגוריה זה לא קיים במערכת");
            return Ok(_categoryBL.UpdateCategory(id, categoryDTO));
        }
        [HttpPost]
        [Route("Add")]
        public ActionResult<bool> AddCategory([FromBody] CategoryDTO categoryDTO)
        {

            return Ok(_categoryBL.AddCategory(categoryDTO));

        }

        [HttpDelete]
        [Route("delete/{id}")]
        public ActionResult<bool> DeleteCategory(int id)
        {

            return Ok(_categoryBL.DeleteCategory(id));

        }

    }
}
