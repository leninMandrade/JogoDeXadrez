using System;

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Cosicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao cosicao, Cor cor, Tabuleiro tab)
        {
            Cosicao = cosicao;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
