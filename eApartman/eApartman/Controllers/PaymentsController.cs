using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using eApartman.Stripe;
using eApartman.Database;

namespace eApartman.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController:ControllerBase
    {
        public readonly IOptions<StripeSettings> options;
        private readonly StripeClient _client;
        private readonly eApartmanContext _context;
        public PaymentsController(IOptions<StripeSettings> options, eApartmanContext context)
        {
            this.options = options;
            this._client = new StripeClient(this.options.Value.SecretKey);
            this._context = context;
        }
        [HttpPost("create-payment-intent")]
        public async Task<IActionResult> CreatePaymentIntent([FromBody]RezervacijaPayment request)
        {

            var options = new PaymentIntentCreateOptions
            {
                Amount = GetCijena(request),
                Currency="EUR",
                PaymentMethodTypes=new List<string>
                {
                    "card"
                }
            };
            var service = new PaymentIntentService(this._client);
            var paymentIntent = await service.CreateAsync(options);
            return Ok(new { client_secret = paymentIntent.ClientSecret });
        }

        private long GetCijena(RezervacijaPayment request)
        {
            var entity = _context.Set<Apartman>().Find(request.ApartmanId);
            return Convert.ToInt64(entity.Cijena * request.BrojDana * 100);
        }
    }
}
