﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingClient.User
{
    public class User : IUser
    {
        private String possition;
        public string GetPossition()
        {
            return possition;
        }

        public void SetPossition(string poss)
        {
           this.possition = poss;
        }
    }
}
