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
            
            oCategoryService.Add(category);
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            List<Category> listCategory = oCategoryService.GetAll();
            return Ok(listCategory);
        }

        [HttpGet("{id}")]
        public ActionResult<Category> GetCategory(int id)
        {
            Category category = oCategoryService.Get(id);
            return Ok(category);
        }

        [HttpPut("{id}")]
        public ActionResult<CategoryDTO> UpdateCategory(int id, CategoryDTO categoryDto)
        {
            if (id != categoryDto.Id)
                return BadRequest("O ID da URL e do corpo da requisição não correspondem.");

            var existingCategory = oCategoryService.Get(id);

            if (existingCategory == null)
                return NotFound("Categoria não encontrada.");

            existingCategory.CategoryName = categoryDto.CategoryName;

            oCategoryService.Update(existingCategory);

            return Ok(categoryDto);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            oCategoryService.Delete(id);
            return Ok();
        }
    }
}
