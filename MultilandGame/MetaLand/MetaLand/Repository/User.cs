using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.Repository
{
    public static class User
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string UserSurname { get; set; }
        public static string UserNickname  { get; set; }
        public static string Password { get; set; }
        public static int AmountFood { get; set; }
        public static int AmountItem { get; set; }
        public static int AmountMoney { get; set; }
        public static DateTime StartDate { get; set; } = DateTime.Now;

    }
}
