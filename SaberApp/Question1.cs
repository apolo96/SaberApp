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
    public partial class Question1 : MaterialForm
    {
        SoundPlayer sound;
        private readonly MaterialSkinManager materialSkinManager;
        public Question1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Question1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                sound = new SoundPlayer(Application.StartupPath + @"\sound\thanks_very_much.wav");
                sound.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string en = txtTrasnlate.Text.Trim();
            en = en.Replace(" ","");
            if (en.Equals(""))
            {
            }
            else {
                if (en.Equals("thanksverymuch"))
                {
                    Questions.correctas++;
                }
                else
                {
                    Questions.setAnswer(0, false);
                    Questions.incorrectas++;
                }
                this.Hide();
                new Question2().Show();
            }
            
        }
    }
}
