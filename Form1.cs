using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            Cadastro cadastro = new Cadastro(txtNome.Text, txtValor.Text);
            MessageBox.Show(cadastro.Mensagem);
        }
    }
}
