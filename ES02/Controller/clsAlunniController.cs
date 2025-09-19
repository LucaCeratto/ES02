using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using ES02_MVC.Model;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace ES02_MVC.Controller
{
    public class clsAlunniController
    {
        private string nomeFile;

        public string NomeFile
        {
            get
            {
                return nomeFile;
            }
            set
            {
                nomeFile = value;
            }
        }

        public clsAlunniController(string _nomeFile)
        {
            NomeFile = _nomeFile;
        }

        public List<clsAlunni> LeggiAlunni()
        {
            List<clsAlunni> lista = new List<clsAlunni>();
            if(File.Exists(NomeFile))
            {
                StreamReader sr = new StreamReader(NomeFile);
                string[] vet = sr.ReadLine().Split(';');
                while(!sr.EndOfStream)
                {
                    clsAlunni Alunno = new clsAlunni();
                    Alunno.IdAlunno = Convert.ToInt32(vet[0]);
                    Alunno.Nome = vet[1];
                    Alunno.Cognome = vet[2];
                    Alunno.DataNascita = Convert.ToDateTime(vet[3]);
                    Alunno.Icdl=Convert.ToBoolean(vet[4]);

                    lista.Add(Alunno);
                }

                sr.Close();
            }
            return lista;
        }

        public void scriviAlunni(List<clsAlunni> lista)
        {
            StreamWriter sw = new StreamWriter(NomeFile);
            sw.WriteLine("id;nome;cognome;dataDiNascita;icdl");
            sw.Close();

            foreach (clsAlunni alunno in lista)
            {
                scriviAlunno(alunno, NomeFile);
                //alunni = alunno.IdAlunno.ToString() + ";" + alunno.Nome + ";" + alunno.Cognome + ";" + alunno.DataNascita.ToShortDateString() + ";" + alunno.Icdl.ToString();
                //sw.WriteLine(alunni);
            }
        }

        public void scriviAlunno(clsAlunni alunno, string NomeFile)
        {
            string alunni;
            StreamWriter sw = new StreamWriter(NomeFile,true);
            alunni = alunno.IdAlunno.ToString() + ";" + alunno.Nome + ";" + alunno.Cognome + ";" + alunno.DataNascita.ToShortDateString() + ";" + alunno.Icdl.ToString();
            sw.WriteLine(alunni);
            sw.Close ();
        }
    }
}