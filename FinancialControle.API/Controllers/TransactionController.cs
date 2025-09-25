using FinancialControl.DATA.Models;
using FinancialControl.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinancialControle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionService oTransactionService;

        public TransactionController(TransactionService transactionService)
        {
            oTransactionService = transactionService;
        }

        [HttpPost]
        public ActionResult<Transaction> CreateTransaction(Transaction transaction) 
        {
            oTransactionService.Create(transaction);
            return Ok(transaction);
        }


        [HttpGet]
        public ActionResult<IEnumerable<Transaction>> GetTransactions() 
        {
            List<Transaction> listTransactions = oTransactionService.GetAll();
            return Ok(listTransactions);
        }

        [HttpGet("{id}")]
        public ActionResult<Transaction> GetTransaction(int id)
        {
            Transaction transaction = oTransactionService.Get(id);
            return Ok(transaction);
        }

        [HttpPut("{id}")]
        public ActionResult<Transaction> UpdateTransaction(int id, Transaction transaction) 
        {
            if (id != transaction.Id)
                return BadRequest("ID Incorreto");
            
            var existingTransaction = oTransactionService.Get(id);

            if (existingTransaction != null)
                return NotFound("Transaction not Found");

            existingTransaction.TransactionDescription = transaction.TransactionDescription;

            oTransactionService.Update(existingTransaction);

            return Ok(existingTransaction);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTransaction(int id)
        {
            oTransactionService.Delete(id);
            return Ok();
        }
    }
}
