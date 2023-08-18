using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevButton
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        int hereket = 5;
        int t = 0;
        int s = 0;
        bool succes = true;

        public Form1()
        {
            InitializeComponent();
        }

        public void MovieTimer(object sender1, EventArgs e1)
        {
            if (succes)
            {
                //saga hereket
                if (s == 0)
                {
                    if (Button1.Left <= this.Width)
                    {
                        Button1.Left += hereket;
                        if (Button1.Left >= this.Width - Button1.Width - 75)
                        {
                            s = 1;
                            Button1.Visible = false; 
                        }
                    }
                }

                //asagi hereket az
                else if (s == 1)
                {
                    if (btnMasinDow1.Top <= this.Height)
                    {
                        btnMasinDow1.Top += hereket;
                        if (btnMasinDow1.Top >= 175)
                        {
                            s = 2;
                            t = 1;
                            btnMasinDow1.Visible = false;
                            btnMasinLeft.Visible = true;
                        }

                    }

                }

                //sola hereket
                else if (t == 1)
                {
                    if (btnMasinLeft.Left <= this.Width)
                    {
                        btnMasinLeft.Left -= hereket;
                        if (btnMasinLeft.Left <= 68)
                        {
                            s = 3;
                            t = 2;
                            btnMasinLeft.Visible = false;
                            btnMasinDow2.Visible = true;
                        }
                    }
                }


                //asagi hereket cox
                else if (s == 3)
                {
                    if (btnMasinDow2.Top <= this.Height)
                    {
                        btnMasinDow2.Top += hereket;
                        if (btnMasinDow2.Top >= 240)
                        {
                            s = 4;
                            btnMasinDow2.Visible = false;
                            btnMasinRight.Visible = true;


                        }

                    }

                }

                //saga hereket son
                if (s == 4)
                {
                    if (btnMasinRight.Left <= this.Width)
                    {
                        btnMasinRight.Left += hereket;
                        if (btnMasinRight.Left >= this.Width - btnMasinRight.Width - 220)
                        {
                            s = 5;

                            btnAdam2.Visible = true;

                        }
                    }
                }

                //saga hereket finish
                if (s == 5)
                {
                    if (btnAdam2.Left <= this.Width)
                    {
                        btnAdam2.Left += hereket;
                        if (btnAdam2.Left >= this.Width - btnAdam2.Width - 100)
                        {
                            s = 6;
                            btnAdam2.Visible = false;

                        }
                    }
                }

                //son
                if (s == 6)
                {
                    Button1.Left += 0;
                    Button1.Visible = false;
                    Button3.Visible = true;
                    lblSucces.Visible = true;
                }

            }




        }

        public void simpleButton2_Click(object sender, EventArgs e)
        {
            Button1.Left += 0;
            Button1.Top += 0;
            succes = false;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            succes = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Button1.Left = 96;
            Button1.Top = 26;
            btnMasinDow1.Left = 508;
            btnMasinDow1.Top = 31;
            btnMasinRight.Visible = false;
            btnMasinLeft.Visible = false;

            btnMasinDow2.Visible = false;
            Button1.Visible = true;

            succes = true;
            s = 0;
        }
    }
}
