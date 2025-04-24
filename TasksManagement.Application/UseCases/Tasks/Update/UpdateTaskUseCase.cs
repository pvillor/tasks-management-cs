using TasksManagement.Application.Utils;
using TasksManagement.Communication.Enums;
using TasksManagement.Communication.Requests;

namespace TasksManagement.Application.UseCases.Tasks.Update;

public class UpdateTaskUseCase(IList<Entities.Task> tasks)
{
    private readonly IList<Entities.Task> _tasks = tasks;

    public void Execute(int taskId, RequestUpdateTaskJson request)
    {
        var task = _tasks.FirstOrDefault(task => task.Id == taskId);

        if (task is null)
        {
            throw new InvalidOperationException("Task not found");
        }

        task.Name = request.Name;
        task.Description = request.Description;
        task.Deadline = request.Deadline;
        task.Priority = request.Priority;
        task.Status = request.Status;
    }
}
