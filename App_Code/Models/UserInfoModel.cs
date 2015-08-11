using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de UserInfoModel
/// </summary>
public class UserInfoModel
{
    public UserInformation GetUserInformation(String guId)
    {
        CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();
        UserInformation info = (from x in db.UserInformations
                                where x.GUID == guId
                                select x).FirstOrDefault();
        return info;
    }

    public void InsertUserInformation(UserInformation info)
    {
        CANDZOILPDBEntities1 db = new CANDZOILPDBEntities1();
        db.UserInformations.Add(info);
        db.SaveChanges();

    }
}