using FinancialControl.DATA.Interfaces;
using FinancialControl.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialControl.DATA.Repositories
{
    internal class RepositoryVwTransactionDetail : RepositoryBase<VwTransactionDetail>, IRepositoryVwTransactionDetail
    {
        public RepositoryVwTransactionDetail(FinancialControlContext context) : base(context)
        {
            
        }
    }
}
