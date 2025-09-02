using FinancialControl.DATA.Interfaces;
using FinancialControl.DATA.Models;
using FinancialControl.DATA.Repositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialControl.DATA.Services
{
    public class CategoryService
    {
        private readonly RepositoryCategory oRepositoryCategory;

        public CategoryService(RepositoryCategory repositoryCategory)
        {
            oRepositoryCategory = repositoryCategory;
        }

        public List<Category> GetCategories() 
        {
            return oRepositoryCategory.SelecionarTodos();
        }

        public Category GetCategory(int id) 
        { 
            return oRepositoryCategory.SelecionarPk(id);
        }

        public void CreateCategory(Category category)
        {
            oRepositoryCategory.Incluir(category);
        }

        public void UpdateCategory(Category category)
        {
            oRepositoryCategory.Alterar(category);
        }

        public void DeleteCategory(int id) 
        {
            oRepositoryCategory.Excluir(id);
        }
    }
}
