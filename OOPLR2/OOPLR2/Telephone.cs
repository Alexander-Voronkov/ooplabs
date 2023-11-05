using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR2
{
    internal sealed class Telephone : BaseDevice
    {
        public double ScreenDiagonal { get; set; }
        public Telephone(double screenDiagonal, double width, double height, double length, DateTime creationDate) 
            : base(width, height, length, creationDate)
        {
            ScreenDiagonal=screenDiagonal;
        }

        public Telephone(double screenDiagonal = 0) : base()
        {
            ScreenDiagonal = screenDiagonal;
        }
    }
}
