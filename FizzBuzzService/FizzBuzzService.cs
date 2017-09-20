using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzService.Models;

namespace FizzBuzzService
{
    public class FizzBuzzService : IFizzBuzzService
    {


        private string Fizz { get; set; } = "Fizz";
        private string Buzz { get; set; } = "Buzz";
        private string FizzBuzz { get; set; } = "FizzBuzz";



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
                    fizzbuzzreturnvalue = Fizz;
                }
                else if (i % 5 == 0)
                {
                    fizzbuzzreturnvalue = Buzz;
                }

                else
                {
                    fizzbuzzreturnvalue = Convert.ToString(i);
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzbuzzreturnvalue = FizzBuzz;
                }


                fizzBuzzlist.Add(new FizzBuzzModel { Value = fizzbuzzreturnvalue });

            }
            return fizzBuzzlist;
        }
    }
}
