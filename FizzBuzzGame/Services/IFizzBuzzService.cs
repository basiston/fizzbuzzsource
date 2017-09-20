using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FizzBuzzGame.Models;

namespace FizzBuzzGame.Services
{
    public  interface IFizzBuzzService
    {
        List<FizzBuzzModel> GetFizzBuzz(int? value);
    }
}