using FinancialControl.DATA.Models;
using FinancialControl.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialControl.DATA.Services
{
    public class TransactionService
    {
        private readonly RepositoryTransaction oRepositoryTransaction;

        public TransactionService(RepositoryTransaction repositoryTransaction)
        {
            oRepositoryTransaction = repositoryTransaction;
        }

        public List<Transaction> GetAll() => oRepositoryTransaction.SelecionarTodos();
        public Transaction Get(int id) => oRepositoryTransaction.SelecionarPk(id);
        public void Create(Transaction transaction) => oRepositoryTransaction.Incluir(transaction);
        public void Update(Transaction transaction) => oRepositoryTransaction.Alterar(transaction);
        public void Delete(int id) => oRepositoryTransaction.Excluir(id);
    }
}
