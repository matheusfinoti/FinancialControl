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
    public class PaymentMethodService
    {
        private readonly RepositoryPaymentMethod oRepositoryPaymentMethod;

        public PaymentMethodService(RepositoryPaymentMethod repositoryPaymentMethod)
        {
            oRepositoryPaymentMethod = repositoryPaymentMethod;
        }

        public List<PaymentMethod> GetAll() => oRepositoryPaymentMethod.SelecionarTodos();
        public PaymentMethod Get(int id) => oRepositoryPaymentMethod.SelecionarPk(id);
        public void Create(PaymentMethod paymentMethod) => oRepositoryPaymentMethod.Incluir(paymentMethod);
        public void Update(PaymentMethod paymentMethod) => oRepositoryPaymentMethod.Alterar(paymentMethod);
        public void Delete(int id) => oRepositoryPaymentMethod.Excluir(id);
    }
}
