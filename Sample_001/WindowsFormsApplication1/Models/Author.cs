using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime Year { get; set; }


        public virtual ICollection<Book> Books { get; set; }
        public Author()
        {
            Books = new List<Book>();
        }
    }
}
