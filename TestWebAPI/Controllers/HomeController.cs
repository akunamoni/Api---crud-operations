using Microsoft.AspNetCore.Mvc;

namespace TestWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Hello";
        }
        [HttpGet("BookInfo")]
        public Book BookInfo()
        {
            Book objbook = new Book() { Bookid = 110, Bookname = "Dream of Life", Bookprice = 199.5f };


;
            return objbook;
        }
        [HttpGet("AllBooks")]
        public List<Book> AllBooks()
        {
            List<Book> lstbks = new List<Book>()
            {
                new Book{Bookid = 110, Bookname = "Dream of Life", Bookprice = 199.5f},
                new Book{Bookid = 111, Bookname = "Dreams comes true", Bookprice = 300.6f},
                new Book{Bookid = 112, Bookname = "plamistry for all", Bookprice = 250.5f}
            };
            
            return lstbks;
        }
        [HttpGet("BookInfoById")]
        public ActionResult<string> BookInfoById(string bid)
        {
                //Connect to database and fetch the book based on id
                if (string.IsNullOrEmpty(bid))
                {
                    return "Bad Request";

                }
                else if (bid == "0")  //Doesnot exists in Db
                {
                    return "Doesn't Exists";
                }
                else
                {
                    Book objbook = new Book() { Bookid = 110, Bookname = "Dream of Life", Bookprice = 199.5f };
                    return Ok(objbook);
                }
          
        }

    }
    public class Book
    {
        public int Bookid { get; set; }
        public string Bookname { get; set; }
        public float Bookprice { get; set; }

    }
    
}
