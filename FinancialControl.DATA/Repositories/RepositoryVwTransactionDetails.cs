using FinancialControl.DATA.Interfaces;
using FinancialControl.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialControl.DATA.Repositories
{
    public class RepositoryVwTransactionDetails : RepositoryBase<VwTransactionDetails>, IRepositoryVwTransactionDetail
    {
        public RepositoryVwTransactionDetails(FinancialControlContext context) : base(context)
        {
            
        }
    }
}
