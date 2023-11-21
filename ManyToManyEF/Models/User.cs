using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyEF.Models
{
    public class User
   {
        public int Id { get; set; }
        public string     Name { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }


        public ICollection<Book> Books { get; set; }    

    }
}
