using CreateNoteService.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CreateNoteService.Domain
{
	public class TodoList
	{
		public List<TodoItem> TodoItems { get; private set; } = new List<TodoItem>();

		public List<IEvent> Events { get; private set; } = new List<IEvent>();

		public TodoList()
		{
		}

		public TodoList(List<IEvent> events)
		{
			Events = events;
			foreach (var e in Events)
			{
				Apply((dynamic)e);
			}
		}

		public ToDoItemCreated AddTodoItem(string todo, DateTimeOffset dueDate)
		{
			var @event = new ToDoItemCreated(todo, dueDate);
			Apply(@event);
			return @event;
		}

		public ToDoItemUpdated UpdateToDoItem(Guid id, string toDo, DateTimeOffset dueDate)
		{
			var @event = new ToDoItemUpdated(id, toDo, dueDate);

			Apply(@event);

			return @event;
		}

		private void Apply(ToDoItemUpdated @event)
		{
			var todoItem = TodoItems.SingleOrDefault(i => i.Id == @event.Id);
			todoItem = new TodoItem(id: todoItem.Id, todo: @event.Todo, dueDate: @event.DueDate);
			Events.Add(@event);
		}

		private void Apply(ToDoItemCreated @event)
		{
			TodoItems.Add(new TodoItem(
				  id: Guid.NewGuid(),
				  todo: @event.Todo,
				  dueDate: @event.DueDate
				));
			Events.Add(@event);
		}
	}
}