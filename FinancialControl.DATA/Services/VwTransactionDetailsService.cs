using FinancialControl.DATA.Interfaces;
using FinancialControl.DATA.Models;
using FinancialControl.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialControl.DATA.Services
{
    public class VwTransactionDetailsService
    {
        protected readonly RepositoryVwTransactionDetails oRepositoryVwTransactionDetails;

        public VwTransactionDetailsService(RepositoryVwTransactionDetails repositoryVwTransactionDetails)
        {
            oRepositoryVwTransactionDetails = repositoryVwTransactionDetails;
        }

        public List<VwTransactionDetails> GetAll() => oRepositoryVwTransactionDetails.SelecionarTodos();
        public VwTransactionDetails Get(int id) => oRepositoryVwTransactionDetails.SelecionarPk(id);

    }
}
