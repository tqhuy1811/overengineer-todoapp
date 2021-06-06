using System;

namespace CreateNoteService.Domain
{
	public class TodoItem
	{
		public TodoItem(Guid id, string todo, DateTimeOffset dueDate)
		{
			Id = id;
			Todo = todo;
			DueDate = dueDate;
		}

		public Guid Id { get; }
		public string Todo { get; }
		public DateTimeOffset DueDate { get; }
	}
}