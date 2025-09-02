using FinancialControl.DATA.Models;
using FinancialControl.DATA.Services;
using FinancialControle.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinancialControle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService oCategoryService;

        public CategoryController(CategoryService categoryService)
        {
            oCategoryService = categoryService;
        }

        [HttpPost]
        public ActionResult<Category> CreateCategory([FromBody] CategoryDTO categoryDTO)
        {
            Category category = new Category
            {
                CategoryName = categoryDTO.CategoryName
            };
            
            oCategoryService.CreateCategory(category);
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            List<Category> listCategory = oCategoryService.GetCategories();
            return Ok(listCategory);
        }

        [HttpGet("{id}")]
        public ActionResult<Category> GetCategory(int id)
        {
            Category category = oCategoryService.GetCategory(id);
            return Ok(category);
        }

        [HttpPut("{id}")]
        public ActionResult<Category> UpdateCategory(int id, [FromBody] Category category)
        {
            oCategoryService.UpdateCategory(category);
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            oCategoryService.DeleteCategory(id);
            return Ok();
        }
    }
}
