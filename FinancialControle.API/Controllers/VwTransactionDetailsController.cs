using Microsoft.AspNetCore.Mvc;
using FinancialControl.DATA.Services;
using FinancialControl.DATA.Models;

namespace FinancialControle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwTransactionDetailsController : ControllerBase
    {
        private readonly VwTransactionDetailsService oVwTransactionDetailsService;

        public VwTransactionDetailsController(VwTransactionDetailsService vwTransactionDetailsService)
        {
            oVwTransactionDetailsService = vwTransactionDetailsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VwTransactionDetails>> GetVwTransactionsDetail() 
        {
            List<VwTransactionDetails> oList = oVwTransactionDetailsService.GetAll();
            return Ok(oList);
        }

        //[HttpGet("{id}")]
        //public ActionResult<VwTransactionDetails> GetVwTransactionDetail(int id) 
        //{
        //    VwTransactionDetails item = oVwTransactionDetailsService.Get(id);
        //    return Ok(item);
        //}
    }
}
