using GameTOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTop.Lib
{
    public class Jogador2 : Ijogador
    {
        private readonly string _Nome;
        public Jogador2(string nome = "Zidanne")
        {
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
