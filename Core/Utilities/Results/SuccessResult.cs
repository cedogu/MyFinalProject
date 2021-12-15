using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true, message)
        {

        }

        public SuccessResult():base(true)
        {
            //böyle yaparak ProductManager'daki Add methodu içine SuccessResult'ı yolluyoruz. Oradan dönüş default olarak true gelir.
        }
    }
}
