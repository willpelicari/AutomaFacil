using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaFacil.Classes
{
    class Automato
    {
        #region Propriedades
        //private ;

        #endregion

        #region Construtor
        public Automato(String transicoes) //passa todas as transacao. primeiro linha depois coluna
        {
            //grava as transicoes para consultas
        }
        #endregion

        #region Metodos Publicos
        public void Processa(int estado, String valor)
        {
            //consulta oque fazer para com os valores recebidos
            if (estado == 1)
            {
                if (valor=="A")
                {

                }
            }
            if (estado == 2)
            {

            }
            if (estado == 3)
            {

            }
            if (estado == 4)
            {

            }

        }
        public bool Validar()
        {
            //valida o automato
            return true;
        }

        public void Executar()
        {
            //executar o automato na frase
            Processa(1, "A");
        }

        #endregion
    }
}
