using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        [Key]
        public int  UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string Password { get; set; }

        public string UserRole { get; set; }



    }
}
