using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingClient.User
{
    interface IUser
    {

        String GetPossition();
        void SetPossition(String poss);
    }
}
