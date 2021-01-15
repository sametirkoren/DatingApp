using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DatingApp.API.Entities
{
    public class Group
    {
        public Group()
        {

        }

        public Group( string name)
        {
            Name = name;
        }
        [Key]

        public string Name { get; set; }

        public ICollection<Connection> Connections { get; set; } = new List<Connection>();
    }
}
