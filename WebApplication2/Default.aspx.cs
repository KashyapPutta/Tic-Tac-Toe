using System;
using System.Web.UI;
using System.Collections;


namespace WebApplication2
{
    public partial class _Default : Page
    {

        string player = null;
        string password = null;
        public void Page_Load(Object sender, EventArgs e)

        {
            player = (string)(Session["UserName"]);
            UserNameDisplay.Text = player;
            password = (string)(Session["Password"]);

        }


        int cornernumbers = 0;
        int middlenumbers = 0;
        int computerchoice = 0;

        ConsoleApplication1.Program Insert = new ConsoleApplication1.Program();

        public ArrayList storage = new ArrayList();
        public ArrayList userstorage = new ArrayList();
        public ArrayList machinestorage = new ArrayList();


        public void Button1_Click(object sender, EventArgs e)
        {
            Button1.BackColor = System.Drawing.Color.Green;
            Button1.Text = "X";

            if (ViewState["datastorage"] == null)
            {

                userstorage.Add(1);
                storage.Add(1);
                ViewState["datastorage"] = storage;
                ViewState["viewuserstorage"] = userstorage;
                ViewState["viewmachinestorage"] = machinestorage;

            }
            else
            {

                storage = (ArrayList)ViewState["datastorage"];
                storage.Add(1);

                userstorage = (ArrayList)ViewState["viewuserstorage"];
                userstorage.Add(1);
                machinestorage = (ArrayList)ViewState["viewmachinestorage"];
            }

            if (storage.Count != 9)
            {
                Random();

                BlockingStrategy();
                WinningStrategy();


                IfStorageNotEqualTo9();
            }

            else
            {

                ElseCondition();

            }


            this.Button1.Enabled = false;

        }

        public void Button2_Click(object sender, EventArgs e)
        {
            Button2.BackColor = System.Drawing.Color.Green;
            Button2.Text = "X";

            if (ViewState["datastorage"] == null)
            {
                userstorage.Add(2);
                storage.Add(2);
                ViewState["datastorage"] = storage;
                ViewState["viewuserstorage"] = userstorage;
                ViewState["viewmachinestorage"] = machinestorage;
            }
            else
            {

                storage = (ArrayList)ViewState["datastorage"];
                storage.Add(2);

                userstorage = (ArrayList)ViewState["viewuserstorage"];
                userstorage.Add(2);
                machinestorage = (ArrayList)ViewState["viewmachinestorage"];
            }


            if (storage.Count != 9)
            {
                Random();

                BlockingStrategy();
                WinningStrategy();

                IfStorageNotEqualTo9();
            }
            else
            {


                ElseCondition();

            }

            this.Button2.Enabled = false;
        }

        public void Button3_Click(object sender, EventArgs e)
        {
            Button3.BackColor = System.Drawing.Color.Green;
            Button3.Text = "X";

            if (ViewState["datastorage"] == null)
            {
                userstorage.Add(3);
                storage.Add(3);
                ViewState["datastorage"] = storage;
                ViewState["viewuserstorage"] = userstorage;
                ViewState["viewmachinestorage"] = machinestorage;

            }
            else
            {

                storage = (ArrayList)ViewState["datastorage"];
                storage.Add(3);
                userstorage = (ArrayList)ViewState["viewuserstorage"];
                userstorage.Add(3);
                machinestorage = (ArrayList)ViewState["viewmachinestorage"];
            }


            if (storage.Count != 9)
            {
                Random();

                BlockingStrategy();
                WinningStrategy();

                IfStorageNotEqualTo9();
            }
            else
            {


                ElseCondition();

            }

            this.Button3.Enabled = false;
        }

