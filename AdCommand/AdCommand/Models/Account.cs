using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RRM.Entities.Models;

namespace Web.AdCommand.Models
{
    public class UserAccount
    {
        public User IsValid(string _email, string _password, AdcommandContext db)
        {

            string pwd = SHA1.Encode(_password);
            User val = (from user in db.Users where (user.Email == _email && user.Password == pwd) select user).FirstOrDefault();
            return val;
        }
    }

    public class SHA1
    {
        public static string Encode(string value)
        {
            var hash = System.Security.Cryptography.SHA1.Create();
            var encoder = new System.Text.ASCIIEncoding();
            var combined = encoder.GetBytes(value ?? "");
            return BitConverter.ToString(hash.ComputeHash(combined)).ToLower().Replace("-", "");
        }
    }
}