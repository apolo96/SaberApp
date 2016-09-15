using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SaberApp
{
    public partial class Login : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Login()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string pw = txtPass.Text.Trim();
            if (userName.Equals("") || pw.Equals(""))
            {


            }
            else {
                string compareUserName = Usuarios.name;
                string comparePw = Usuarios.password;
                if (userName == compareUserName && pw == comparePw)
                {
                    this.Hide();
                    new Question1().Show();
                }
            }
        }
    }
}
