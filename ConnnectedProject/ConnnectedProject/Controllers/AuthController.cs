using System;
using System.Collections.Generic;
using System.Text;
using ConnnectedProject.Models;

namespace ConnnectedProject.Controllers
{
    internal class AuthController
    {
        public User Authentication(string email, string mdp)
        {
            for (int i = 0;i < DataStore.Users.Count; i++ )
            {
                if (email == DataStore.Users[i].Email && mdp == DataStore.Users[i].MotDePasse)
                    return DataStore.Users[i];
            }
            return null;
        }
    }
}
