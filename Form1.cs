using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_Port1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblW.Visible = false; //Set all label visibility to false for load of program
            lblE.Visible = false;
            lblL.Visible = false;
            lblC.Visible = false;  
            lblO.Visible = false;  
            lblM.Visible = false;
            lblnameE.Visible = false;

            lblBack_A.Visible = false;
            lblBack_B.Visible = false;
            lblBack_C.Visible = false;
            lblBack_K.Visible = false;

            lblClientName.Visible = false;

            lblWhat.Visible = false;

            lblManage_1.Visible = false;
            lblPreviousTasks.Visible = false;
            lblAddAnotherTask.Visible = false;

            pbAddTask.Visible = false;
            pbManage.Visible = false;
            pbPreviousTask.Visible = false;
            
            pbMainLogo.Visible = false;
            
            //Using timer, to create fade in entrace effect for "WELCOME"
            //W
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, args) =>
            {
                lblW.Visible = true; 
                timer.Stop(); 
            };
            timer.Start();
            //E
            Timer timer2 = new Timer();
            timer2.Interval = 1200;
            timer2.Tick += (s, args) =>
            {
                lblE.Visible = true;
                timer2.Stop();
            };
            timer2.Start();
            //L
            Timer timer3 = new Timer();
            timer3.Interval = 1400;
            timer3.Tick += (s, args) =>
            {
                lblL.Visible = true;
                timer3.Stop();
            };
            timer3.Start();
            //C
            Timer timer4 = new Timer();
            timer4.Interval = 1600;
            timer4.Tick += (s, args) =>
            {
                lblC.Visible = true;
                timer4.Stop();
            };
            timer4.Start();
            //O
            Timer timer5 = new Timer();
            timer5.Interval = 1800;
            timer5.Tick += (s, args) =>
            {
                lblO.Visible = true;
                timer5.Stop();
            };
            timer5.Start();
            //M
            Timer timer6 = new Timer();
            timer6.Interval = 2000;
            timer6.Tick += (s, args) =>
            {
                lblM.Visible = true;
                timer6.Stop();
            };
            timer6.Start();
            //E
            Timer timer7 = new Timer();
            timer7.Interval = 2200;
            timer7.Tick += (s, args) =>
            {
                lblnameE.Visible = true;
                timer7.Stop();
            };
            timer7.Start();

            //Same method used for "BACK" effect
            //B
            Timer timer8 = new Timer();
            timer8.Interval = 2400;
            timer8.Tick += (s, args) =>
            {
                lblBack_B.Visible = true;
                timer8.Stop();
            };
            timer8.Start();
            //A
            Timer timer9 = new Timer();
            timer9.Interval = 2600;
            timer9.Tick += (s, args) =>
            {
                lblBack_A.Visible = true;
                timer9.Stop();
            };
            timer9.Start();
            //C
            Timer timer10 = new Timer();
            timer10.Interval = 2800;
            timer10.Tick += (s, args) =>
            {
                lblBack_C.Visible = true;
                timer10.Stop();
            };
            timer10.Start();
            //K
            Timer timer11 = new Timer();
            timer11.Interval = 3000;
            timer11.Tick += (s, args) =>
            {
                lblBack_K.Visible = true;
                timer11.Stop();
            };
            timer11.Start();

            //Client Name
            //K
            Timer timer12 = new Timer();
            timer12.Interval = 3200;
            timer12.Tick += (s, args) =>
            {
                lblClientName.Visible = true;
                timer12.Stop();
            };
            timer12.Start();

            //Clear all labels
            Timer timer13 = new Timer();
            timer13.Interval = 5000;
            timer13.Tick += (s, args) =>
            {
                //Set all label visibility to false after greeting
                lblClientName.Visible = false;

                lblBack_K.Visible = false;
                lblBack_C.Visible = false;
                lblBack_A.Visible = false;
                lblBack_B.Visible = false;

                lblnameE.Visible = false;
                lblM.Visible = false;
                lblO.Visible = false;
                lblC.Visible = false;
                lblL.Visible = false;
                lblE.Visible = false;
                lblW.Visible = false; 
                
                timer13.Stop();
            };
            timer13.Start();

            //Display label "What are we doing today?"
            Timer timer14 = new Timer();
            timer14.Interval = 5500;
            timer14.Tick += (s, args) =>
            {
                lblWhat.Visible = true;
                timer14.Stop();
            };
            timer14.Start();

            //Load Main Logo pb
            Timer timer22 = new Timer();
            timer22.Interval = 6000;
            timer22.Tick += (s, args) =>
            {
                pbMainLogo.Visible = true;
                timer22.Stop();
            };
            timer22.Start();

            //Load manage task label
            Timer timer15 = new Timer();
            timer15.Interval = 6600;
            timer15.Tick += (s, args) =>
            {
                lblManage_1.Visible = true;
                timer15.Stop();
            };
            timer15.Start();
            //Load Add Task picture
            Timer timer16 = new Timer();
            timer16.Interval = 6700;
            timer16.Tick += (s, args) =>
            {
                lblAddAnotherTask.Visible = true;
                timer16.Stop();
            };
            timer16.Start();
            
            //Load Previous task label
            Timer timer18 = new Timer();
            timer18.Interval = 6800;
            timer18.Tick += (s, args) =>
            {
                lblPreviousTasks.Visible = true;
                timer18.Stop();
            };
            timer18.Start();
            //Load Manage Task Pb
            Timer timer19 = new Timer();
            timer19.Interval = 6900;
            timer19.Tick += (s, args) =>
            {
                pbManage.Visible = true;
                timer19.Stop();
            };
            timer19.Start();
            //Load Add Task pb
            Timer timer20 = new Timer();
            timer20.Interval = 7000;
            timer20.Tick += (s, args) =>
            {
                pbAddTask.Visible = true;
                timer20.Stop();
            };
            timer20.Start();
            //Load Previous Task pb
            Timer timer21 = new Timer();
            timer21.Interval = 7100;
            timer21.Tick += (s, args) =>
            {
                pbPreviousTask.Visible = true;
                timer21.Stop();
            };
            timer21.Start();
            



        }

        private void bunifuCustomLabel1_Enter(object sender, EventArgs e)
        {
            
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
