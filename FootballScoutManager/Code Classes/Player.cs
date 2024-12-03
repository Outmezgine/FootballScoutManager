using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScoutManager.Code_Classes
{

    [Serializable]
    public abstract class Player : Person
    {
        // Property
        public int Speed { get; set; }
        public int Jump { get; set; }
        public int Stamina { get; set; }
        public string Salary { get; set; } // super high , high , balance , low , super low


        public int Id { get; set; }

        private static int currentId = 1;


        // Constructor
        public Player(int age, string name, int speed, int jump, int stamina, string salary)
        {
            this.Age = age;
            this.Name = name;
            this.Speed = speed;
            this.Jump = jump;
            this.Stamina = stamina;
            this.Salary = salary; //EstimatedSalary -  (1) super high ,(2) high ,(3) mid ,(4) low ,(5) soper low 
            this.Id = currentId;
            currentId++;
        }

        protected int CalculatePhysics()
        {
            int phyisicsStats = 0;

            //Speed
            if (Speed > 5 && Speed <= 10)
                phyisicsStats += 0;
            else if (Speed > 10 && Speed <= 15)
                phyisicsStats += 1;
            else if (Speed > 5 && Speed <= 20)
                phyisicsStats += 2;

            //Jump
            if (Jump > 5 && Jump <= 10)
                phyisicsStats += 0;
            else if (Jump > 10 && Jump <= 15)
                phyisicsStats += 1;
            else if (Jump > 5 && Jump <= 20)
                phyisicsStats += 2;

            //Stamina
            if (Stamina > 5 && Stamina <= 10)
                phyisicsStats += 0;
            else if (Stamina > 10 && Stamina <= 15)
                phyisicsStats += 1;
            else if (Stamina > 5 && Stamina <= 20)
                phyisicsStats += 2;

            //Age
            if (Age <= 19)
                phyisicsStats += 2;
            else if (Age > 19 && Age <= 26)
                phyisicsStats += 1;
            else if (Age > 26 && Age <= 30)
                phyisicsStats += 0;
            else if (Age > 30)
                phyisicsStats -= 2;

            //EstimatedSalary
            if (Salary == "Super High")        //(1) super high
                phyisicsStats -= 2;
            else if (Salary == "High")   //(2) high
                phyisicsStats -= 1;
            else if (Salary == "Basic")   //(3) mid
                phyisicsStats -= 0;
            else if (Salary == "Low")   //(4) low
                phyisicsStats += 1;
            else if (Salary == "Super Low")   //(5) super low
                phyisicsStats += 2;


            return phyisicsStats;
        }

        public abstract int Scout();

        public abstract int isPlayerFitPhilosophy(int managerPh);

        public abstract bool FinalCheck(int scout, int fit);
    }
}
