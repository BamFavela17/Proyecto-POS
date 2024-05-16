using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
     public class UserModel
    {
        CD_Usuario userDao = new CD_Usuario();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
        public void Cargo(int cargo)
        {
            userDao.Cargo(cargo);
        }
    }
}
