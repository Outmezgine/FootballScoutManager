using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScoutManager.Code_Classes
{
    [Serializable]
    class MidFielder : Player
    {
        // Property
        public int Pass { get; set; }
        public int Power { get; set; }
        public int LongShoot { get; set; }
        public int LongPass { get; set; }

      

        // Constructor
        public MidFielder(int age, string name, int speed, int jump, int stamina, string salary, int pass, int power, int longShoot, int longPass) : base(age, name, speed, jump, stamina, salary)
        {
            this.Pass = pass;
            this.Power = power;
            this.LongShoot = longShoot;
            this.LongPass = longPass;
        }


        public override int isPlayerFitPhilosophy(int managerPh)
        {
            int flag = 1;

            if (managerPh == 1) // high press game 
            {
                if (Power < Manager.specificRoleStandart)
                {
                    flag = 0;
                }
            }

            else if (managerPh == 2) // poss game 
            {
                if (Pass < Manager.specificRoleStandart)
                {
                    flag = 0;
                }
            }

            else if (managerPh == 3) // bonker game 
            {
                if (LongPass < Manager.specificRoleStandart)
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

            // Check the Pass
            if (Pass > 5 && Pass <= 10)
                score += 1;
            else if (Pass > 10 && Pass <= 15)
                score += 2;
            else if (Pass > 15 && Pass <= 20)
                score += 3;

            // Check the Power
            if (Power > 5 && Power <= 10)
                score += 1;
            else if (Power > 10 && Power <= 15)
                score += 2;
            else if (Power > 15 && Power <= 20)
                score += 3;


            // Check the LongShoot
            if (LongShoot > 5 && LongShoot <= 10)
                score += 1;
            else if (LongShoot > 10 && LongShoot <= 15)
                score += 2;
            else if (LongShoot > 15 && LongShoot <= 20)
                score += 3;

            // Check the LongPass
            if (LongPass > 5 && LongPass <= 10)
                score += 1;
            else if (LongPass > 10 && LongPass <= 15)
                score += 2;
            else if (LongPass > 15 && LongPass <= 20)
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
