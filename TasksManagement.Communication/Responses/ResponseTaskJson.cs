using TasksManagement.Communication.Enums;

namespace TasksManagement.Communication.Responses;

public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateOnly Deadline { get; set; }
    public Status Status { get; set; }
}
