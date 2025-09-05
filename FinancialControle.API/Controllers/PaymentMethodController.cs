using FinancialControl.DATA.Models;
using FinancialControl.DATA.Repositories;
using FinancialControl.DATA.Services;
using FinancialControle.API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FinancialControle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : ControllerBase
    {
        private readonly PaymentMethodService oPaymentMethodService;

        public PaymentMethodController(PaymentMethodService paymentMethodService)
        {
            oPaymentMethodService = paymentMethodService;
        }

        [HttpPost]
        public ActionResult<PaymentMethod> CreatePaymentMethod([FromBody] PaymentMethodDTO paymentMethodDTO)
        {
            PaymentMethod paymentMethod = new PaymentMethod
            {
                PaymentMethodl = paymentMethodDTO.PaymentMethodl
            };

            oPaymentMethodService.Create(paymentMethod);
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<PaymentMethod>> GetPaymentMethod()
        {
            List<PaymentMethod> listCategory = oPaymentMethodService.GetAll();
            return Ok(listCategory);
        }

        [HttpGet("{id}")]
        public ActionResult<PaymentMethod> GetPaymentMethod(int id)
        {
            PaymentMethod paymentMethod = oPaymentMethodService.Get(id);
            return Ok(paymentMethod);
        }

        [HttpPut("{id}")]
        public ActionResult<PaymentMethodDTO> UpdateCategory(int id, PaymentMethodDTO paymentMethodDTO)
        {
            if (id != paymentMethodDTO.Id)
                return BadRequest("O ID da URL e do corpo da requisição não correspondem.");

            var existingCategory = oPaymentMethodService.Get(id);

            if (existingCategory == null)
                return NotFound("Método de pagamento não encontrada.");

            existingCategory.PaymentMethodl = paymentMethodDTO.PaymentMethodl;

            oPaymentMethodService.Update(existingCategory);

            return Ok(paymentMethodDTO);
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePaymentMethod(int id)
        {
            oPaymentMethodService.Delete(id);
            return Ok();
        }
    }
}
