using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab.Players
{
    class RockPlayer : Player
    {
        public RockPlayer()
        {
            _name = "Brock";
            _value = Roshambo.Rock;
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
            return _value;
        }
        public override Roshambo GenerateRoshambo()
        {
            return _generateRoshambo();
        }
    }
}
