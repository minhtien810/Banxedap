using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class UserDao
    {
        BanXeDap2DbContext db = null;
        public UserDao()
        {
            db = new BanXeDap2DbContext();
        }
        public long Insert(admin ad)
        {
            db.admins.Add(ad);
            db.SaveChanges();
            return ad.id_admin;
        }
        public admin GetById(string userName)
        {
            return db.admins.SingleOrDefault(x=>x.ten_admin==userName);
        }
        public int Login(string userName, string passWord)
        {
            var result = db.admins.SingleOrDefault(x => x.ten_admin.ToString() == userName);
            if (result == null)
                return 0;
            else
            {
                if (result.matkhau_admin == passWord)
                    return 1;
                else
                    return -1;
            }
        }
    }
}
