using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetAll();
        Book GetBook(int id);
        void Create(Book book);
        void Update(Book book);
        void Delete(int id);
        void Save();
    }
}
