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
    public partial class Question4 : MaterialForm
    {
        private int cont = 1;
        private readonly MaterialSkinManager materialSkinManager;
        public Question4()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Question4_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void lbR1_MouseDown(object sender, MouseEventArgs e)
        {
            lbR1.DoDragDrop(lbR1.Text, DragDropEffects.Copy | DragDropEffects.Move);
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

        private void lsEn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lsEn_DragDrop(object sender, DragEventArgs e)
        {
            lsEn.Items.Add(e.Data.GetData(DataFormats.Text));
            string data = e.Data.GetData(DataFormats.Text).ToString();
            if (data == "Hello Word") {
                lbR1.Text = "";
            }
            if (data == "I Am Programming")
            {
                lbR2.Text = "";
            }
            if (data == "In A language")
            {
                lbR3.Text = "";
            }
            if (data == "Called Scharp")
            {
                lbR4.Text = "";
            }
            if (data == "I Cam Programming")
            {
                lbR5.Text = "";
            }
            if (data == "Phone Scharp")
            {
                lbR6.Text = "";
            }
            if (cont >= 4) {
                lbR1.Text = "";
                lbR2.Text = "";
                lbR3.Text = "";
                lbR4.Text = "";
                lbR5.Text = "";
                lbR6.Text = "";
            }
            this.cont++;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int x = lsEn.Items.Count;
            int contV = 0;
            for (int i = 0; i < x; i++)
            {
                string item = lsEn.Items[i].ToString();

                if (item == "Hello Word")
                {
                    contV++;
                }
                if (item == "I Am Programming")
                {
                    contV++;
                }
                if (item == "In A language")
                {
                    contV++;
                }
                if (item == "Called Scharp")
                {
                    contV++;
                }
            }
            if (x >= 4) {
                if (contV == 4)
                {
                    Questions.correctas++;
                }
                else {
                    Questions.incorrectas++;
                    Questions.setAnswer(3,false);
                }
                this.Hide();
                timer1.Enabled = false;
                new Question5().Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.run();
            lbTime.Text = Tiempo.getTiempo();
        }
    }
}
