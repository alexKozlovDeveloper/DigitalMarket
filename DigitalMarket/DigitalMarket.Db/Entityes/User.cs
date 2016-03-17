using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMarket.Db.Entityes
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime DayOfBirth { get; set; }      
        public string Email { get; set; }
    }
}
