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
    public partial class Error : Form
    {
        public string Mensaje;
        public string NumError;

        public Error()
        {
            InitializeComponent();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            this.Lbl_Mensaje.Text = Mensaje;
            this.Text = NumError;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
