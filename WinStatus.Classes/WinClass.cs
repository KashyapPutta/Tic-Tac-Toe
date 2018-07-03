using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WinStatus.Classes
{
    public class WinClass
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public int UserWins { get; set; }
        public int MachineWins { get; set; }
      
    }

    public class UserPassword
    {
        [Key]
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
