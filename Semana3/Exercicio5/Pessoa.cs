namespace System;
public class Pessoa
{
    private string nome;
    private int altura;

    public Pessoa(string nome, int altura){
        this.nome = nome;
        this.altura = altura;
    }
    public int getAltura(){
        return altura;
    }

}
