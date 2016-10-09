using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.generatedcode
{
    class Truck : Item
    {
        
        public Truck()
        {
            base.name = "@";
        }
        public virtual void MoveDown()
        {
            Console.WriteLine("Moved Down");
        }

        public virtual void MoveUp()
        {
            Console.WriteLine("Moved up");
        }

        public virtual void Moveleft()
        {
            Console.WriteLine("Moved left");
        }

        public virtual void MoveRight()
        {
            this.yPos = this.yPos +1;

            Console.WriteLine("Moved right");
        }
    }
}
