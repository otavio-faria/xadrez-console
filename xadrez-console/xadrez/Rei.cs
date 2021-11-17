﻿using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            if (cor == Cor.Branca)
            {
                return "\u265A";

            }
            return "\u2654";
        }
    }
}
