using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Books_MVC5.DAL
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookContext")
        {
        }
    
    }
}