﻿namespace Entities.Exceptions
{
    public sealed class BookNotFoundException : NotFoundException
    {
        public BookNotFoundException(int id) : base($"The book with id: {id} cloud not found.")
        {
        }
    }
}
