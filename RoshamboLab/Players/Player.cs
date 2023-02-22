using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab.Players
{
    abstract class Player
    {
        public abstract string Name { get; set; }
        public abstract Roshambo Value { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
