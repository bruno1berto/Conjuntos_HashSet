using System;
using System.Collections.Generic;

namespace Conjuntos_HashSet {
    class Program {
        static void Main(string[] args) {

            // Declaraçao e instaciação dos objetos HashSets (Conjuntos)
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            HashSet<int> AIntersect = new HashSet<int>();
            HashSet<int> AExcept = new HashSet<int>();
            HashSet<int> AUnion = new HashSet<int>();
            int qtd, cod;

            Console.WriteLine("O professor Joaquim ministra 3 cursos A, B e C.");
            Console.WriteLine();

            // Coleta dos dados 
            Console.Write("Quantos alunos tem o curso A: ");
            qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= qtd; i++) {
                Console.Write("Informe o código do aluno #" + i + ": ");
                cod = int.Parse(Console.ReadLine());
                A.Add(cod);
            }

            Console.WriteLine();
            Console.Write("Quantos alunos tem o curso B: ");
            qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= qtd; i++) {
                Console.Write("Informe o código do aluno #" + i + ": ");
                cod = int.Parse(Console.ReadLine());
                B.Add(cod);
            }

            Console.WriteLine();
            Console.Write("Quantos alunos tem o curso C: ");
            qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= qtd; i++) {
                Console.Write("Informe o código do aluno #" + i + ": ");
                cod = int.Parse(Console.ReadLine());
                C.Add(cod);
            }

            // Setando os valores contido no conjunto A nos objetos q vão demonstrar as propriedades dos Hashsets
            foreach (int x in A) {
                AUnion.Add(x);
                AIntersect.Add(x);
                AExcept.Add(x);
            }
            // Setando a união de A com B e C para calcular o total de alunos do professor
            // OBS: A propriedade Union, exclui as duplicatas contidas em cada conjunto
            AUnion.UnionWith(B);
            AUnion.UnionWith(C);

            // Percorrendo a variável AUnion para calcular o total de alunos
            int totalAlunos=0;
            foreach (int x in AUnion) {
                totalAlunos += 1;
            }

            Console.WriteLine();
            Console.WriteLine("Total de alunos do seu Joaquim é: " + totalAlunos);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Propriedades dos conjuntos");

            // Mostrando as propriedades do obj Hashset
            
            // Propriedade Intersect (Intersecção)
            Console.WriteLine();
            Console.WriteLine("A intersecção B...");
            AIntersect.IntersectWith(B);
            foreach (int x in AIntersect) {
                Console.WriteLine(x);
            }

            // Propriedade Except (Excessão)
            Console.WriteLine();
            Console.WriteLine("A exceção B...");
            AExcept.ExceptWith(B);
            foreach (int x in AExcept) {
                Console.WriteLine(x);
            }

            // Propriedade Union (União) (setada anteriormente)
            Console.WriteLine();
            Console.WriteLine("A união B união C...");
            foreach (int x in AUnion) {
                Console.WriteLine(x);
            }

            // Propriedade Contains (Contém)
            Console.WriteLine();
            Console.WriteLine("Pertence ao Conjunto? ...");
            Console.WriteLine();
            Console.Write("Digite um termo (int): " );
            int termo = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (A.Contains(termo) && B.Contains(termo) && C.Contains(termo)) 
                Console.WriteLine(termo + " pertence ao conjunto A, B e C");
            else if (A.Contains(termo) && B.Contains(termo)) 
                Console.WriteLine(termo + " pertence ao conjunto A e B");
            else if (A.Contains(termo) && C.Contains(termo)) 
                Console.WriteLine(termo + " pertence ao conjunto A e C");
            else if (B.Contains(termo) && C.Contains(termo)) 
                Console.WriteLine(termo + " pertence ao conjunto B e C");
            else
                 Console.WriteLine(termo + " não pertence a nenhum conjunto.");

            Console.ReadLine();

        }
    }
}
