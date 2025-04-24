using Microsoft.AspNetCore.Mvc;
using TasksManagement.Application.UseCases.Tasks.Create;
using TasksManagement.Application.UseCases.Tasks.Delete;
using TasksManagement.Application.UseCases.Tasks.FetchAll;
using TasksManagement.Application.UseCases.Tasks.GetById;
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

    [HttpGet]
    [ProducesResponseType(typeof(ResponseTasksJson), StatusCodes.Status200OK)]
    public IActionResult FetchAll()
    {
        var useCase = new FetchAllTasksUseCase(Tasks);

        var response = useCase.Execute();

        return Ok(response);
    }

    [HttpGet]
    [Route("{taskId}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int taskId)
    {
        var useCase = new GetTaskByIdUseCase(Tasks);

        var response = useCase.Execute(taskId);

        if (response is null)
        {
            return NotFound();
        }

        return Ok(response);
    }

    [HttpDelete]
    [Route("{taskId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int taskId)
    {
        var useCase = new DeleteTaskUseCase(Tasks);

        useCase.Execute(taskId);

        return NoContent();
    }
}
