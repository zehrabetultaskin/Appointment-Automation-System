using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace HastaneRandevuOtomasyonu
{
    public class utils
    {
        /*public static string hashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypted_bytes);
        }*/
        public static Dictionary<int, string> getSlots()
        {
            Dictionary<int, string> slots = new Dictionary<int, string>();
            slots.Add(1, "Sıra 1: 6:00-6:30");
            slots.Add(2, "Sıra 2: 6:30-7:00");
            slots.Add(3, "Sıra 3: 7:00-7:30");
            slots.Add(4, "Sıra 4: 7:30-8:00");
            slots.Add(5, "Sıra 5: 8:00-8:30");
            slots.Add(6, "Sıra 6: 8:30-9:00");
            slots.Add(7, "Sıra 7: 9:00-9:30");
            slots.Add(8, "Sıra 8: 9:30-10:00");
            slots.Add(9, "Sıra 9: 10:00-10:30");
            slots.Add(10, "Sıra 10: 10:30-11:00");
            return slots;
        }
    }
}
