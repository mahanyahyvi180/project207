using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp76
{
    class cEmployee
    {
        public event delbig toobig;

        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }

        public string Concatinate()
        {
            if ((FirstName + LastName).Length > 10)
                toobig.Invoke();

            return FirstName + ' ' + LastName;
        }
    
    }
}
