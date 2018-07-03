using System.Data.Entity;
using WinStatus.Classes;

namespace WinStatus.DataModel
{
    public class WinStatusContext:DbContext
    {
        public DbSet<WinClass> WinClasses { get; set; }
        public DbSet<UserPassword> UserNamePasswords{ get; set; }
    }
}
