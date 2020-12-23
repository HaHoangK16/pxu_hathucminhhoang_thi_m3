using Books.BAL.Interface;
using Books.DAL.Interface;
using Books.Domain;
using Books.Domain.Request.AllBook;
using Books.Domain.Response.AllBook;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.BAL
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task<CreateBookResult> CreateBook(CreateBookRequest request)
        {
            return await bookRepository.CreateBook(request);
        }

        public async Task<DeleteBookResult> DeleteBook(DeleteBookRequest request)
        {
            return await bookRepository.DeleteBook(request);
        }

        public async Task<IEnumerable<AllBook>> Gets()
        {
            return await bookRepository.Gets();
        }

        public async Task<UpdateBookResult> UpdateBook(UpdateBookRequest request)
        {
            return await bookRepository.UpdateBook(request);
        }
    }
}
