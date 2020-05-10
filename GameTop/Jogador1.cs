using System;
using System.Collections.Generic;
using System.Text;

namespace GameTop
{
    class Jogador1 : Ijogador
    {
        private readonly string _Nome;
        

        public  Jogador1(string nome = "Ronaldo"){
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{ _Nome} chutou \n";
        }

        public string Corre()
        {
            return $"{ _Nome} está correndo  \n";
        }

        public string Passe()
        {
            return $"{ _Nome} está passando  \n";
        }
    }
}
