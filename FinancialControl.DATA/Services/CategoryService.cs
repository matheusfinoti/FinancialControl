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

        public List<Category> GetAll() => oRepositoryCategory.SelecionarTodos();
        public Category Get(int id) => oRepositoryCategory.SelecionarPk(id);
        public void Add(Category category) => oRepositoryCategory.Incluir(category);
        public void Update(Category category) => oRepositoryCategory.Alterar(category);
        public void Delete(int id) => oRepositoryCategory.Excluir(id);
    }
}
