using System;
using System.Linq;
using WinStatus.Classes;
using WinStatus.DataModel;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public void InsertStatus(string player)
        {

            var Winclass = new WinClass
            {
                Id = 1,
                UserWins = 1,
                MachineWins = 0,
                UserName = player,
                

            };

            using (var context = new WinStatusContext())
            {
                var choice = context.WinClasses.FirstOrDefault(c => c.UserName == player);

                if (choice != null)
                {
                    if (choice.UserName == player)
                    {
                        context.WinClasses.Attach(Winclass);
                        context.SaveChanges();
                    }

                }
                else
                {
                    context.WinClasses.Add(Winclass);
                    context.SaveChanges();
                }
            }

        }
    

    public void InsertUserLooseStatus(string player)
    {
        var Winclass = new WinClass
        {
            Id = 1,
            MachineWins = 1,
            UserWins = 0,
            UserName = player,
        };

        using (var context = new WinStatusContext())
        {
            var choice1 = context.WinClasses.FirstOrDefault(c => c.UserName == player);

            if (choice1 != null)
            {
                if (choice1.UserName == player)
                {
                    context.WinClasses.Attach(Winclass);
                    context.SaveChanges();
                }

            }
            else
            {
                context.WinClasses.Add(Winclass);
                context.SaveChanges();
            }
        }
    }


    public void InsertGameDrawStatus(string player)
    {
        var Winclass = new WinClass
        {
            Id = 1,
            MachineWins = 0,
            UserWins = 0,
            UserName = player,
        };

        using (var context = new WinStatusContext())
        {
                var choice2 = context.WinClasses.FirstOrDefault(c => c.UserName == player);

                if (choice2 != null)
                {
                    if (choice2.UserName == player)
                    {
                        context.WinClasses.Attach(Winclass);
                        context.SaveChanges();
                    }

                }
                else
                {
                    context.WinClasses.Add(Winclass);
                    context.SaveChanges();
                }
            }
    }


    public void InsertUserNamePassword(string player, string password)
    {
        var UserPassword = new UserPassword
        {
            id = 1,
            UserName = player,
            Password = password,
        };

        using (var context = new WinStatusContext())
        {

            context.UserNamePasswords.Add(UserPassword);
            context.SaveChanges();
        }
    }

    public int QueryIfUserNameAndPasswordExists(string password, string player)
    {
        using (var context = new WinStatusContext())
        {

            var user = context.UserNamePasswords.FirstOrDefault(u => u.UserName == player);


            if (user != null)
            {
                if (user.Password == password)
                    return 1;
                else
                    return 0;

            }

            else
                return 2;


        }

    }



    public int SignUPEnquiryIfUserNameExists(string password, string player)
    {
        using (var context = new WinStatusContext())
        {

            var user = context.UserNamePasswords.FirstOrDefault(u => u.UserName == player);


            if (user != null)
            {
                if (user.UserName == player)
                    return 3;
                else
                    return 3;
            }

            else
                return 4;

        }
    }
}
}

