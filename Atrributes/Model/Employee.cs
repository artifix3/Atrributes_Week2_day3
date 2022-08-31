using Atrributes.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrributes.Model
{
    public class Entity
    {
        [ColumnName("HomeAdress")]
        public string Adress { get; set; }
    }

    public class Employee : Entity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ColumnName]
        public string Email { get; set; }
        [ColumnName("WorkPhone")]
        public string Phone { get; set; }



    }
}
