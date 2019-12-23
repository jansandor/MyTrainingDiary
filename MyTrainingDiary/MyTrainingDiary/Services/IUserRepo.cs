using System;
using System.Collections.Generic;
using System.Text;
using MyTrainingDiary.DAL.Interfaces;

namespace MyTrainingDiary.Services
{
    public interface IUserRepo
    {
        Guid GetUserIdByUserCredentials(IUserCredentials userCredentials);
    }
}
