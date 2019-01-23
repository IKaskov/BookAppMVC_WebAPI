﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
           : base("name=BookContext")
        { }

        public DbSet<Book> Books { get; set; }
    }
}