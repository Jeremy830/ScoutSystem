using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ScoutSystem
{
   public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set;}

        public string Age { get; set;}

        public string Position { get; set;}

        public string Ability { get; set;}
    }
}
