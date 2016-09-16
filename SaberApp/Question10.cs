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
    public partial class Question10 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Question10()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Question10_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbVolcano.Checked || rbDesert.Checked || rbSnowy.Checked || rbRiver.Checked)
            {
                if (rbRiver.Checked)
                {
                    Questions.correctas++;
                }
                else
                {
                    Questions.incorrectas++;
                    Questions.setAnswer(9, false);
                }
                this.Hide();
                timer1.Enabled = false;
                new Result().Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.run();
            lbTime.Text = Tiempo.getTiempo();
        }
    }
}
