using TasksManagement.Communication.Enums;

namespace TasksManagement.Communication.Requests;

public class RequestCreateTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateOnly Deadline { get; set; }
}
