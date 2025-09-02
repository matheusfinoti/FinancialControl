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

        public List<PaymentMethod> GetPaymentMethods()
        {
            return oRepositoryPaymentMethod.SelecionarTodos();
        }

        public PaymentMethod GetPaymentMethod(int id)
        {
            return oRepositoryPaymentMethod.SelecionarPk(id);
        }

        public void CreatePaymentMethod(PaymentMethod paymentMethod)
        {
            oRepositoryPaymentMethod.Incluir(paymentMethod);
        }

        public void UpdatePaymentMethod(PaymentMethod paymentMethod)
        {
            oRepositoryPaymentMethod.Alterar(paymentMethod);
        }

        public void DeletePaymentMethod(int id)
        {
            oRepositoryPaymentMethod.Excluir(id);
        }
    }
}
