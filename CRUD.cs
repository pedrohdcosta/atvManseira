class CRUD
{

    List<Conta> DBcontas = new List<Conta>();
    Tela tela;
    string id;
    string titular;
    string cargo;
    int posicao;

    public CRUD(Tela t)
    {
        this.tela = t;

        this.DBcontas.Add(new Conta("123", "desenvolvedor", "pedro"));
        this.DBcontas.Add(new Conta("456", "gerente", "edu"));
    }

    public void montarTela(int ci, int li, int cf, int lf, int op)
    {
        this.tela.montarTela(ci, li, cf, lf);
        this.tela.montarLinhaHor(li + 2, ci, cf);
        if(op == 1){
            this.telaContas(ci,li,cf,lf);
        }
    }

    public int  telaContas(int ci, int li, int cf, int lf)
    {
        this.tela.centralizar(li + 1, ci, cf, "Contas Registradas");
        Console.SetCursorPosition(11, 8);
        Console.Write("Id :");
        Console.SetCursorPosition(11, 9);
        Console.Write("Cargo :");
        Console.SetCursorPosition(11, 10);
        Console.Write("Titular :");

        return 1;
    }

    public void controleCRUD()
    {
        while (true)
        {
            this.montarTela(5, 5, 70, 15, 1);
            Console.SetCursorPosition(21, 8);
            this.id = Console.ReadLine();
            if (this.id == "")
            {
                break;
            }
            bool found = false;
            int i;

            for (i = 0; i < this.DBcontas.Count; i++)
            {
                if (this.DBcontas[i].id == this.id)
                {
                    found = true;
                    this.posicao = i;
                    break;
                }
            }

            if (found)
            {
                Console.SetCursorPosition(21, 9);
                Console.Write(this.DBcontas[this.posicao].cargo);
                Console.SetCursorPosition(21, 10);
                Console.Write(this.DBcontas[this.posicao].titular);
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(21, 9);
                Console.Write("Conta nao registrada");

                Console.SetCursorPosition(21, 12);
                Console.Write("Deseja registrar (S/N):  ");
                string resp;
                resp = Console.ReadLine();

                if (resp.ToUpper() == "S")
                {
                    this.tela.limparArea(21, 9, 69, 9);

                    Console.SetCursorPosition(21, 9);
                    this.cargo = Console.ReadLine();

                    Console.SetCursorPosition(21, 10);
                    this.titular = Console.ReadLine();

                    Console.SetCursorPosition(21, 12);
                    Console.Write("Confirmar o registro (S/N) : ");
                    resp = Console.ReadLine();

                    if (resp.ToUpper() == "S")
                    {
                        this.DBcontas.Add(new Conta(this.id, this.cargo, this.titular));
                    }
                }
            }
        }
    }

    public void CRUDconfig()
    {
        while (true)
        {
        }
    }
}