﻿using MaterialSkin;
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
            lbNombre.Text = Usuarios.name;
            lbApellido.Text = Usuarios.lastName;
            lbID.Text = Usuarios.nID;
            lbTiempo.Text = Tiempo.getTiempo();
            lbOk.Text = Questions.correctas.ToString();
            lbNot.Text = Questions.incorrectas.ToString();

        }
    }
}
