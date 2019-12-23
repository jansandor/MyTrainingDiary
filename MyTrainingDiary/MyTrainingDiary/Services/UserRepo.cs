using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyTrainingDiary.DAL.Interfaces;
using MyTrainingDiary.Exceptions;

namespace MyTrainingDiary.Services
{
    public class UserRepo : IUserRepo
    {
        public Guid GetUserIdByUserCredentials(IUserCredentials userCredentials)
        {
            using (var dc = App.GetAppDbContext())
            {
                var user = dc.Users.FirstOrDefault(u => u.UserCredentials.Id == userCredentials.Id);

                if (user != null)
                {
                    return user.Id;
                }
            }

            throw new NoUserException("Uzivatel nenalezen.");
        }
    }
}
