using FinancialControl.DATA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FinancialControl.DATA.Repositories
{
    internal class RepositoryTransaction : RepositoryBase<Transaction>, IRepositoryTransaction
    {
    }
}
