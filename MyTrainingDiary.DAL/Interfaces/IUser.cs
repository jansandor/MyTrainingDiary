using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Interfaces
{
    /// <summary>
    /// Vzdycky je mozne, ze vznikne vice typu uzivatelu, treba premium user, proto radeji Iface
    /// </summary>
    public interface IUser
    {
        Guid Id { get; }
    }
}
