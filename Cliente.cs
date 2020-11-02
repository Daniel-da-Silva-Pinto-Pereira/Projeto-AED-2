using System.Collections.Generic;

class Cliente{
  public List<Cliente> listaCliente = new List<Cliente>();

  string cNome;
  public string getNome(){
    return cNome;
  }

  string nomeRua;
  public string getRua(){
    return nomeRua;
  }

  int numeroRua;
  public int getRuaN(){
    return numeroRua;
  }

  public Cliente(string a, string b, int c){
    cNome = a;
    nomeRua = b;
    numeroRua = c;
  }
}