using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.View
{
    public partial class Login : Form
    {
        String usuario = "";
        String password = "";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == usuario && txt_contraseña.Text == password)
            {
                Menu Menu = new Menu();
                this.Hide();
                Menu.Show();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
