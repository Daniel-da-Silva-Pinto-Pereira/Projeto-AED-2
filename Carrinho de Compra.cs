using System.Collections.Generic;

class Carrinho{
  string NomeDoCliente, NomeDoProduto;
  int Quantidade;
  double Valor;
  public List<Carrinho> listaCar = new List<Carrinho>();

  public string getCliente(){
    return NomeDoCliente;
  }

  public string getProduto(){
    return NomeDoProduto;
  }

  public int getQuantidade(){
    return Quantidade;
  }

  public double getValor(){
    return Valor;
  }

  public Carrinho(string n, string p, int q, double v){
    NomeDoCliente = n;
    NomeDoProduto = p;
    Quantidade = q;
    Valor = v;
  }
}