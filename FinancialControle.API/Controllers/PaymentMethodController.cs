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

            oPaymentMethodService.CreatePaymentMethod(paymentMethod);
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<PaymentMethod>> GetPaymentMethod()
        {
            List<PaymentMethod> listCategory = oPaymentMethodService.GetPaymentMethods();
            return Ok(listCategory);
        }

        [HttpGet("{id}")]
        public ActionResult<PaymentMethod> GetPaymentMethod(int id)
        {
            PaymentMethod paymentMethod = oPaymentMethodService.GetPaymentMethod(id);
            return Ok(paymentMethod);
        }

        [HttpPut("{id}")]
        public ActionResult<PaymentMethodDTO> UpdateCategory(int id, PaymentMethodDTO paymentMethodDTO)
        {
            if (id != paymentMethodDTO.Id)
                return BadRequest("O ID da URL e do corpo da requisição não correspondem.");

            var existingCategory = oPaymentMethodService.GetPaymentMethod(id);

            if (existingCategory == null)
                return NotFound("Método de pagamento não encontrada.");

            existingCategory.PaymentMethodl = paymentMethodDTO.PaymentMethodl;

            oPaymentMethodService.UpdatePaymentMethod(existingCategory);

            return Ok(paymentMethodDTO);
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePaymentMethod(int id)
        {
            oPaymentMethodService.DeletePaymentMethod(id);
            return Ok();
        }
    }
}
