using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom11Teacher.Controllers
{
    internal abstract class Bird : Animal
    {
        public override void Sound()
        {
            throw new NotImplementedException();
            Console.WriteLine("Bird Sound");
        }

    }
}
