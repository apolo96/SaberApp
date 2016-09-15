using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberApp
{
    public partial class Question2 : MaterialForm
    {
        SoundPlayer sound;
        private readonly MaterialSkinManager materialSkinManager;
        public Question2()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Question2_Load(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbAir.Checked || rbPhone.Checked || rbCar.Checked || rbBall.Checked) {
                if (rbAir.Checked)
                {
                    Questions.correctas++;
                }
                else {
                    Questions.incorrectas++;
                    Questions.setAnswer(1,false);
                }
                this.Hide();
                new Question3().Show();
            }
        }
    }
}
