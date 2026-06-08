
class Program {

    static void preencherMatriz(int[,] m) {
        Random r = new Random();

        for (int i = 0; i < m.GetLength(0); i++) {
            for (int j = 0; j < m.GetLength(1); j++)
            
                m[i, j] = r.Next(1, 11);
        }
    }

    static void exibirMatriz(int[,] m) {
        for (int i = 0; i < m.GetLength(0); i++) {
            for (int j = 0; j < m.GetLength(1); j++)

                Console.Write($"{m[i, j]}\t");
            Console.WriteLine();
        }
    }

    static int somaColuna2(int[,] m) {
        int soma = 0;

        for (int i = 0; i < m.GetLength(0); i++)

            soma += m[i, 1];

        return soma;
    }

    static int somaDiagonalPrincipal(int[,] m) {
        int soma = 0;

        for (int i = 0; i < m.GetLength(0); i++)
            soma += m[i, i];

        return soma;
    }

    static int somaElementos(int[,] m) {
        int soma = 0;

        for (int i = 0; i < m.GetLength(0); i++) {

            for (int j = 0; j < m.GetLength(1); j++)

                soma += m[i, j];
        }

        return soma;
    }

    static void Main() {
        int[,] m = new int[3, 3];

        preencherMatriz(m);

        Console.WriteLine("Matriz M:");

        exibirMatriz(m);

        Console.WriteLine($"\nSoma da coluna 2: {somaColuna2(m)}");
        Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal(m)}");
        Console.WriteLine($"Soma de todos os elementos: {somaElementos(m)}");
    }
}