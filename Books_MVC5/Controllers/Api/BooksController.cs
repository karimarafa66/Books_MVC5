using Books_MVC5.DAL;
using System.Web.Http;

namespace Books.Controllers.Api
{
    public class BooksController : ApiController
    {
        private readonly BookContext _context;

        public BooksController()
        {
            _context = new BookContext();
        }

        [HttpDelete]
        public IHttpActionResult DeleteBook(int id)
        {
            var book = _context.Books.Find(id);

            if (book == null)
                return NotFound();

            _context.Books.Remove(book);
            _context.SaveChanges();

            return Ok();
        }
    }
}
