using System;

namespace CreateNoteService.Domain.Events
{
	public class DeleteTodoItemEvent : IEvent
	{
		public DeleteTodoItemEvent(Guid id)
		{
			Id = id;
		}

		public Guid Id { get; }
	}
}