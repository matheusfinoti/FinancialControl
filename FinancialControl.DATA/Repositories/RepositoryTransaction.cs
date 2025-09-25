using FinancialControl.DATA.Interfaces;
using FinancialControl.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialControl.DATA.Repositories
{
    public class RepositoryTransaction : RepositoryBase<Transaction>, IRepositoryTransaction
    {
        public RepositoryTransaction(FinancialControlContext context) :base(context)
        {
            
        }
    }
}
