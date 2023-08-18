using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonMovie
{
    public partial class Form1 : Form
    {
       
        int hereket = 10;
        

        int s = 1;
        int m = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void MovieTimer(object sender, EventArgs e)
        {
            if (s == 1)
            {
                if (button1.Left > 0)
                {
                    button1.Left -= hereket;

                    if (button1.Left <= 0)
                    {
                        s = 0;
                    }
                }
            }

            else if (button1.Left <= this.Width)
            {
                button1.Left += hereket;
                if (button1.Left >= this.Width-button1.Width)
                {
                    s = 1;
                }
            }

            //if (m == 1)
            //{
            //    if (button2.Top >= 0)
            //    {
            //        button2.Top += hereket;
            //        if (button2.Top > 254)
            //        {
            //            m = 0;
            //        }

            //    }
            //}
            //else if (button2.Top <= this.Height)
            //{
            //    button2.Top -= hereket;
            //    if (button2.Top >= this.Height-button2.Height)
            //    {
            //        m = 1;
            //    }
            //}


        }


    }
}
