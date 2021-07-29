using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket2
{
   public class Anket
    {
        public int Id { get; set; }
        public static int static_id = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BirthDay { get; set; }

        public Anket()
        {
            Id = ++static_id;
        }

        public override string ToString()
        {
            return $"Id : {Id} \nName : {Name} \nSurname : {Surname} \nEmail : {Email} \nPhone : {Phone} \nBirthDay : {BirthDay}";
        }
    }
}
