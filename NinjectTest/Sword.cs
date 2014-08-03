using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    public class Sword : IWeapon
    {
        public void Hit(string enemy)
        {
            Console.WriteLine("Chopped {0} clean in half!", enemy);
        }
    }
}
