using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caIEnumeratorIEnumerable
{
    public class clsAtributos
    {
        #region "Atributos"
        private int idade;
        private string nome;
        #endregion

        #region "Propriedades#
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion
    }
}
