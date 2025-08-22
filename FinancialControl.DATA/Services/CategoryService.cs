using FinancialControl.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialControl.DATA.Services
{
    public class CategoryService
    {
        public RepositoryCategory oRepositoryCategory { get; set; }

        public CategoryService()
        {
            oRepositoryCategory = new RepositoryCategory();
        }
    }
}
