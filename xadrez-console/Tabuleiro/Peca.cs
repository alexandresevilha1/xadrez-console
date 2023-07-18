namespace tabuleiro
{
    public class Peca
    {
        public Posicao posicao { get; set;  }
        public Cor cor { get; set; }
        public int qteMovimentos { get; protected set; } //protected set para permitir somente a própia classe e subclasses de acessar
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
    }
}
