using ES02_MVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES02.Model
{
    public partial class frmModifica : Form
    {
        private clsAlunni alunno;

        public clsAlunni Alunno
        {
            get { return alunno; }
            set { alunno = value; }
        }
        public frmModifica()
        {
            InitializeComponent();
        }

        private void frmModifica_Load(object sender, EventArgs e)
        {
            this.Text = alunno.Cognome + "Dettaglio";

            txtId.Text = alunno.IdAlunno.ToString();
            txtNome.Text = alunno.Nome;
            txtCognome.Text = alunno.Cognome;
            txtData.Text = alunno.DataNascita.ToShortDateString();
            if (alunno.Icdl)
            {
                chkIcdl.Checked = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            alunno.Nome = txtNome.Text;
            alunno.Cognome = txtCognome.Text;
            DateTime data;
            if (!DateTime.TryParse(txtData.Text, out data))
            {
                txtData.Focus();
                MessageBox.Show("La data non è accettabile","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            alunno.DataNascita = data;
            alunno.Icdl = chkIcdl.Checked;
            this.Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
