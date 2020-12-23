using Books.Domain;
using Books.Domain.Request.AllBook;
using Books.Domain.Response.AllBook;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.DAL.Interface
{
    public interface IBookRepository
    {
        Task<IEnumerable<AllBook>> Gets();
        Task<CreateBookResult> CreateBook(CreateBookRequest request);
        Task<UpdateBookResult> UpdateBook(UpdateBookRequest request);
        Task<DeleteBookResult> DeleteBook(DeleteBookRequest request);
    }
}
