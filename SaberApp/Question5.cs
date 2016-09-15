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
    public partial class Question5 : MaterialForm
    {

        SoundPlayer sound;
        private readonly MaterialSkinManager materialSkinManager;
        public Question5()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Question5_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                sound = new SoundPlayer(Application.StartupPath + @"\sound\i_dont_understand.wav");
                sound.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string traduccion = txtTrasnlate.Text.Trim();
            traduccion = traduccion.Replace(" ", "");
            if (traduccion.Equals("")) {
            }else
            {
                if (traduccion.Equals("noentiendo"))
                {
                    Questions.correctas++;
                }
                else
                {
                    Questions.setAnswer(0, false);
                    Questions.incorrectas++;
                }
                this.Hide();
                timer1.Enabled = false;
                new Question6().Show();
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.run();
            lbTime.Text = Tiempo.getTiempo();
        }
    }
}
