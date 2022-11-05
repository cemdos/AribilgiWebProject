using AribilgiWebProject.Common.Enums;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AribilgiWebProject.BLL
{
    public class AccountBusiness
    {
        public int AddUser(User user)
        {
            return UnitOfWork.AddData(user);
        }

        public User Login(string Username, string password)
        {
            return UnitOfWork.GetAll<User>().Find(_ => _.UserName == Username
                                                && _.Password == password);
        }
    }
}
