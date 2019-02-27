using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2702
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }

        public Person(string firstName, string lastName, int age, int iD)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ID = iD;
        }

        public static bool operator ==(Person me, Person other)
        {
            return (me.ID == other.ID);
        }

        public static bool operator !=(Person me, Person other)
        {
            return (me.ID != other.ID);
        }

        

        public override string ToString()
        {
            return $"Person {ID,5} {FirstName,10} {LastName,10} {Age, 3}";
        }

        public override bool Equals(object obj)
        {
            var person = obj as Person;
            if (ReferenceEquals(obj, null))
                return false;

            return this.ID == person.ID;
        }

        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
