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

            clsAlunniController alunniCotroller;
            clsAlunni alunni;
        }
    }
}
