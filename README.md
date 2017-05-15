# CSharp_IEnumeratorIEnumerable
IEnumerator e IEnumerable    Em muitas classes e/ou componentes percebemos normalmente que há uma implementação de alguma interface, para entender melhor sobre os motivos que cada interface é implementada, iniciei um estudo a fim de desvendar ou até mesmo abrir nossas mentes quanto ao que se pode fazer. Neste momento falaremos sobre duas interfaces que considero duas dentre as interfaces mais utilizadas pelos programadores na linguagem: a interface IEnumerator e a interface IEnumerable;  No namespace System.Collections temos a interface IEnumerator, esta interface é responsável por nos possibilitar trabalhar com elementos enumeráveis, implementa em sua estrutura o atributo Current  que indica o elemento que se está acessando, e métodos como: bool MoveNext() e void Reset(), estes por sua vez é responsável por encontrar o próximo objeto e ir para o primeiro objeto respectivamente;   No namespace System.Collections temos a interface IEnumerable, esta interface é responsável por informar que qualquer “coisa” que a implementar pode ser enumerável, muitos componentes utiliza essa interface, sua estrutura implementa um método da interface IEnumerator citada anteriormente, este método chama-se GetEnumerator(), agora que já entendemos sobre o que nos permite cada uma das Interfaces, podemos prosseguir.  Para exemplificar o pensamento e a importância destas interfaces vamos falar sobre alguns comandos e/ou componentes presentes em nosso dia-dia;  O uso do foreach, por exemplo, é comumente usado para percorrer Arrays e Collections, mas pode ser usado na estrutura do que se quer percorrer somente se existir implementado a interface IEnumerable;  Um Array, já implementa a interface IEnumerable;  Para uma Coleção podemos usar qualquer classe (class) estrutura (struct) ou Interface que implementa a interface IEnumerable;   Uma IList ou  List também implementam a interface IEnumerable;  Já que agora sabemos de tudo isso, vamos a um exemplo usando a Interface IEnumerable, aplicando com classes, Imaginamos a seguinte situação, temos a classe Pai e a classe Filho, em nosso exemplo a classe Pai terá 3 Filhos de nomes “Reinaldo”, “Ricardo” e “Roberto” ambos com idades de respectivamente: “30”, “28” e “25” anos; A classe Pai deve implementar a interface IEnumerable e o método GetEnumerator(); para que seja possível visualizar os seus objetos Filhos.  Mãos a Obra!!!    Referências  Livro: Profissional C# e a Plataforma .NET 3.5 Curso Completo  PDF: C# School – 14 lessons to get you started with C# e .NET
