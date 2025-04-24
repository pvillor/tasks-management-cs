using TasksManagement.Application.Utils;
using TasksManagement.Communication.Enums;
using TasksManagement.Communication.Requests;
using TasksManagement.Communication.Responses;
                                              
namespace TasksManagement.Application.UseCases.Tasks.Create;

public class CreateTaskUseCase(IList<Entities.Task> tasks)
{
    private readonly IList<Entities.Task> _tasks = tasks;

    public ResponseCreatedTaskJson Execute(RequestCreateTaskJson request)
    {
        var newTask = new Entities.Task
        {
            Id = IdGenerator.Generate(),
            Name = request.Name,
            Description = request.Description,
            Deadline = request.Deadline,
            Priority = request.Priority,
            Status = Status.Pending
        };

        _tasks.Add(newTask);

        var response = new ResponseCreatedTaskJson
        {
            TaskId = newTask.Id,
        };

        return response;
    }
}
