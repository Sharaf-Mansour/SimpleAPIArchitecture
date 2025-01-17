﻿using Library.Models;

namespace Library.Foundation.Services;
public interface IBookService
{
    ValueTask AddBookAsync(Book book);
    ValueTask<List<Book>> RetrieveAllBooksAsync();
    ValueTask<Book?> RetrieveBookByIdAsync(int book_id);
    ValueTask ModifyBookAsync(Book book);
    ValueTask RemoveBookByIdAsync(int book_id);
}