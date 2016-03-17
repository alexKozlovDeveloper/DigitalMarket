using DigitalMarket.Db.Entityes;
using DigitalMarket.Db.Entityes.DbContexts;
using DigitalMarket.Shared.Convert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMarket.Db.Repositoryes
{
    public class DmRepository
    {
        public User CreateUser(string name, string password, DateTime dayOfBirth, string email)
        {
            using (var db = new MarketContext(""))
            {
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Password = password,
                    Email = email,
                    DayOfBirth = dayOfBirth
                };

                db.Users.Add(user);

                db.SaveChanges();

                return user;
            }
        }

        //public ActivateCode CreateActivateCode(string login, string password, string email)
        //{
        //    return new ActivateCode();
        //}


        //public ActivateCode CreateActivateCode(Guid userId)
        //{
        //    using (var db = new DdmDbContextV1())
        //    {
        //        var id = Guid.NewGuid();

        //        var code = new ActivateCodeT
        //        {
        //            Id = id,
        //            Date = DateTime.Now,
        //            Code = id.ToString().Substring(9, 4),
        //            UserId = userId
        //        };

        //        db.ActivateCodes.Add(code);

        //        db.SaveChanges();

        //        return DbConverter.GetActivateCode(code);
        //    }
        //}


        //public void ActivateUser(Guid userId)
        //{
        //    using (var db = new DdmDbContextV1())
        //    {
        //        var user = GetUserT(userId, db);

        //        user.IsActivate = true;

        //        db.SaveChanges();
        //    }
        //}


        //private UserT GetUserT(Guid userId, DdmDbContextV1 db)
        //{
        //    var user = (from item in db.Users
        //                where item.Id == userId
        //                select item).FirstOrDefault();

        //    return user;
        //}
    }
}
