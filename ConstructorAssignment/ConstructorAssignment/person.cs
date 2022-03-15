using System;
using System.Collections.Generic;
using System.Text;

namespace ConstVarChainConstructors
{
    class Person
    {
        public string FirstName;
        public string LastName;

        //Chaining two constructors together
        public Person(string firstName) : this(firstName, "")
        {

        }
        public Person(string firstName, string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
    }
}
