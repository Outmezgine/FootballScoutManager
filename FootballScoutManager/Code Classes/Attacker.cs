using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScoutManager.Code_Classes
{

    [Serializable]
    class Attacker : Player
    {
        // Property
        public int Finish { get; set; }
        public int Shoot { get; set; }
        public int Pass { get; set; }
        public int Heading { get; set; }

        // Constructor
        public Attacker(int age, string name, int speed, int jump, int stamina, string salary, int finish, int shoot, int pass, int heading) : base(age, name, speed, jump, stamina, salary)
        {
            this.Finish = finish;
            this.Shoot = shoot;
            this.Pass = pass;
            this.Heading = heading;
        }

        public override int isPlayerFitPhilosophy(int managerPh)
        {
            int flag = 1;

            if (managerPh == 1) // high press game 
            {
                if (Finish < Manager.specificRoleStandart)
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
                if (Shoot < Manager.specificRoleStandart)
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

            // Check the Finish
            if (Finish > 5 && Finish <= 10)
                score += 1;
            else if (Finish > 10 && Finish <= 15)
                score += 2;
            else if (Finish > 15 && Finish <= 20)
                score += 3;

            // Check the Shoot
            if (Shoot > 5 && Shoot <= 10)
                score += 1;
            else if (Shoot > 10 && Shoot <= 15)
                score += 2;
            else if (Shoot > 15 && Shoot <= 20)
                score += 3;


            // Check the Pass
            if (Pass > 5 && Pass <= 10)
                score += 1;
            else if (Pass > 10 && Pass <= 15)
                score += 2;
            else if (Pass > 15 && Pass <= 20)
                score += 3;

            // Check the Heading
            if (Heading > 5 && Heading <= 10)
                score += 1;
            else if (Heading > 10 && Heading <= 15)
                score += 2;
            else if (Heading > 15 && Heading <= 20)
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
