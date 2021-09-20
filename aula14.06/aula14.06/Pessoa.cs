using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14._06
{
    class Pessoa
    {
        //  "Resumo"       

        /*      DECLARAÇÃO:
         *      
         *      public void Set<nome>(<tipo> <nome>)
         *      {
         *          this.<nome> = <nome>;
         *      } 
         *      
         *      public <tipo> Get<nome>()
         *      {
         *          return this.<nome>;
         *      }
         *      
         *   ....................................
         *          
         *          EXEMPLO DE DECLARAÇÃO:
         *          
         *          1 -> "Declaro as variaveis"
         *          
         *          private string nome, cpf;
         *          int idade;
         *          
         *          
         *          2 -> "Depois declaro o objeto em si"
         *          
         *          public Pessoa(string nome, string cpf, int idade)
         *          {
         *              this.nome = nome;
         *              this.cpf = cpf;
         *              this.idade = idade;
         *          }
         *          
         *          3 -> agora vamos para o Set e o Get
         *          
         *          Obrigatoriamente tem que ter um de Set e um Get para cada variavel...
         *          
         *          public void SetNome(string nome)
         *          {
         *              this.nome = nome;
         *              
         *          }
         *          
         *          public GetNome()
         *          {
         *              return this.nome;
         *          }
         *          
         *          
         *      
         */




        private string nome;
        private double[] notas;

        public Pessoa(string nome, double[] notas)
        {
            this.nome = nome;
            this.notas = notas;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }
        public void SetNotas(double[] notas)
        {
            this.notas = notas;
        }

        public double[] GetNotas()
        {
            return this.notas;
        }

    }
    }








   