        public void Button4_Click(object sender, EventArgs e)
        {
            Button4.BackColor = System.Drawing.Color.Green;
            Button4.Text = "X";

            if (ViewState["datastorage"] == null)
            {
                userstorage.Add(4);
                storage.Add(4);
                ViewState["datastorage"] = storage;
                ViewState["viewuserstorage"] = userstorage;
                ViewState["viewmachinestorage"] = machinestorage;
            }
            else
            {
                storage = (ArrayList)ViewState["datastorage"];
                storage.Add(4);

                userstorage = (ArrayList)ViewState["viewuserstorage"];
                userstorage.Add(4);
                machinestorage = (ArrayList)ViewState["viewmachinestorage"];
            }


            if (storage.Count != 9)
            {
                Random();

                BlockingStrategy();
                WinningStrategy();

                IfStorageNotEqualTo9();
            }
            else
            {



                ElseCondition();

            }

            this.Button4.Enabled = false;
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            Button5.BackColor = System.Drawing.Color.Green;
            Button5.Text = "X";

            if (ViewState["datastorage"] == null)
            {
                userstorage.Add(5);
                storage.Add(5);
                ViewState["datastorage"] = storage;
                ViewState["viewuserstorage"] = userstorage;
                ViewState["viewmachinestorage"] = machinestorage;
            }
            else
            {
                storage = (ArrayList)ViewState["datastorage"];
                storage.Add(5);

                userstorage = (ArrayList)ViewState["viewuserstorage"];
                userstorage.Add(5);
                machinestorage = (ArrayList)ViewState["viewmachinestorage"];
            }


            if (storage.Count != 9)
            {
                Random();

                BlockingStrategy();
                WinningStrategy();

                IfStorageNotEqualTo9();
            }
            else
            {
                ElseCondition();

            }

            this.Button5.Enabled = false;
        }

        public void Button6_Click(object sender, EventArgs e)
        {
            Button6.BackColor = System.Drawing.Color.Green;
            Button6.Text = "X";

            if (ViewState["datastorage"] == null)
            {
                userstorage.Add(6);
                storage.Add(6);
                ViewState["datastorage"] = storage;
                ViewState["viewuserstorage"] = userstorage;
                ViewState["viewmachinestorage"] = machinestorage;
            }
            else
            {
                storage = (ArrayList)ViewState["datastorage"];
                storage.Add(6);

                userstorage = (ArrayList)ViewState["viewuserstorage"];
                userstorage.Add(6);

                machinestorage = (ArrayList)ViewState["viewmachinestorage"];
            }


            if (storage.Count != 9)
            {
                Random();

                BlockingStrategy();
                WinningStrategy();

                IfStorageNotEqualTo9();
            }
            else
            {
                ElseCondition();

            }

            this.Button6.Enabled = false;
        }

        public void Button7_Click(object sender, EventArgs e)
        {
            Button7.BackColor = System.Drawing.Color.Green;
            Button7.Text = "X";

            if (ViewState["datastorage"] == null)
            {
                userstorage.Add(7);
                storage.Add(7);
                ViewState["datastorage"] = storage;
                ViewState["viewuserstorage"] = userstorage;
                ViewState["viewmachinestorage"] = machinestorage;
            }
            else
            {
                storage = (ArrayList)ViewState["datastorage"];
                storage.Add(7);

                userstorage = (ArrayList)ViewState["viewuserstorage"];
                userstorage.Add(7);
                machinestorage = (ArrayList)ViewState["viewmachinestorage"];
            }


            if (storage.Count != 9)
            {
                Random();

                BlockingStrategy();
                WinningStrategy();

                IfStorageNotEqualTo9();
            }
            else
            {
                ElseCondition();

            }

            this.Button7.Enabled = false;
        }

        public void Button8_Click(object sender, EventArgs e)
        {
            Button8.BackColor = System.Drawing.Color.Green;
            Button8.Text = "X";

            if (ViewState["datastorage"] == null)
            {
                userstorage.Add(8);
                storage.Add(8);
                ViewState["datastorage"] = storage;
                ViewState["viewuserstorage"] = userstorage;
                ViewState["viewmachinestorage"] = machinestorage;
            }
            else
            {
                storage = (ArrayList)ViewState["datastorage"];
                storage.Add(8);

                userstorage = (ArrayList)ViewState["viewuserstorage"];
                userstorage.Add(8);
                machinestorage = (ArrayList)ViewState["viewmachinestorage"];
            }


            if (storage.Count != 9)
            {
                Random();

                BlockingStrategy();
                WinningStrategy();

                IfStorageNotEqualTo9();
            }
            else
            {
                ElseCondition();
            }

            this.Button8.Enabled = false;
        }

