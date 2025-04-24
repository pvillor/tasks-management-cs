namespace TasksManagement.Application.Utils;

public class IdGenerator
{
    private static int _id = 0;

    public static int Generate()
    {
        _id++;

        return _id;
    }
}
