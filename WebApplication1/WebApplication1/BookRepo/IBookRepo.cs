using WebApplication1.Models;

namespace WebApplication1.BookRepo
{
    public interface IBookRepo
    {
        public Task<Book> getbyId(int id);

        public Task<List<Book>> GetAll();

        public  Task Add(BookDto bookDto);

        public  Task Edit(BookDto bookDto, int id);
        public  Task Delete(int id);
    }
}
