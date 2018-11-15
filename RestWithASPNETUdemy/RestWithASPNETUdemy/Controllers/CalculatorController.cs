using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        // GET api/values/5/5
        [HttpGet("sum/{firstNum}/{secondNum}")]
        public IActionResult sum(string firstNum, string secondNum)
        {
            if(IsNumeric(firstNum) && IsNumeric(secondNum))
            {
                var sum = ConvertToDecimal(firstNum) + ConvertToDecimal(secondNum);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }
        
        // GET api/values/5/5
        [HttpGet("sub/{firstNum}/{secondNum}")]
        public IActionResult sub(string firstNum, string secondNum)
        {
            if(IsNumeric(firstNum) && IsNumeric(secondNum))
            {
                var sum = ConvertToDecimal(firstNum) - ConvertToDecimal(secondNum);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }
        
        // GET api/values/5/5
        [HttpGet("mul/{firstNum}/{secondNum}")]
        public IActionResult mul(string firstNum, string secondNum)
        {
            if(IsNumeric(firstNum) && IsNumeric(secondNum))
            {
                var sum = ConvertToDecimal(firstNum) * ConvertToDecimal(secondNum);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }
        
        // GET api/values/5/5
        [HttpGet("div/{firstNum}/{secondNum}")]
        public IActionResult div(string firstNum, string secondNum)
        {
            


            if (IsNumeric(firstNum) && IsNumeric(secondNum))
            {
                if (secondNum == "0")
                    return BadRequest("Zero division error");

                    var sum = ConvertToDecimal(firstNum) / ConvertToDecimal(secondNum);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string num)
        {
            decimal output = 0;
            Decimal.TryParse(num, out output);
            return output;
        }

        private bool IsNumeric(string num)
        {
            double number;

            bool isNumber = double.TryParse(num, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }
    }
}