        public void Button9_Click(object sender, EventArgs e)
        {
            Button9.BackColor = System.Drawing.Color.Green;
            Button9.Text = "X";

            if (ViewState["datastorage"] == null)
            {
                userstorage.Add(9);
                storage.Add(9);
                ViewState["datastorage"] = storage;
                ViewState["viewuserstorage"] = userstorage;
                ViewState["viewmachinestorage"] = machinestorage;
            }
            else
            {
                storage = (ArrayList)ViewState["datastorage"];
                storage.Add(9);

                userstorage = (ArrayList)ViewState["viewuserstorage"];
                userstorage.Add(9);
                machinestorage = (ArrayList)ViewState["viewmachinestorage"];
            }


            if (storage.Count != 9)
            {
                Random();

                BlockingStrategy();
                WinningStrategy();

                IfStorageNotEqualTo9();
            }
            else
            {
                ElseCondition();

            }

            this.Button9.Enabled = false;
        }


        public void Random()
        {


            if (!storage.Contains(1) || !storage.Contains(3) || !storage.Contains(7) || !storage.Contains(9))
            {

                //int cornernumbers = 0;

                bool corner = true;
                while (corner)
                {
                    Random rnd = new Random();
                    cornernumbers = rnd.Next(1, 10);


                    if (cornernumbers == 1 || cornernumbers == 3 || cornernumbers == 7 || cornernumbers == 9)
                    {

                        if (storage.Contains(cornernumbers))
                        {
                            corner = true;
                        }

                        else
                        {
                            corner = false;

                        }
                    }
                }
                computerchoice = cornernumbers;
            }

            if (storage.Contains(1) && storage.Contains(3) && storage.Contains(7) && storage.Contains(9))
            {
                bool entry = true;
                while (entry)
                {
                    Random rndam = new Random();
                    middlenumbers = rndam.Next(1, 9);

                    if (middlenumbers == 2 || middlenumbers == 4 || middlenumbers == 6 || middlenumbers == 8)
                    {
                        if (storage.Contains(middlenumbers))
                        {
                            entry = true;
                        }
                        else
                            entry = false;

                    }

                }
                computerchoice = middlenumbers;
            }

            if (!userstorage.Contains(5) && !machinestorage.Contains(5))
            {
                computerchoice = 5;

            }


            BlockingStrategy();

            WinningStrategy();




            ComputerChoiceTextBox.Text = computerchoice.ToString();

            if (computerchoice == 1)
            {
                Button1.BackColor = System.Drawing.Color.Red;
                Button1.Text = "O";
                this.Button1.Enabled = false;
                save();
            }

            if (computerchoice == 2)
            {
                Button2.BackColor = System.Drawing.Color.Red;
                Button2.Text = "O";
                this.Button2.Enabled = false;
                save();
            }

            if (computerchoice == 3)
            {
                Button3.BackColor = System.Drawing.Color.Red;
                Button3.Text = "O";
                this.Button3.Enabled = false;
                save();
            }

            if (computerchoice == 4)
            {
                Button4.BackColor = System.Drawing.Color.Red;
                Button4.Text = "O";
                this.Button4.Enabled = false;
                save();
            }

            if (computerchoice == 5)
            {
                Button5.BackColor = System.Drawing.Color.Red;
                Button5.Text = "O";
                this.Button5.Enabled = false;
                save();
            }

            if (computerchoice == 6)
            {
                Button6.BackColor = System.Drawing.Color.Red;
                Button6.Text = "O";
                this.Button6.Enabled = false;
                save();
            }

            if (computerchoice == 7)
            {
                Button7.BackColor = System.Drawing.Color.Red;
                Button7.Text = "O";
                this.Button7.Enabled = false;
                save();
            }

            if (computerchoice == 8)
            {
                Button8.BackColor = System.Drawing.Color.Red;
                Button8.Text = "O";
                this.Button8.Enabled = false;
                save();
            }

            if (computerchoice == 9)
            {
                Button9.BackColor = System.Drawing.Color.Red;
                Button9.Text = "O";
                this.Button9.Enabled = false;
                save();
            }

        }


