﻿using Microsoft.AspNetCore.Mvc;

namespace TasksManagement.API.Controllers;

[Route("[controller]")]
[ApiController]
public class TasksManagementBaseController : ControllerBase
{
    public static List<Application.Entities.Task> Tasks = [];
}
