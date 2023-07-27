using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14Objetos
{
    internal class Pessoa
    {

        // ATRIBUTOS


        // SE NÃO É PÚBLICO ELA É PRIVADO;

        // CASO NÃO APAREÇA O NOME PUBLIC OU PRIVADA, ELA FICA PRIVATE. 
        
        
        
        private string nome;
        private int idade;
        public bool negativado = false;
        public Endereco endereco;


        // CONSTRUTOR

        public Pessoa( string nome, int idade, string rua, string bairro, string cidade )
        
        {

            this.nome = nome;
            this.idade = idade;
            this.endereco = new Endereco( rua, bairro, cidade);
            
        
        } 



       // MÉTODOS

        public void Mostra() 
        
        {
            Console.WriteLine($" Eu sou o {nome} e tenho {idade} anos");


        }

    }
}
