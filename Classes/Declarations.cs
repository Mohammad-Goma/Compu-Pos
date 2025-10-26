using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compu_Pos.Classes
{
    public static class Declarations
    {
        public static int userId;
        public static string userFullName;
        public static Dictionary<string, Object> systemOptions;
        public static List<modelPermission> permissions;
        public static string sysLanguage;
    }

    public class modelPermission
    {
        public string mainScreen { get; set; }
        public string permission { get; set; }
        public bool theCase { get; set; }
    }
}
