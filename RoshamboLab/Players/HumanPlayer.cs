using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab.Players
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name)
        {
            _name = name;
        }

        private string _name;
        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private Roshambo _value;
        public override Roshambo Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = GenerateRoshambo();
            }
        }

        public override Roshambo GenerateRoshambo()
        {
            string playerShoot;
            bool isValidShoot = false;
            do
            {
                Console.Write("Rock, Paper, or Scissors (r/p/s)? ");

                playerShoot = Console.ReadLine().ToLower();
                isValidShoot = Validation.ComfirmShoot(playerShoot);

                if (isValidShoot == false)
                {
                    Console.WriteLine("\nI'm sorry, that is not a valid input, Please select again.");
                }
            } while (isValidShoot == false);

            if (playerShoot == "r")
            {
                _value = Roshambo.Rock;
                return Roshambo.Rock;
            }
            else if (playerShoot == "p")
            {
                _value = Roshambo.Paper;
                return Roshambo.Paper;
            }
            else
            {
                _value = Roshambo.Scissors;
                return Roshambo.Scissors;
            }
        }
    }
}
