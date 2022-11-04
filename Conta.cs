class Conta
{

    public static int quantContas = 0;

    public string id;
    public string cargo;
    public string titular;

    public Conta(string id, string cargo, string titular)
    {
        this.id = id;
        this.cargo = cargo;
        this.titular = titular;
        quantContas++;
    }

    public string mostrarInfos()
    {
        string texto = "";

        texto += "id " + this.id;
        texto += "do titular " + this.titular;
        texto += "que pertence ao cargo de " + this.cargo;

        return texto;
    }
}