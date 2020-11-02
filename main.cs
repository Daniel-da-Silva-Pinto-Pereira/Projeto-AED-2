using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    string nome, rua, pagar, continuar = "S";
    int numeroRua, cp, quni, quniOrigin;
    double ValorTotal = 0; 
    Carrinho car = new Carrinho("NomeCliente", "NomeProduto", 1, 10);
    Cliente cli = new Cliente("Nome", "Rua", 0);
    Loja JJ = new Loja();

    Console.Write("Informe o seu Nome: ");
    nome = Console.ReadLine();
    Console.Write("Informe o Nome da sua Rua: ");
    rua = Console.ReadLine();
    Console.Write("Informe o Número da Casa: ");
    numeroRua = int.Parse(Console.ReadLine());

    cli = new Cliente(nome, rua, numeroRua);
    cli.listaCliente.Add(cli);

    Console.WriteLine();
    for(int i = 0; i < JJ.descricao.Count; i++){
      Console.WriteLine("Codigo produto: "+ i +" - Nome produto: "+ JJ.descricao[i] +" / Preço : R$"+ JJ.preco[i] +" / Unidade disponível: "+ JJ.quanti[i]);
    }

    while(continuar == "S"){
      Console.Write("Insira o codigo do produto que deseja comprar: ");
      cp = int.Parse(Console.ReadLine());
      Console.Write("Insira quantas unidades deseja comprar: ");
      quni = int.Parse(Console.ReadLine());

      if(quni <= JJ.quanti[cp]){
        quniOrigin = JJ.quanti[cp];
        JJ.quanti[cp] = JJ.quanti[cp] - quni;
        ValorTotal = ValorTotal + (quni*JJ.preco[cp]);

        car = new Carrinho(cli.getNome(), JJ.descricao[cp], quni, quni*JJ.preco[cp]);
        car.listaCar.Add(car);
      } else{
        Console.WriteLine("A quantidade que tentou inserir é maior que a presente em estoque!");
      }

      Console.WriteLine("Continuar comprando S/N?");
      continuar = Console.ReadLine();

      if(continuar == "N"){
        Console.WriteLine("Deseja gerar um boleto para efetuar o pagamento S/N?");
        Console.WriteLine("Valor total: R$"+ ValorTotal);
        pagar = Console.ReadLine();

        if(pagar == "S"){

          Console.WriteLine("Pressione qualquer tecla para ver a lista de produtos adquiridos");
          Console.ReadKey();

          for(int i = 0; i < car.listaCar.Count; i++){
            Console.WriteLine("Cliente: "+ car.listaCar[i].getCliente() +" / Produto: "+ car.listaCar[i].getProduto() +" / Quantidade: "+ car.listaCar[i].getQuantidade() +" / Total: "+ car.listaCar[i].getValor());
          }
        }
      }

    }

  }
}