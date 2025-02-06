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
        }

        private void bunifuCustomLabel1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
