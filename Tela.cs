class Tela
{

    public Tela()
    {
        Console.Clear();
    }


    public void montarTela(int ci, int li, int cf, int lf)
    {

        int linha, coluna;
        this.limparArea(ci, li, cf, lf);


        for (coluna = li; coluna <= cf; coluna++)
        {
            Console.SetCursorPosition(coluna, li);
            Console.Write("-");

            Console.SetCursorPosition(coluna, lf);
            Console.Write("-");
        }

        for (linha = li; linha <= lf; linha++)
        {
            Console.SetCursorPosition(ci, linha);
            Console.Write("|");

            Console.SetCursorPosition(cf, linha);
            Console.Write("|");
        }

        Console.SetCursorPosition(ci, li); Console.Write("+");
        Console.SetCursorPosition(ci, lf); Console.Write("+");
        Console.SetCursorPosition(cf, li); Console.Write("+");
        Console.SetCursorPosition(cf, lf); Console.Write("+");
    }

    public void limparArea(int ci, int li, int cf, int lf)
    {
        int linha, coluna;

        for (coluna = ci; coluna <= cf; coluna++)
        {
            for (linha = li; linha <= lf; linha++)
            {
                Console.SetCursorPosition(coluna, linha);
                Console.Write(" ");
            }
        }
    }

    public void montarLinhaHor(int linha, int ci, int cf)
    {
        int coluna;
        for (coluna = ci; coluna <= cf; coluna++)
        {
            Console.SetCursorPosition(coluna, linha);
            Console.Write("-");
        }
        Console.SetCursorPosition(ci, linha); Console.Write("+");
        Console.SetCursorPosition(cf, linha); Console.Write("+");
    }

    public void centralizar(int linha, int ci, int cf, string msg)
    {
        int coluna;
        coluna = ci + (cf - ci - msg.Length) / 2;
        Console.SetCursorPosition(coluna, linha);
        Console.Write(msg);
    }

    public void montarTelaGeral()
    {
        this.montarTela(0, 0, 79, 24);
        this.montarLinhaHor(2, 0, 79);
        this.centralizar(1, 0, 79, "papelaria do felipe");
    }

    public string mostrarMenu(int ci, int li, List<string> opcoes)
    {
        string op;
        int coluna, linha, cf, lf;

        lf = li + opcoes.Count + 2;
        cf = ci + opcoes[0].Length + 1;

        this.montarTela(ci, li, cf, lf);

        coluna = ci + 1;
        linha = li + 1;
        foreach (string item in opcoes)
        {
            Console.SetCursorPosition(coluna, linha);
            Console.Write(item);
            linha++;
        }
        Console.SetCursorPosition(coluna, linha);
        Console.Write("Opcao : ");
        op = Console.ReadLine();

        return op;
    }
}