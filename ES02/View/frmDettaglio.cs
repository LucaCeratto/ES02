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

namespace ES02.View
{
    public partial class frmDettaglio : Form
    {
        clsAlunni alunno = new clsAlunni();

        public frmDettaglio(clsAlunni _alunno)
        {
            InitializeComponent();
            alunno = _alunno;
        }

        public frmDettaglio()
        {
            InitializeComponent();
        }

        private void frmDettaglio_Load(object sender, EventArgs e)
        {
            this.Text = alunno.Cognome + "Dettaglio";

            txtId.Text = alunno.IdAlunno.ToString();
            txtNome.Text = alunno.Nome;
            txtCognome.Text = alunno.Cognome;
            txtData.Text = alunno.DataNascita.ToShortDateString();
            if(alunno.Icdl)
            {
                chkIcdl.Checked = true;
            }
        }
    }
}