        public void IfStorageNotEqualTo9()
        {
            if (userstorage.Contains(1) && userstorage.Contains(5) && userstorage.Contains(9) ||
                    userstorage.Contains(3) && userstorage.Contains(5) && userstorage.Contains(7) ||
                    userstorage.Contains(1) && userstorage.Contains(2) && userstorage.Contains(3) ||
                    userstorage.Contains(1) && userstorage.Contains(4) && userstorage.Contains(7) ||
                    userstorage.Contains(3) && userstorage.Contains(6) && userstorage.Contains(9) ||
                    userstorage.Contains(4) && userstorage.Contains(5) && userstorage.Contains(6) ||
                    userstorage.Contains(7) && userstorage.Contains(8) && userstorage.Contains(9) ||
                    userstorage.Contains(2) && userstorage.Contains(5) && userstorage.Contains(8))
            {
                WinStatusBox.Text = "Human is the Winner";
                Insert.InsertStatus(player);
                this.Button1.Enabled = false;
                this.Button2.Enabled = false;
                this.Button3.Enabled = false;
                this.Button4.Enabled = false;
                this.Button5.Enabled = false;
                this.Button6.Enabled = false;
                this.Button7.Enabled = false;
                this.Button8.Enabled = false;
                this.Button9.Enabled = false;
            }

            else if (machinestorage.Contains(1) && machinestorage.Contains(5) && machinestorage.Contains(9) ||
                machinestorage.Contains(3) && machinestorage.Contains(5) && machinestorage.Contains(7) ||
                machinestorage.Contains(1) && machinestorage.Contains(2) && machinestorage.Contains(3) ||
                machinestorage.Contains(4) && machinestorage.Contains(5) && machinestorage.Contains(6) ||
                machinestorage.Contains(7) && machinestorage.Contains(8) && machinestorage.Contains(9) ||
                machinestorage.Contains(1) && machinestorage.Contains(4) && machinestorage.Contains(7) ||
                machinestorage.Contains(3) && machinestorage.Contains(6) && machinestorage.Contains(9) ||
                machinestorage.Contains(2) && machinestorage.Contains(5) && machinestorage.Contains(8))
            {
                WinStatusBox.Text = " Machine is the Winner";
                Insert.InsertUserLooseStatus(player);
                Insert.InsertUserNamePassword(player, password);
                this.Button1.Enabled = false;
                this.Button2.Enabled = false;
                this.Button3.Enabled = false;
                this.Button4.Enabled = false;
                this.Button5.Enabled = false;
                this.Button6.Enabled = false;
                this.Button7.Enabled = false;
                this.Button8.Enabled = false;
                this.Button9.Enabled = false;
            }

            else if (storage.Contains(1) && storage.Contains(5) && storage.Contains(9) &&
                    storage.Contains(3) && storage.Contains(5) && storage.Contains(7) &&
                    storage.Contains(1) && storage.Contains(2) && storage.Contains(3) &&
                    storage.Contains(1) && storage.Contains(4) && storage.Contains(7) &&
                    storage.Contains(3) && storage.Contains(6) && storage.Contains(9) &&
                    storage.Contains(4) && storage.Contains(5) && storage.Contains(6) &&
                    storage.Contains(7) && storage.Contains(8) && storage.Contains(9) &&
                    storage.Contains(2) && storage.Contains(5) && storage.Contains(8))

            {

                WinStatusBox.Text = " OOPS !! GAME DRAW";
                Insert.InsertGameDrawStatus(player);
                Insert.InsertUserNamePassword(player, password);
                this.Button1.Enabled = false;
                this.Button2.Enabled = false;
                this.Button3.Enabled = false;
                this.Button4.Enabled = false;
                this.Button5.Enabled = false;
                this.Button6.Enabled = false;
                this.Button7.Enabled = false;
                this.Button8.Enabled = false;
                this.Button9.Enabled = false;
            }
        }

