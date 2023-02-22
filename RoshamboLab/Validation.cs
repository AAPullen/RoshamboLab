using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public class Validation
    {
        public static bool ConfirmOpponent(string playerChoice)
        {
            if (playerChoice == "m" || playerChoice == "b")
            {
                return true;
            }
            return false;
        }

        public static bool ComfirmShoot(string playerShoot)
        {
            if (playerShoot == "r" || playerShoot == "p" || playerShoot == "s")
            {
                return true;
            }
            return false;
        }

        public static bool ConfirmYN(string playerRepeat)
        {
            if (playerRepeat == "y" || playerRepeat == "n")
            {
                return true;
            }
            return false;
        }
    }
}
