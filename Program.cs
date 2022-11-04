Tela tela = new Tela();
CRUD crud = new CRUD(tela);
List<string> menu = new List<string>();
string opcao;

menu.Add("1 - contas    ");
menu.Add("2 - estoque   ");
menu.Add("3 - financeiro");
menu.Add("0 - sair      ");

while(true){

    tela.montarTelaGeral();
    tela.montarLinhaHor(2,0,79);
    tela.centralizar(1,0,79,"Papelaria do felipe");
    opcao = tela.mostrarMenu(4,5,menu);

    if(opcao == "0"){
        break;
    }
}