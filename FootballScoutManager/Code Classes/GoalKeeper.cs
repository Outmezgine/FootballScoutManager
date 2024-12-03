using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScoutManager.Code_Classes
{

    [Serializable]
    class GoalKeeper : Player
    {
        // Property
        public int Reflex { get; set; }
        public int OneOnOne { get; set; }
        public int FootGame { get; set; }
        public int Throwing { get; set; }


        // Constructor
        public GoalKeeper(int age, string name, int speed, int jump, int stamina, string salary, int reflex, int oneOnOne, int footGame, int throwing) : base(age, name, speed, jump, stamina, salary)
        {
            this.Reflex = reflex;
            this.OneOnOne = oneOnOne;
            this.FootGame = footGame;
            this.Throwing = throwing;


        }




        public override int isPlayerFitPhilosophy(int managerPh)
        {
            int flag = 1;

            if (managerPh == 1) // high press game 
            {
                if (OneOnOne < Manager.specificRoleStandart)
                {
                    flag = 0;
                }
            }

            else if (managerPh == 2) // poss game 
            {
                if (FootGame < Manager.specificRoleStandart)
                {
                    flag = 0;
                }
            }

            else if (managerPh == 3) // bonker game 
            {
                if (Reflex < Manager.specificRoleStandart)
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

            // Check the reflex
            if (Reflex > 5 && Reflex <= 10)
                score += 1;
            else if (Reflex > 10 && Reflex <= 15)
                score += 2;
            else if (Reflex > 15 && Reflex <= 20)
                score += 3;

            // Check the OneOnOne
            if (OneOnOne > 5 && OneOnOne <= 10)
                score += 1;
            else if (OneOnOne > 10 && OneOnOne <= 15)
                score += 2;
            else if (OneOnOne > 15 && OneOnOne <= 20)
                score += 3;


            // Check the footGame
            if (FootGame > 5 && FootGame <= 10)
                score += 1;
            else if (FootGame > 10 && FootGame <= 15)
                score += 2;
            else if (FootGame > 15 && FootGame <= 20)
                score += 3;

            // Check the Throwing
            if (Throwing > 5 && Throwing <= 10)
                score += 1;
            else if (Throwing > 10 && Throwing <= 15)
                score += 2;
            else if (Throwing > 15 && Throwing <= 20)
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
