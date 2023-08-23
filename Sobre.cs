using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Clientes
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void btnLinkdin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/murilo-gaeta-bottaro/");
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:murilo_gaeta@hotmail.com");
        }
    }
}
