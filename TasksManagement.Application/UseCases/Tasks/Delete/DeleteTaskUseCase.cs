using TasksManagement.Communication.Responses;

namespace TasksManagement.Application.UseCases.Tasks.Delete;

public class DeleteTaskUseCase(IList<Entities.Task> tasks)
{
    private readonly IList<Entities.Task> _tasks = tasks;

    public void Execute(int taskId)
    {
        var task = _tasks.FirstOrDefault(task => task.Id == taskId);

        if (task is null)
        {
            throw new InvalidOperationException("Task not found");
        }

        _tasks.Remove(task);
    }
}
