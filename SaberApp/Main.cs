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
    public partial class Main : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Main()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string lastName = txtName.Text.Trim();
            string ID = txtID.Text.Trim();
            string password = txtPw.Text.Trim();
            if (name.Equals("") || lastName.Equals("") || ID.Equals("") || password.Equals(""))
            {
                lbAlert.Text = "Llena los campos, please";
            }
            else {
                Usuarios.name = name;
                Usuarios.lastName = lastName;
                Usuarios.nID = ID;
                Usuarios.password = password;
                this.Hide();
                new Login().Show();
            }
        }
    }
}
