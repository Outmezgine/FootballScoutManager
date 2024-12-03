using System;
using System.Collections.Generic;
using System.Text;

namespace FootballScoutManager.Code_Classes
{
    [Serializable]
    public class Manager : Person
    {
        // Property
        public int PurchasingPurpose { get; set; }
        public int FootballPhilosophy { get; set; }

        public static int overallRating = 0;
        public static int specificRoleStandart = 0;
        public static int managerPhilosophy = 0;

        // Default Constructor  
        public Manager()
        {

        }

        // Constructor
        public Manager(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }


    }
}
