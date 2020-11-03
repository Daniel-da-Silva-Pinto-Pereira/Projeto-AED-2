using System.Collections.Generic;

class Cliente{
  public List<Cliente> listaCliente = new List<Cliente>();

  string CNome;
  public string getNome(){
    return CNome;
  }

  string NomeDaRua;
  public string getRua(){
    return NomeDaRua;
  }

  int NúmeroDaRua;
  public int getRuaN(){
    return NúmeroDaRua;
  }

  public Cliente(string a, string b, int c){
    CNome = a;
    NomeDaRua = b;
    NúmeroDaRua = c;
  }
}