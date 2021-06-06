using CreateNoteService.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CreateNoteService.Features
{
	public class CreateTodoItemCommand : IRequest
	{
		public string Todo { get; set; }
		public DateTimeOffset Duedate { get; set; }
	}

	public class CreateTodoItemHandler : AsyncRequestHandler<CreateTodoItemCommand>
	{
		protected override Task Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
		{
			var todoList = new TodoList();
			var @event = todoList.AddTodoItem(request.Todo, request.Duedate);
		}
	}
}