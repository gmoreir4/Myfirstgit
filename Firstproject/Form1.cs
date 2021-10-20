using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firstproject {
    public partial class Inicio : Form {
        public Inicio() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {

        }

        private void SalvarClick(object sender, EventArgs e) 
        {
            saveFileDialog1.ShowDialog();
        }

        private void SalvarOK(object sender, CancelEventArgs e) 
        {
            string Caminho = saveFileDialog1.FileName;
        }
    }
}
