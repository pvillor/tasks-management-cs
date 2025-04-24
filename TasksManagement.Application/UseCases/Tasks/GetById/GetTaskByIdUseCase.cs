using TasksManagement.Communication.Responses;

namespace TasksManagement.Application.UseCases.Tasks.GetById;

public class GetTaskByIdUseCase(IList<Entities.Task> tasks)
{
    private readonly IList<Entities.Task> _tasks = tasks;

    public ResponseTaskJson? Execute(int taskId)
    {
        var task = _tasks.FirstOrDefault(task => task.Id == taskId);

        if(task is null)
        {
            return null;
        }

        return new ResponseTaskJson
        {
            Id = task.Id,
            Name = task.Name,
            Description = task.Description,
            Deadline = task.Deadline,
            Priority = task.Priority,
            Status = task.Status
        };
    }
}
