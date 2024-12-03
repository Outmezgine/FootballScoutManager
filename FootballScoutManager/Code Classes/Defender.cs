using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScoutManager.Code_Classes
{

    [Serializable]
    class Defender : Player
    {
        // Property
        public int Power { get; set; }
        public int Tackles { get; set; }
        public int Saving { get; set; }
        public int Brave { get; set; }

        // Constructor
        public Defender(int age, string name, int speed, int jump, int stamina, string salary, int power, int tackles, int saving, int brave) : base(age, name, speed, jump, stamina, salary)
        {
            this.Power = power;
            this.Tackles = tackles;
            this.Saving = saving;
            this.Brave = brave;
        }


        public override int isPlayerFitPhilosophy(int managerPh)
        {
            int flag = 1;

            if (managerPh == 1) // high press game 
            {
                if (Tackles < Manager.specificRoleStandart)
                {
                    flag = 0;
                }
            }

            else if (managerPh == 2) // poss game 
            {
                if (Brave < Manager.specificRoleStandart)
                {
                    flag = 0;
                }
            }

            else if (managerPh == 3) // bonker game 
            {
                if (Saving < Manager.specificRoleStandart)
                {
                    flag = 0;
                }
            }

            return flag;
        }

        public override int Scout()
        {
            int score = 0;

            // *************************************** Check the physics
            int physics = CalculatePhysics();

            // *************************************** Check the Technical

            // Check the Power
            if (Power > 5 && Power <= 10)
                score += 1;
            else if (Power > 10 && Power <= 15)
                score += 2;
            else if (Power > 15 && Power <= 20)
                score += 3;

            // Check the Tackles
            if (Tackles > 5 && Tackles <= 10)
                score += 1;
            else if (Tackles > 10 && Tackles <= 15)
                score += 2;
            else if (Tackles > 15 && Tackles <= 20)
                score += 3;


            // Check the Saving
            if (Saving > 5 && Saving <= 10)
                score += 1;
            else if (Saving > 10 && Saving <= 15)
                score += 2;
            else if (Saving > 15 && Saving <= 20)
                score += 3;

            // Check the Brave
            if (Brave > 5 && Brave <= 10)
                score += 1;
            else if (Brave > 10 && Brave <= 15)
                score += 2;
            else if (Brave > 15 && Brave <= 20)
                score += 3;

            score += physics;

            if (score >= 20) { return 20; }
            else
            {
                return score;
            }
        }


        public override bool FinalCheck(int scout, int fit)
        {
            // *************************************** final check:
            if (scout >= Manager.overallRating && fit == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
