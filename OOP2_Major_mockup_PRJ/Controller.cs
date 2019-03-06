using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class Controller
    {

        private bool statusOk = true;

        public bool GetStatusOk()
        {
            return statusOk;
        }

        //No need for a setter, since it will never be set outside it's class.
        //Sam agrees. could be used to actually do stuff, but we don't need it to yet.

    }
}
