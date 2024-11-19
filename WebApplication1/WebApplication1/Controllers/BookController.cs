
using Microsoft.AspNetCore.Mvc;
using WebApplication1.BookRepo;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class BookController:ControllerBase
    {
        IBookRepo bookRepo;

        public BookController(IBookRepo _bookRepo)
        {
            bookRepo = _bookRepo;
        }
        [HttpGet("Getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book= await bookRepo.getbyId(id);
            return Ok(book);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Getall()
        {
            var books=await bookRepo.GetAll();
            return Ok(books);
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(BookDto bookDto)
        {
            await bookRepo.Add(bookDto);
            return Ok();
        }
        [HttpPut("Edit/{id}")]

        public async Task<IActionResult> Edit(BookDto bookDto,int id)
        {
            await bookRepo.Edit(bookDto, id);
            return Ok();
        }

        [HttpDelete("Delete/{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            await bookRepo.Delete(id);
            return Ok();
        }
    }
}
