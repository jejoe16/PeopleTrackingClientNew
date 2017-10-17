using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingClient.Check
{
    interface ICheck
    {
        Boolean CheckIn(User.User user, String poss);
        Boolean CheckOut(User.User user, String poss);
    }
}
