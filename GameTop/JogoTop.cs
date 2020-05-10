using System;
using System.Collections.Generic;
using System.Text;

namespace GameTop
{
    class JogoTop
    {
        public readonly Ijogador _jogadorA;
        public readonly Ijogador _jogadorB;
        public JogoTop(Ijogador jogadorA, Ijogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }

        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passe());
            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n");
            //
            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());

        }

    }
}
