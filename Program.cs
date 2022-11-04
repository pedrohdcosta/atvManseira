Tela tela = new Tela();
CRUD crud = new CRUD(tela);
List<string> menu = new List<string>();
string opcao;

menu.Add("1 - contas    ");
menu.Add("2 - estoque ");
menu.Add("3 - financeiro");
menu.Add("4 - configs");
menu.Add("0 - sair      ");

while(true){

    tela.montarTelaGeral();
    opcao = tela.mostrarMenu(2,3,menu);

    if(opcao == "0"){
        break;
    }
    if(opcao == "1"){
        crud.controleCRUD();
    }
    if(opcao == "2"){

    }
    if(opcao == "3"){

    }
    if(opcao == "4"){
        crud.CRUDconfig();
    }
}
Console.Clear();