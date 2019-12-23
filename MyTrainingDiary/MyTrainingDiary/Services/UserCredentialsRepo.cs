using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyTrainingDiary.DAL.Interfaces;
using MyTrainingDiary.DAL.Models;
using MyTrainingDiary.Exceptions;

namespace MyTrainingDiary.Services
{
    public class UserCredentialsRepo : IUserCredentialsRepo
    {
        public IUserCredentials GetUserCredentialsByUsername(string username)
        {
            using (var dc = App.GetAppDbContext())
            {
                var userCredentials = dc.UserCredentials.FirstOrDefault(uc => uc.Username == username);

                if (userCredentials != null)
                {
                    return new UserCredentialsModel(userCredentials);
                }
            }

            throw new NoUserException("Uzivatel nenalezen.");
        }
    }
}