        public void ElseCondition()
        {
            if (userstorage.Contains(1) && userstorage.Contains(5) && userstorage.Contains(9) ||
                    userstorage.Contains(3) && userstorage.Contains(5) && userstorage.Contains(7) ||
                    userstorage.Contains(1) && userstorage.Contains(2) && userstorage.Contains(3) ||
                    userstorage.Contains(1) && userstorage.Contains(4) && userstorage.Contains(7) ||
                    userstorage.Contains(3) && userstorage.Contains(6) && userstorage.Contains(9) ||
                    userstorage.Contains(4) && userstorage.Contains(5) && userstorage.Contains(6) ||
                    userstorage.Contains(7) && userstorage.Contains(8) && userstorage.Contains(9) ||
                    userstorage.Contains(2) && userstorage.Contains(5) && userstorage.Contains(8))
            {
                WinStatusBox.Text = "Human is the Winner";
                Insert.InsertStatus(player);
                Insert.InsertUserNamePassword(player, password);
                this.Button1.Enabled = false;
                this.Button2.Enabled = false;
                this.Button3.Enabled = false;
                this.Button4.Enabled = false;
                this.Button5.Enabled = false;
                this.Button6.Enabled = false;
                this.Button7.Enabled = false;
                this.Button8.Enabled = false;
                this.Button9.Enabled = false;
            }

            if (machinestorage.Contains(1) && machinestorage.Contains(5) && machinestorage.Contains(9) ||
                machinestorage.Contains(3) && machinestorage.Contains(5) && machinestorage.Contains(7) ||
                machinestorage.Contains(1) && machinestorage.Contains(2) && machinestorage.Contains(3) ||
                machinestorage.Contains(4) && machinestorage.Contains(5) && machinestorage.Contains(6) ||
                machinestorage.Contains(7) && machinestorage.Contains(8) && machinestorage.Contains(9) ||
                machinestorage.Contains(1) && machinestorage.Contains(4) && machinestorage.Contains(7) ||
                machinestorage.Contains(3) && machinestorage.Contains(6) && machinestorage.Contains(9) ||
                machinestorage.Contains(2) && machinestorage.Contains(5) && machinestorage.Contains(8))
            {
                WinStatusBox.Text = " Machine is the Winner";
                Insert.InsertUserLooseStatus(player);
                Insert.InsertUserNamePassword(player, password);
                this.Button1.Enabled = false;
                this.Button2.Enabled = false;
                this.Button3.Enabled = false;
                this.Button4.Enabled = false;
                this.Button5.Enabled = false;
                this.Button6.Enabled = false;
                this.Button7.Enabled = false;
                this.Button8.Enabled = false;
                this.Button9.Enabled = false;
            }

            else if (storage.Contains(1) && storage.Contains(5) && storage.Contains(9) &&
                    storage.Contains(3) && storage.Contains(5) && storage.Contains(7) &&
                    storage.Contains(1) && storage.Contains(2) && storage.Contains(3) &&
                    storage.Contains(1) && storage.Contains(4) && storage.Contains(7) &&
                    storage.Contains(3) && storage.Contains(6) && storage.Contains(9) &&
                    storage.Contains(4) && storage.Contains(5) && storage.Contains(6) &&
                    storage.Contains(7) && storage.Contains(8) && storage.Contains(9) &&
                    storage.Contains(2) && storage.Contains(5) && storage.Contains(8))
            {

                WinStatusBox.Text = " OOPS !! GAME DRAW";
                Insert.InsertGameDrawStatus(player);
                Insert.InsertUserNamePassword(player, password);
                this.Button1.Enabled = false;
                this.Button2.Enabled = false;
                this.Button3.Enabled = false;
                this.Button4.Enabled = false;
                this.Button5.Enabled = false;
                this.Button6.Enabled = false;
                this.Button7.Enabled = false;
                this.Button8.Enabled = false;
                this.Button9.Enabled = false;
            }
        }


