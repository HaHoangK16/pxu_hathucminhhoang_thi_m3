using Books.DAL.Interface;
using Books.Domain;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Books.Domain.Response.AllBook;
using Books.Domain.Request.AllBook;

namespace Books.DAL
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public async Task<CreateBookResult> CreateBook(CreateBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookName", request.BookName);
                parameters.Add("@Author", request.Author);
                parameters.Add("@Description", request.Description);
                parameters.Add("@Year", request.Year);
                parameters.Add("@Amount", request.Amount);
                parameters.Add("@CategoryName", request.CategoryName);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateBookResult>(cnn: connect,
                                                    sql: "sp_CreateBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeleteBookResult> DeleteBook(DeleteBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookId", request.BookId);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteBookResult>(cnn: connect,
                                                    sql: "sp_DeleteBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<AllBook>> Gets()
        {
            return await SqlMapper.QueryAsync<AllBook>(cnn: connect,
                                                 sql: "sp_GetBook",
                                                 commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateBookResult> UpdateBook(UpdateBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookName", request.BookName);
                parameters.Add("@BookId", request.BookId);
                parameters.Add("@Author", request.Author);
                parameters.Add("@Description", request.Description);
                parameters.Add("@Year", request.Year);
                parameters.Add("@Amount", request.Amount);
                parameters.Add("@CategoryName", request.CategoryName);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateBookResult>(cnn: connect,
                                                    sql: "sp_UpdateBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
