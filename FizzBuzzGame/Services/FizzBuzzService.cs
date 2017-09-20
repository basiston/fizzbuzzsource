using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FizzBuzzGame.Models;

namespace FizzBuzzGame.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        /// <summary>
        /// This method returns list of value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>List of values</returns>
        public List<FizzBuzzModel> GetFizzBuzz(int? value)
        {

            var fizzBuzzlist = new List<FizzBuzzModel>();

            for (int i = 1; i <= value; i++)
            {
                string fizzbuzzreturnvalue;

                if (i % 3 == 0)
                {
                    fizzbuzzreturnvalue = Convert.ToString(PlayerTypes.Fizz);
                }
                else if (i % 5 == 0)
                {
                    fizzbuzzreturnvalue = Convert.ToString(PlayerTypes.Buzz);
                }

                else
                {
                    fizzbuzzreturnvalue = Convert.ToString(i);
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzbuzzreturnvalue = Convert.ToString(PlayerTypes.FizzBuzz);
                }


                fizzBuzzlist.Add(new FizzBuzzModel { Value = fizzbuzzreturnvalue });

            }
            return fizzBuzzlist;
        }
    }

    public enum PlayerTypes
    {
        Fizz,
        Buzz,
        FizzBuzz

    }
}