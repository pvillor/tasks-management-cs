using Microsoft.AspNetCore.Mvc;
using TasksManagement.Application.UseCases.Tasks.Create;
using TasksManagement.Communication.Requests;
using TasksManagement.Communication.Responses;

namespace TasksManagement.API.Controllers;

public class TasksController : TasksManagementBaseController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedTaskJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestCreateTaskJson request)
    {
        var useCase = new CreateTaskUseCase(Tasks);

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }
}