        public void BlockingStrategy()
        {
            //*******************************START OF MACHINE BLOCKING STRATEGY*****************************************

            // bLOCKING USER 1,2----3 MACHINE
            if (userstorage.Contains(1) && userstorage.Contains(2) && !machinestorage.Contains(3))
            {
                computerchoice = 3;
            }




            // bLOCKING USER 1,3----2 MACHINE
            if (userstorage.Contains(1) && userstorage.Contains(3) && !machinestorage.Contains(2))
            {
                computerchoice = 2;
            }



            // bLOCKING USER 2,3----1 MACHINE
            if (userstorage.Contains(2) && userstorage.Contains(3) && !machinestorage.Contains(1))
            {
                computerchoice = 1;
            }



            //############################################################### HORIZONTAL 2 MACHINE BLOCK

            // bLOCKING USER 4,5----6 MACHINE
            if (userstorage.Contains(4) && userstorage.Contains(5) && !machinestorage.Contains(6))
            {
                computerchoice = 6;
            }



            // bLOCKING USER 4,6----5 MACHINE
            if (userstorage.Contains(4) && userstorage.Contains(6) && !machinestorage.Contains(5))
            {
                computerchoice = 5;
            }



            // bLOCKING USER 5,6----4 MACHINE
            if (userstorage.Contains(5) && userstorage.Contains(6) && !machinestorage.Contains(4))
            {
                computerchoice = 4;
            }


            //############################################################### HORIZONTAL 3 MACHINE BLOCK

            // bLOCKING USER 7,8----9 MACHINE
            if (userstorage.Contains(7) && userstorage.Contains(8) && !machinestorage.Contains(9))
            {
                computerchoice = 9;
            }



            // bLOCKING USER 8,9----7 MACHINE
            if (userstorage.Contains(8) && userstorage.Contains(9) && !machinestorage.Contains(7))
            {
                computerchoice = 7;
            }



            // bLOCKING USER 7,9----8 MACHINE
            if (userstorage.Contains(7) && userstorage.Contains(9) && !machinestorage.Contains(8))
            {
                computerchoice = 8;
            }



            //############################################################################ VERTICAL MACHINE BLOCK

            // bLOCKING USER 1,4----7 MACHINE
            if (userstorage.Contains(1) && userstorage.Contains(4) && !machinestorage.Contains(7))
            {
                computerchoice = 7;
            }



            // bLOCKING USER 4,7----1 MACHINE

            if (userstorage.Contains(4) && userstorage.Contains(7) && !machinestorage.Contains(1))
            {
                computerchoice = 1;
            }



            // bLOCKING USER 1,7----4 MACHINE
            if (userstorage.Contains(1) && userstorage.Contains(7) && !machinestorage.Contains(4))
            {
                computerchoice = 4;
            }



            //############################################################################ VERTICAL 2 MACHINE BLOCK


            // bLOCKING USER 2,5----8 MACHINE
            if (userstorage.Contains(2) && userstorage.Contains(5) && !machinestorage.Contains(8))
            {
                computerchoice = 8;
            }



            // bLOCKING USER 5,8----2 MACHINE
            if (userstorage.Contains(5) && userstorage.Contains(8) && !machinestorage.Contains(2))
            {
                computerchoice = 2;
            }



            // bLOCKING USER 2,8----5 MACHINE
            if (userstorage.Contains(2) && userstorage.Contains(8) && !machinestorage.Contains(5))
            {
                computerchoice = 5;
            }



            //############################################################################ VERTICAL 3 MACHINE BLOCK

            // bLOCKING USER 3,6----9 MACHINE
            if (userstorage.Contains(3) && userstorage.Contains(6) && !machinestorage.Contains(9))
            {
                computerchoice = 9;
            }



            // bLOCKING USER 6,9----3 MACHINE
            if (userstorage.Contains(6) && userstorage.Contains(9) && !machinestorage.Contains(3))
            {
                computerchoice = 3;
            }



            // bLOCKING USER 3,9----6 MACHINE
            if (userstorage.Contains(3) && userstorage.Contains(9) && !machinestorage.Contains(6))
            {
                computerchoice = 6;
            }


            //############################################################################ DIAGNOL 1 MACHINE BLOCK


            // bLOCKING USER 1,5----9 MACHINE
            if (userstorage.Contains(1) && userstorage.Contains(5) && !machinestorage.Contains(9))
            {
                computerchoice = 9;
            }



            // bLOCKING USER 1,9----5 MACHINE
            if (userstorage.Contains(1) && userstorage.Contains(9) && !machinestorage.Contains(5))
            {
                computerchoice = 5;
            }



            // bLOCKING USER 5,9----1 MACHINE
            if (userstorage.Contains(5) && userstorage.Contains(9) && !machinestorage.Contains(1))
            {
                computerchoice = 1;
            }



            //############################################################################ DIAGNOL 2 MACHINE BLOCK

            // bLOCKING USER 3,5----7 MACHINE
            if (userstorage.Contains(3) && userstorage.Contains(5) && !machinestorage.Contains(7))
            {
                computerchoice = 7;
            }



            // bLOCKING USER 5,7----3 MACHINE
            if (userstorage.Contains(5) && userstorage.Contains(7) && !machinestorage.Contains(3))
            {
                computerchoice = 3;
            }


            // bLOCKING USER 3,7----5 MACHINE
            if (userstorage.Contains(3) && userstorage.Contains(7) && !machinestorage.Contains(5))
            {
                computerchoice = 5;
            }

            //********************************END OF MACHINE BLOCKING STRATEGY*****************************************
            //********************************END OF MACHINE BLOCKING STRATEGY*****************************************

        }



