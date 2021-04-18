using BlazorCRUDEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEntityFramework.Data
{
    public class BookService : IBookService //La capa de acceso a datos. Metodos CRUD
    {
        private readonly MybooksContext _context;

        public BookService(MybooksContext context)
        {
            _context = context; //Generar la conexion con db para usar los servicios. Esto representa la Db
        }


        public async Task<bool> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id); //Busco el libro

            _context.Books.Remove(book); //Lo borro

            return await _context.SaveChangesAsync() > 0; //Esa funcion devuelve la cantidad de filas afectadas. Si es mayor que cero fue exitoso
        }

        public async Task<IEnumerable<Book>> GetAllBook()
        {
            return await _context.Books.ToListAsync(); //De la db, los libros, devolvemelos todos.
        }

        public async Task<Book> GetBookDetails(int id)
        {
            return await _context.Books.FindAsync(id); //Buscar un libro por un id
        }

        public async Task<bool> InsertBook(Book book)
        {
            _context.Books.Add(book);

            return await _context.SaveChangesAsync() > 0 ;
        }

        public async Task<bool> SaveBook(Book book)
        {
            if (book.BookId > 0) //Si es 0 es un nuevo libro, sino es uno a modificar
            {
                return await UpdateBook(book);
            }
            else
                return await InsertBook(book);
        }

        public async Task<bool> UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified; //Reemplaza el libro de la db por este nuevo que modifique

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
