using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES02_MVC.Model
{
    public class clsAlunni
    {
        private int idAlunno;
        private string nome;
        private string cognome;
        private DateTime dataDiNascita;
        private bool icdl;

        public int IdAlunno
        {
            get
            {
                return idAlunno;
            }
            set
            {
                idAlunno = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return cognome;
            }
            set
            {
                cognome = value;
            }
        }

        public DateTime DataNascita
        {
            get
            {
                return dataDiNascita;
            }
            set
            {
                dataDiNascita = value;
            }
        }

        public bool Icdl
        {
            get
            {
                return icdl;
            }
            set
            {
                icdl = value;
            }
        }
    }
}
