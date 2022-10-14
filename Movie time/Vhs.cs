using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_time
{
    public  class Vhs :Movie2
    {
        public Vhs(string Name, string Catagory, int runTime, List<string> Scenes) : base(Name, Catagory, runTime, Scenes)
        {

        }
    }
}