        public void WinningStrategy()
        {
            //*******************************START OF MACHINE WINNING STRATEGY*****************************************



            // Machine Winning ---- 1,2,3

            if (machinestorage.Contains(1) && machinestorage.Contains(2) && !machinestorage.Contains(3) && !userstorage.Contains(3))
            {
                computerchoice = 3;
            }

            if (machinestorage.Contains(1) && machinestorage.Contains(3) && !machinestorage.Contains(2) && !userstorage.Contains(2))
            {
                computerchoice = 2;
            }

            if (machinestorage.Contains(2) && machinestorage.Contains(3) && !machinestorage.Contains(1) && !userstorage.Contains(1))
            {
                computerchoice = 1;
            }

            // Machine Winning ---- 4,5,6
            if (machinestorage.Contains(4) && machinestorage.Contains(5) && !machinestorage.Contains(6) && !userstorage.Contains(6))
            {
                computerchoice = 6;
            }

            if (machinestorage.Contains(4) && machinestorage.Contains(6) && !machinestorage.Contains(5) && !userstorage.Contains(5))
            {
                computerchoice = 5;
            }

            if (machinestorage.Contains(5) && machinestorage.Contains(6) && !machinestorage.Contains(4) && !userstorage.Contains(4))
            {
                computerchoice = 4;
            }

            // Machine Winning ---- 7,8,9

            if (machinestorage.Contains(7) && machinestorage.Contains(8) && !machinestorage.Contains(9) && !userstorage.Contains(9))
            {
                computerchoice = 9;
            }

            if (machinestorage.Contains(8) && machinestorage.Contains(9) && !machinestorage.Contains(7) && !userstorage.Contains(7))
            {
                computerchoice = 7;
            }

            if (machinestorage.Contains(7) && machinestorage.Contains(9) && !machinestorage.Contains(8) && !userstorage.Contains(8))
            {
                computerchoice = 8;
            }

            // Machine Winning ---- 1,4,7

            if (machinestorage.Contains(1) && machinestorage.Contains(4) && !machinestorage.Contains(7) && !userstorage.Contains(7))
            {
                computerchoice = 7;
            }

            if (machinestorage.Contains(4) && machinestorage.Contains(7) && !machinestorage.Contains(1) && !userstorage.Contains(1))
            {
                computerchoice = 1;
            }

            if (machinestorage.Contains(1) && machinestorage.Contains(7) && !machinestorage.Contains(4) && !userstorage.Contains(4))
            {
                computerchoice = 4;
            }

            // Machine Winning ---- 2,5,8

            if (machinestorage.Contains(2) && machinestorage.Contains(5) && !machinestorage.Contains(8) && !userstorage.Contains(8))
            {
                computerchoice = 8;
            }

            if (machinestorage.Contains(5) && machinestorage.Contains(8) && !machinestorage.Contains(2) && !userstorage.Contains(2))
            {
                computerchoice = 2;
            }

            if (machinestorage.Contains(2) && machinestorage.Contains(8) && !machinestorage.Contains(5) && !userstorage.Contains(5))
            {
                computerchoice = 5;
            }

            // Machine Winning ---- 3,6,9

            if (machinestorage.Contains(3) && machinestorage.Contains(6) && !machinestorage.Contains(9) && !userstorage.Contains(9))
            {
                computerchoice = 9;
            }

            if (machinestorage.Contains(6) && machinestorage.Contains(9) && !machinestorage.Contains(3) && !userstorage.Contains(3))
            {
                computerchoice = 3;
            }

            if (machinestorage.Contains(3) && machinestorage.Contains(9) && !machinestorage.Contains(6) && !userstorage.Contains(6))
            {
                computerchoice = 6;
            }

            // Machine Winning ---- 1,5,9

            if (machinestorage.Contains(1) && machinestorage.Contains(5) && !machinestorage.Contains(9) && !userstorage.Contains(9))
            {
                computerchoice = 9;
            }

            if (machinestorage.Contains(1) && machinestorage.Contains(9) && !machinestorage.Contains(5) && !userstorage.Contains(5))
            {
                computerchoice = 5;
            }

            if (machinestorage.Contains(5) && machinestorage.Contains(9) && !machinestorage.Contains(1) && !userstorage.Contains(1))
            {
                computerchoice = 1;
            }

            // Machine Winning ---- 3,5,7

            if (machinestorage.Contains(3) && machinestorage.Contains(5) && !machinestorage.Contains(7) && !userstorage.Contains(7))

            {
                computerchoice = 7;
            }

            if (machinestorage.Contains(5) && machinestorage.Contains(7) && !machinestorage.Contains(3) && !userstorage.Contains(3))
            {
                computerchoice = 3;
            }

            if (machinestorage.Contains(3) && machinestorage.Contains(7) && !machinestorage.Contains(5) && !userstorage.Contains(5))
            {
                computerchoice = 5;
            }

            // ********************************END of WINNING STRATEGY******************************************
        }


