﻿using System;


namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas { get; set; }

        public Tabuleiro(int linha, int colunas)
        {
            Linhas = linha;
            Colunas = colunas;
            Pecas = new Peca[linha, colunas];
        }
    }
}
