class Tela
{

    public void montarTela(int li, int lf, int ci, int cf)
    {

        int linha, coluna;
        this.limparArea(ci, cf, li, lf);


        for (linha = li; linha <= lf; linha++)
        {
            Console.SetCursorPosition(linha, ci);
            Console.Write("-");

            Console.SetCursorPosition(linha, cf);
            Console.Write("-");
        }

        for (coluna = ci; coluna <= cf; coluna++)
        {
            Console.SetCursorPosition(li, coluna);
            Console.Write("|");

            Console.SetCursorPosition(lf, coluna);
            Console.Write("|");
        }
    }

    public void limparArea(int ci, int cf, int li, int lf)
    {
        int lin, col;

        for (col = ci; col <= cf; col++)
        {
            for (lin = li; lin <= lf; lin++)
            {
                Console.SetCursorPosition(col, lin);
                Console.Write(" ");
            }
        }
    }

    public void montarLinhaHor(int lin, int ci, int cf)
    {
        int col;
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, lin);
            Console.Write("-");
        }
        Console.SetCursorPosition(ci, lin); Console.Write("+");
        Console.SetCursorPosition(cf, lin); Console.Write("+");
    }

    public void centralizar(int lin, int ci, int cf, string msg)
    {
        int col;
        col = ci + (cf - ci - msg.Length) / 2;
        Console.SetCursorPosition(col, lin);
        Console.Write(msg);
    }

    public void montarTelaGeral()
    {
        this.montarTela(0, 79, 0, 24);
        this.montarLinhaHor(2, 0, 79);
        this.centralizar(1, 0, 79, "papelaria do felipe");
    }




    public string mostrarMenu(int ci, int li, List<string> opcoes)
    {
        string op;
        int col, lin;
        this.montarTela(li, 20, ci, 10);

        col = ci + 1;
        lin = li + 1;
        foreach (string item in opcoes)
        {
            Console.SetCursorPosition(col, lin);
            Console.Write(item);
            lin++;
        }
        Console.SetCursorPosition(col, lin);
        Console.Write("Opcao : ");
        op = Console.ReadLine();

        return op;
    }
}