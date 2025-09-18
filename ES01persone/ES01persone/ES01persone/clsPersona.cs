using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES01persone
{
    public class clsPersona
    {
        //campi della classe - caratteristiche
        //tutti privati ==> incapsulamento, datahiding
        private string cognome;
        private string nome;
        private DateTime dataNascita;

        //property per accessi in lettura e scrittura
        public string Cognome
        {
            get  // per accesso in lettura
            { 
                return cognome;
            }
            set  // per accesso il scrittura
            {
                if (!controllaStringa(value))
                    throw new Exception("COGNOME NON VALIDO");
                else
                   cognome = value;
            }
        }
        public string Nome
        {
            get  // per accesso in lettura
            {
                return nome;
            }
            set  // per accesso il scrittura
            {
                if (!controllaStringa(value))
                    throw new Exception("NOME NON VALIDO");
                else
                    nome = value;
            }
        }
        public DateTime DataNascita
        {
            get // per accessi in lettura
            { return dataNascita; }
            set //per accessi in scrittura 
            {
                string msg = "";
                try
                {
                    dataNascita = Convert.ToDateTime(value);
                    if (dataNascita > DateTime.Now)
                        msg = "si accettano date fino ad oggi";
                }
                catch (Exception)
                {
                    msg = "data non valida";
                }
                if (msg!="")
                    throw new Exception(msg);
            }
        }
        /// <summary>
        /// CONTROLLA CHE I CARATTERI del parametro SIANO LETTERE 
        /// DELL'ALFABETO, SPAZO, APOSTROFO
        /// </summary>
        /// <param name="nome - cognome"></param>
        /// <returns>true se corretto</returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool controllaStringa(string nominativo)
        {
            bool ok = true;
            //compito...

            return ok;
        }

        //metodi della classe
        public string visualizza()
        {//non ha parametri perchè utilizza i campi della classe
            string s = cognome + " " + nome + " " + " nata/o il " + dataNascita;
            return s;
        }
    }
}
