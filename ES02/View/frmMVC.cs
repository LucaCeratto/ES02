using ES02.View;
using ES02_MVC.Controller;
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

namespace ES02_MVC.View
{
    public partial class frmMVC : Form
    {
        public frmMVC()
        {
            InitializeComponent();
        }

        string fileAlunni = "alunni.txt";


        private void frmMVC_Load(object sender, EventArgs e)
        {
            //gestire gli alunni di una scuola mediante MVC con visualizzazione
            //Master/Detail dove l'inserimento e la modifica dei dati verrà gestita con
            //tecnologia multi form e passando parametri tra loro

            clsAlunniController alunniCotroller = new clsAlunniController(fileAlunni);
            clsAlunni alunni;

            dgv.DataSource = alunniCotroller.LeggiAlunni();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                frmDettaglio f = new frmDettaglio(clsAlunniController.datiAlunno(e.RowIndex));
                //MessageBox.Show("Prima");
                f.ShowDialog();
                //MessageBox.Show("Dopo");
            }
        }
    }
}
