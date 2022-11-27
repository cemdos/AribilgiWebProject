using AribilgiWebProject.BLL.Interfaces;
using AribilgiWebProject.Common.Enums;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Exception;
using AribilgiWebProject.Model;
using System;
using System.Linq;

namespace AribilgiWebProject.BLL.Classes
{
    public class UserInfoRepository : BaseRepository<User>, IUserInfoRepository
    {

    }
}
