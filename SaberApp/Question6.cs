﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberApp
{
    public partial class Question6 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Question6()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Question6_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbBoy.Checked || rbPolice.Checked || rbFire.Checked || rbOld.Checked)
            {
                if (rbFire.Checked)
                {
                    Questions.correctas++;
                }
                else
                {
                    Questions.incorrectas++;
                    Questions.setAnswer(5, false);
                }
                this.Hide();
                timer1.Enabled = false;
                new Question7().Show();
            }
        }

        private void rbFire_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOld_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPolice_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.run();
            lbTime.Text = Tiempo.getTiempo();
        }
    }
}
