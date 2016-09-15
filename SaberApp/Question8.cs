using MaterialSkin;
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
    public partial class Question8 : MaterialForm
    {
        private int cont = 1;
        private readonly MaterialSkinManager materialSkinManager;
        public Question8()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void Question8_Load(object sender, EventArgs e)
        {

        }
      
        private void btnNext_Click(object sender, EventArgs e)
        {
            int x = lsEn.Items.Count;
            int contV = 0;
            for (int i = 0; i < x; i++)
            {
                string item = lsEn.Items[i].ToString();

                if (item == "The computer")
                {
                    contV++;
                }
                if (item == "from yesterday")
                {
                    contV++;
                }
                if (item == "turn back")
                {
                    contV++;
                }
                if (item == "will not")
                {
                    contV++;
                }
            }
            if (x >= 4)
            {
                if (contV == 4)
                {
                    Questions.correctas++;
                }
                else
                {
                    Questions.incorrectas++;
                    Questions.setAnswer(3, false);
                }
                this.Hide();
                new Question9().Show();
            }
        }

        private void lbR1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lbR1.DoDragDrop(lbR1.Text, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void lbR2_Click(object sender, EventArgs e)
        {

        }

        private void lbR2_MouseDown(object sender, MouseEventArgs e)
        {
            lbR2.DoDragDrop(lbR2.Text, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void lbR3_MouseDown(object sender, MouseEventArgs e)
        {
            lbR3.DoDragDrop(lbR3.Text, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void lbR4_MouseDown(object sender, MouseEventArgs e)
        {
            lbR4.DoDragDrop(lbR4.Text, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void lbR5_MouseDown(object sender, MouseEventArgs e)
        {
            lbR5.DoDragDrop(lbR5.Text, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void lbR6_MouseDown(object sender, MouseEventArgs e)
        {
            lbR6.DoDragDrop(lbR6.Text, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void lsEn_DragDrop(object sender, DragEventArgs e)
        {
            lsEn.Items.Add(e.Data.GetData(DataFormats.Text));
            string data = e.Data.GetData(DataFormats.Text).ToString();
            if (data == "The computer")
            {
                lbR1.Text = "";
            }
            if (data == "from yesterday")
            {
                lbR2.Text = "";
            }
            if (data == "turn back")
            {
                lbR3.Text = "";
            }
            if (data == "Called  yesterday")
            {
                lbR4.Text = "";
            }
            if (data == "will not")
            {
                lbR5.Text = "";
            }
            if (data == "Computer")
            {
                lbR6.Text = "";
            }
            if (cont >= 4)
            {
                lbR1.Text = "";
                lbR2.Text = "";
                lbR3.Text = "";
                lbR4.Text = "";
                lbR5.Text = "";
                lbR6.Text = "";
            }
            this.cont++;
        }

        private void lsEn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
