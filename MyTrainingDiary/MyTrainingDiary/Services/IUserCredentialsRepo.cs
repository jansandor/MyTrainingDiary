using System;
using System.Collections.Generic;
using System.Text;
using MyTrainingDiary.DAL.Interfaces;
using MyTrainingDiary.DAL.Models;

namespace MyTrainingDiary.Services
{
    public interface IUserCredentialsRepo
    {
        IUserCredentials GetUserCredentialsByUsername(string username);
    }
}
