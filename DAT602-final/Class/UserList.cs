using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT602_final
{
    internal class UserList
    {
        private static Dictionary<string, User> _userList = new();

        public static Dictionary<string, User> TourListing { get => _userList; }

    }

}
