using System;
using System.Collections.Generic;
using System.Text;

namespace FootballScoutManager.Code_Classes
{
    [Serializable]
    public abstract class Person
    {

        // Property
        public int Age { get; set; }
        public string Name { get; set; }

        // Default Constructor
        public Person()
        {

        }

        // Constructor
        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

    }
}
