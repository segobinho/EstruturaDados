using Domain.Estruturas;

namespace Tests
{
    public class PilhaDinamicaTests
    {
        [Fact]
        public void Empilhar()
        {
            var pilha = new PilhaDinamica();

            pilha.Empilhar(10);

            Assert.Equal(10, pilha.Topo());
        }

        [Fact]
        public void EmpilharVarios()
        {
            var pilha = new PilhaDinamica();

            pilha.Empilhar(10);
            pilha.Empilhar(20);
            pilha.Empilhar(30);

            Assert.Equal(30, pilha.Topo());
        }

        [Fact]
        public void Desempilhar()
        {
            var pilha = new PilhaDinamica();

            pilha.Empilhar(10);
            pilha.Empilhar(20);

            var removido = pilha.Desempilhar();

            Assert.Equal(20, removido);
            Assert.Equal(10, pilha.Topo());
        }

        [Fact]
        public void PilhaVaziaAodesempilhar()
        {
            var pilha = new PilhaDinamica();

            pilha.Empilhar(10);

            pilha.Desempilhar();

            Assert.Null(pilha.Topo());
        }

        [Fact]
        public void RetornarNullAoDesempilhar()
        {
            var pilha = new PilhaDinamica();

            var removido = pilha.Desempilhar();

            Assert.Null(removido);
        }

        [Fact]
        public void RetornarNull()
        {
            var pilha = new PilhaDinamica();

            Assert.Null(pilha.Topo());
        }
    }
}