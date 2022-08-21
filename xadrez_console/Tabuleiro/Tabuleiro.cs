using System;


namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linha, int colunas)
        {
            Linhas = linha;
            Colunas = colunas;
            Pecas = new Peca[linha, colunas];
        }

        public Peca Peca(int linha, int coluna) //obter uma peça.
        {
            return Pecas[linha, coluna];
        }

        public Peca Peca(Posicao pos) //obter uma peça.
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos) //Pega uma peça obtida, e aplica em uma posição.
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public bool PosicaoValida(Posicao pos) //verifica se a posição onde estamos tentando inserir uma peça não excede os limites de uma matriz.
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos) //Se o local onde estamos tentando inserir uma peça exceder os limites da matriz, o programa lança uma exceção.
        {
            if (PosicaoValida(pos) == false) // possível correção de !
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
        public bool ExistePeca(Posicao pos) //Método que verifica se existe uma peça em determinada posição.
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }
    }
}
