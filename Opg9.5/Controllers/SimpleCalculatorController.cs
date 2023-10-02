using Microsoft.AspNetCore.Mvc;

namespace Opg9._5.Controllers
{
    public class SimpleCalculatorController : Controller
    {

        public IActionResult CalculatorView(IFormCollection formCollection)
        {
            if (formCollection.ContainsKey("FirstNumber") &&
                formCollection.ContainsKey("SecondNumber") &&
                formCollection.ContainsKey("Operator"))
            {
                if (int.TryParse(formCollection["FirstNumber"], out int firstNumber) &&
                    int.TryParse(formCollection["SecondNumber"], out int secondNumber))
                {
                    string operation = formCollection["Operator"];
                    double result = 0;

                    switch (operation)
                    {
                        case "+":
                            result = firstNumber + secondNumber;
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            break;
                        case "*":
                            result = firstNumber * secondNumber;
                            break;
                        case "/":
                            if (secondNumber != 0)
                            {
                                result = (double)firstNumber / secondNumber;
                            }
                            else
                            {
                                ViewBag.Error = "Division by zero is not allowed.";
                            }
                            break;
                        default:
                            ViewBag.Error = "Invalid operator.";
                            break;
                    }

                    ViewBag.FirstNumber = firstNumber.ToString();
                    ViewBag.SecondNumber = secondNumber.ToString();
                    ViewBag.Operator = operation;
                    ViewBag.Result = result.ToString();
                }
                else
                {
                    ViewBag.Error = "Invalid numbers entered.";
                }
            }

            return View();
        }

    }
}
