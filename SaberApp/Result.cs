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
    public partial class Result : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Result()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Result_Load(object sender, EventArgs e)
        {
            int ok = 0;
            int not = 0;
            lbNombre.Text = Usuarios.name;
            lbApellido.Text = Usuarios.lastName;
            lbID.Text = Usuarios.nID;
            lbTiempo.Text = Tiempo.getTiempo();
            //lbOk.Text = Questions.correctas.ToString();
            //lbNot.Text = Questions.incorrectas.ToString();
            for (int x = 0; x < Questions.answer.Length;x++) {
                if (Questions.answer[x])
                {
                    if (x == 0)
                    {
                        lbR1.Text = "Pregunta " + (x + 1) + " CORRECTA";
                    }
                    if (x == 1)
                    {
                        lbR2.Text = "Pregunta " + (x + 1) + " CORRECTA";
                    }
                    if (x == 2)
                    {
                        lbR3.Text = "Pregunta " + (x + 1) + " CORRECTA ";
                    }
                    if (x == 3)
                    {
                        lbR4.Text = "Pregunta " + (x + 1) + " CORRECTA";
                    }
                    if (x == 4)
                    {
                        lbR5.Text = "Pregunta " + (x + 1) + " CORRECTA";
                    }
                    if (x == 5)
                    {
                        lbR6.Text = "Pregunta " + (x + 1) + " CORRECTA";
                    }
                    if (x == 6)
                    {
                        lbR7.Text = "Pregunta " + (x + 1) + " CORRECTA";
                    }
                    if (x == 7)
                    {
                        lbR8.Text = "Pregunta " + (x + 1) + " CORRECTA ";
                    }
                    if (x == 8)
                    {
                        lbR9.Text = "Pregunta " + (x + 1) + " CORRECTA  ";
                    }
                    if (x == 9)
                    {
                        lbR10.Text = "Pregunta " + (x + 1) + " CORRECTA ";
                    }
                    ok++;

                }
                else {
                    if (x == 0)
                    {
                        lbR1.Text = "Pregunta " + (x + 1) + " INCORRECTA  ";
                    }
                    if (x == 1)
                    {
                        lbR2.Text = "Pregunta " + (x + 1) + " INCORRECTA  ";
                    }
                    if (x == 2)
                    {
                        lbR3.Text = "Pregunta " + (x + 1) + " INCORRECTA  ";
                    }
                    if (x == 3)
                    {
                        lbR4.Text = "Pregunta " + (x + 1) + " INCORRECTA  ";
                    }
                    if (x == 4)
                    {
                        lbR5.Text = "Pregunta " + (x + 1) + " INCORRECTA  ";
                    }
                    if (x == 5)
                    {
                        lbR6.Text = "Pregunta " + (x + 1) + " INCORRECTA  ";
                    }
                    if (x == 6)
                    {
                        lbR7.Text = "Pregunta " + (x + 1) + " INCORRECTA  ";
                    }
                    if (x == 7)
                    {
                        lbR8.Text = "Pregunta " + (x + 1) + " INCORRECTA  ";
                    }
                    if (x == 8)
                    {
                        lbR9.Text = "Pregunta " + (x + 1) + " INCORRECTA  ";
                    }
                    if (x == 9)
                    {
                        lbR10.Text = "Pregunta " + (x + 1) + " INCORRECTA  ";
                    }
                    not++;
                }
                
            }
            lbOk.Text = ok.ToString();
            lbNot.Text = not.ToString();
        }
    }
}
