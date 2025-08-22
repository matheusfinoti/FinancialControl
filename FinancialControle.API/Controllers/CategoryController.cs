using FinancialControl.DATA.Models;
using FinancialControl.DATA.Services;

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
            public ActionResult<Category> CreateCategory([FromBody] Category category)
            {
                oCategoryService.oRepositoryCategory.Incluir(category);
                return Ok();
            }

            [HttpGet]
            public ActionResult<IEnumerable<Category>> GetCategories()
            {
                List<Category> listCategory = oCategoryService.oRepositoryCategory.SelecionarTodos();
                return Ok(listCategory);
            }

            [HttpGet("{id}")]
            public ActionResult<Category> GetCategory(int id)
            {
                Category category = oCategoryService.oRepositoryCategory.SelecionarPk(id);
                return Ok(category);
            }

        [HttpPut("{id}")]
        public ActionResult<Category> UpdateCategory(int id, [FromBody] Category category)
        {
            oCategoryService.oRepositoryCategory.Alterar(category);
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            oCategoryService.oRepositoryCategory.Excluir(id);
            return Ok();
        }
    }
}
