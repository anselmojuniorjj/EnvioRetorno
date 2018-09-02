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
    public partial class frm2 : Form
    {
        public string nome { set; get; }
      
        public frm2(string nome)
        {
            InitializeComponent();
            txt1.Text = nome;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt1.Text == null)
                nome = null;
            nome = txt1.Text;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            nome = null;
            this.Close();
        }
    }
}
