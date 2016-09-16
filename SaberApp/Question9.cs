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
    public partial class Question9 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Question9()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Question9_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool verify = cbR1.SelectedIndex == -1 || cbR2.SelectedIndex == -1 ||
                cbR3.SelectedIndex == -1 || cbR4.SelectedIndex == -1;
            if (verify != true)
            {
                bool x = cbR1.SelectedIndex == 3 && cbR2.SelectedIndex == 0 && cbR3.SelectedIndex == 1 && cbR4.SelectedIndex == 2;
                if (x == true)
                {
                    Questions.correctas++;
                }
                else
                {
                    Questions.incorrectas++;
                    Questions.setAnswer(8, false);
                }
                this.Hide();
                timer1.Enabled = false;
                new Question10().Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.run();
            lbTime.Text = Tiempo.getTiempo();
        }
    }
}
