using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        var useCase = new RegisterExpenseUseCase();

<<<<<<< HEAD
            return Created(string.Empty, response);
        } 
        catch (ArgumentException ex) 
        {
            var errorResponse = new ResponseErrorJson(ex.Message);

            return BadRequest(errorResponse);
        }
        catch 
        {
            var errorResponse = new ResponseErrorJson("Unknown error");
            
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
=======
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
>>>>>>> 3c4592dcec1325eb6bfb4dd71055d8d75383691d
    }
}