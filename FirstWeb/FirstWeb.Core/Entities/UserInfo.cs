using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeb.Core.Entities
{
    public class UserInfo
    {
        public int LocalID { get; set; }
        public int UserID { get; set; }
        public string OpenID { get; set; }
        public int WinCase { get; set; }
        public int TotalCase { get; set; }
    }
}
