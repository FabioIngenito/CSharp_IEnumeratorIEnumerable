using System.Collections;

namespace caIEnumeratorIEnumerable
{
    public class clsPai : clsAtributos, IEnumerable
    {
        //Sytem.Array implementa o IEnumerator
        private clsFilho[] vetorClasse = new clsFilho[3];

        #region "Construtor"
        public clsPai()
        {
            vetorClasse[0] = new clsFilho(30, "Reinaldo");
            vetorClasse[1] = new clsFilho(28, "Ricardo");
            vetorClasse[2] = new clsFilho(25, "Roberto");
        }
        #endregion

        //Implementando o método GetEnumerator(), 
        //essencial para poder percorrer subitens em um "foreach"
        public IEnumerator GetEnumerator()
        {
            //Como vetorClasse é um Array e o mesmo implementa IEnumerator
            //o mesmo possui o método "IEnumerator GetEnumerator();"
            return vetorClasse.GetEnumerator();
        }
    }
}