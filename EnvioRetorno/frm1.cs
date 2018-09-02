using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioRetorno
{
    public partial class frm1 : Form
    {
        string nome = null;

        public frm1()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            if (lbl1 != null)
                nome = lbl1.Text;

            frm2 formulario = new frm2(nome);
            formulario.ShowDialog();

            if (formulario.nome != null)
                lbl1.Text = formulario.nome;
        }
    }
}
