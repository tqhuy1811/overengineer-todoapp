using System;

namespace CreateNoteService.Domain.Events
{
	public class ToDoItemUpdated : IEvent
	{
		public Guid Id { get; }

		public ToDoItemUpdated(Guid id, string todo, DateTimeOffset dueDate)
		{
			Id = id;
			Todo = todo;
			DueDate = dueDate;
		}

		public string Todo { get; }
		public DateTimeOffset DueDate { get; }
	}
}