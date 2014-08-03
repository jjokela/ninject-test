using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    public class Shuriken : IWeapon
    {
        public void Hit(string enemy)
        {
            Console.WriteLine("Pierced {0} armor!", enemy);
        }
    }
}
