using System;

namespace CreateNoteService.Domain.Events
{
	public class ToDoItemCreated : IEvent
	{
		public string Todo { get; }

		public ToDoItemCreated(string todo, DateTimeOffset dueDate)
		{
			Todo = todo;
			DueDate = dueDate;
		}

		public DateTimeOffset DueDate { get; }
	}
}