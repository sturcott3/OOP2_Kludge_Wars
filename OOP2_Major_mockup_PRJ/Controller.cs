using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class Controller
    {
        //Made it a protected property so that derived classes have access to it.
        protected bool StatusOk { get; set; } = true;

        public bool GetStatusOk()
        {
            return StatusOk;
        }

    }
}
