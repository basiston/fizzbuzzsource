using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FizzBuzzGame.Models;
using FizzBuzzService;
using FizzBuzzService.Models;

namespace FizzBuzzGame.Controllers
{
    public class FizzBuzzController : ApiController
    {
        private readonly IFizzBuzzService _service;
        public FizzBuzzController()
        {
            _service = new FizzBuzzService.FizzBuzzService();
        }

        /// <summary>
        /// Get the list of FizzBuzzModel based on if the value is divisible with 3, 5 or either 3 and 5
        /// </summary>
        /// <param name="value">number shouldu be greater than 0</param>
        /// <returns></returns>
        [HttpGet]

        public IEnumerable<FizzBuzzModel> Get(int? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            var vm = new List<FizzBuzzViewModel>();
            return _service.GetFizzBuzz(value);

        }
    }
}
