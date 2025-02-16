using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biodata_Maker.Models
{
    public class Name
    {
        public string FirstName {  get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Name(string firstName)
        {
            FirstName = firstName;
        }

        public Name(string firstName, string lastName) : this(firstName)
        {
            LastName = lastName;
        }

        public Name(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {
            MiddleName = middleName;
        }
    }
}