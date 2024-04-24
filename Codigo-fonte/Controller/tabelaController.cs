    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private static List<TodoItem> _todos = new List<TodoItem>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_todos);
        }

        [HttpPost]
        public IActionResult Post(TodoItem item)
        {
            _todos.Add(item);
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }
    }