        public void save()
        {
            storage.Add(computerchoice);
            ViewState["datastorage"] = storage;
            machinestorage.Add(computerchoice);
            ViewState["viewmachinestorage"] = machinestorage;
        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Button1.Text = "1";
            Button2.Text = "2";
            Button3.Text = "3";
            Button4.Text = "4";
            Button5.Text = "5";
            Button6.Text = "6";
            Button7.Text = "7";
            Button8.Text = "8";
            Button9.Text = "9";

            WinStatusBox.Text = "";
            ComputerChoiceTextBox.Text = "";

            this.Button1.Enabled = true;
            this.Button2.Enabled = true;
            this.Button3.Enabled = true;
            this.Button4.Enabled = true;
            this.Button5.Enabled = true;
            this.Button6.Enabled = true;
            this.Button7.Enabled = true;
            this.Button8.Enabled = true;
            this.Button9.Enabled = true;

            ViewState["datastorage"] = null;
            ViewState["viewuserstorage"] = null;
            ViewState["viewmachinestorage"] = null;

            Button1.BackColor = System.Drawing.Color.Black;
            Button2.BackColor = System.Drawing.Color.Black;
            Button3.BackColor = System.Drawing.Color.Black;
            Button4.BackColor = System.Drawing.Color.Black;
            Button5.BackColor = System.Drawing.Color.Black;
            Button6.BackColor = System.Drawing.Color.Black;
            Button7.BackColor = System.Drawing.Color.Black;
            Button8.BackColor = System.Drawing.Color.Black;
            Button9.BackColor = System.Drawing.Color.Black;


            Response.Redirect("~/UserLogin.aspx");

        }


        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/ViewResults.aspx");
        }

        protected void UserNameDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }

}




