using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
   public static class IDgenerator
    {
        public static int Sid { get; set; } = 0;
    } 
    public class User
    {
        public User( string? name, string? surname)
        {
            Name = name;
            Surname = surname;
        }

        public int ID { get; set; } = IDgenerator.Sid++;
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
