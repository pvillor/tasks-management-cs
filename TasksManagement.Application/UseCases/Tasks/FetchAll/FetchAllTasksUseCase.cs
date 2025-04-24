using TasksManagement.Communication.Responses;

namespace TasksManagement.Application.UseCases.Tasks.FetchAll;

public class FetchAllTasksUseCase(IList<Entities.Task> tasks)
{
    private readonly IList<Entities.Task> _tasks = tasks;

    public ResponseTasksJson Execute()
    {
        return new ResponseTasksJson
        {
            Tasks = _tasks.Select(task => new ResponseTaskJson
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                Deadline = task.Deadline,
                Priority = task.Priority,
                Status = task.Status
            }).ToList(),
        };
    }
}
