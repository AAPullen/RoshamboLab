using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab.Players
{
    class RandomPLayer : Player
    {
        public RandomPLayer()
        {
            _name = "Mysterio";
            _value = _generateRoshambo();
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
                _value = value;
            }
        }

        private Roshambo _generateRoshambo()
        {
            Random random = new Random();
            int choice = random.Next(0, 3);
            _value = (Roshambo)choice;

            return (Roshambo)choice;
        }
        public override Roshambo GenerateRoshambo()
        {
            return _generateRoshambo();
        }
    }
}
