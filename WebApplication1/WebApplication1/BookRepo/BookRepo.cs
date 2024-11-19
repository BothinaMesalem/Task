using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.BookRepo
{
    public class BookRepo:IBookRepo
    {
        BookContext context;
        public BookRepo(BookContext _context)
        {
            context = _context;
        }

        public async Task<Book> getbyId(int id)
        {
            var books=await context.bookContext.FindAsync(id);
            return books;
        }
        public async Task<List<Book>> GetAll()
        {
            var books = await context.bookContext.ToListAsync();
            return books;
        }
        public async Task Add(BookDto bookDto)
        {
            var book = new Book
            {
                Title = bookDto.Title,
                Author = bookDto.Author,
                Genre = bookDto.Genre,
                PublishedYear = bookDto.PublishedYear,
            };
            await context.bookContext.AddAsync(book);
            await context.SaveChangesAsync();
        }
        public async Task Edit(BookDto bookDto ,int id)
        {
            var book = await context.bookContext.FirstOrDefaultAsync(a=>a.Id==id);
            if (book != null)
            {
                book.Title=bookDto.Title;
                book.Author=bookDto.Author;
                book.Genre=bookDto.Genre;
                book.PublishedYear = bookDto.PublishedYear;
            }
            context.bookContext.Update(book);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var book = await context.bookContext.FirstOrDefaultAsync(a => a.Id == id);
            if(book != null)
            {
                 context.bookContext.Remove(book);
                 await context.SaveChangesAsync();
            }
        }

        
    }
}
