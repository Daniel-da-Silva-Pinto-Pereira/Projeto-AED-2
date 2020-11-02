using System.Collections.Generic;

class Carrinho{
  string nomeCliente, nomeProduto;
  int quantidade;
  double valor;
  public List<Carrinho> listaCar = new List<Carrinho>();

  public string getCliente(){
    return nomeCliente;
  }

  public string getProduto(){
    return nomeProduto;
  }

  public int getQuantidade(){
    return quantidade;
  }

  public double getValor(){
    return valor;
  }

  public Carrinho(string n, string p, int q, double v){
    nomeCliente = n;
    nomeProduto = p;
    quantidade = q;
    valor = v;
  }
}