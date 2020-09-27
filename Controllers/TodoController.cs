using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace todo_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private static readonly List<todo_api.Models.TodoItem> TodoList = new List<todo_api.Models.TodoItem>();
        private readonly ILogger<TodoController> _logger;

        public TodoController(ILogger<TodoController> logger)
        {
            _logger = logger;
        }

        private static JsonSerializerOptions _options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        [HttpGet]
        public List<todo_api.Models.TodoItem> Get()
        {
            _logger.LogInformation(TodoList.Count.ToString());
            return TodoList;
        }

        [HttpPost]
        public todo_api.Models.TodoItem Post([FromBody] todo_api.Models.TodoItem TodoItem)
        {
            TodoList.Add(TodoItem);
            return TodoItem;
        }
    }
}
