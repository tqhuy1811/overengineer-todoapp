using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateNoteService.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class TodoController : ControllerBase
	{
		[Route("create")]
		public IActionResult CreateTodoItem()
		{
			return null;
		}
	}
}