using MeuTodo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeuTodo.Controllers
{
    [ApiController]
    [Route("v1")] //prefixo de rota
    public class TodoControllers : ControllerBase
    {
        [HttpGet]
        [Route("todos")]
        public List<Todo> Get()
        {
            return new List<Todo>();
        }

    }
}
