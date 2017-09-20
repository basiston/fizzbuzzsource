using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzService
{
    public interface IFizzBuzzService
    {
        List<FizzBuzzModel> GetFizzBuzz(int? value);
    }
}
