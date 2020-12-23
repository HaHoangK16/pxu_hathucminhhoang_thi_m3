using Books.Domain;
using Books.Domain.Request.AllBook;
using Books.Domain.Response.AllBook;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.BAL.Interface
{
    public interface IBookService
    {
        Task<IEnumerable<AllBook>> Gets();
        Task<CreateBookResult> CreateBook(CreateBookRequest request);
        Task<UpdateBookResult> UpdateBook(UpdateBookRequest request);
        Task<DeleteBookResult> DeleteBook(DeleteBookRequest request);
    }
}
