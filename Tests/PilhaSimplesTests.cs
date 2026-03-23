using Domain.Estruturas;

namespace Tests
{
    public class PilhaSimplesTests
    {
        [Fact]
        public void Empilhar()
        {
            var pilha = new PilhaSimples(5);

            pilha.Empilhar(10);

            Assert.Equal(10, pilha.Topo());
        }

        [Fact]
        public void Empilharvrios()
        {
            var pilha = new PilhaSimples(5);

            pilha.Empilhar(10);
            pilha.Empilhar(20);
            pilha.Empilhar(30);

            Assert.Equal(30, pilha.Topo());
        }

        [Fact]
        public void Desempilhar()
        {
            var pilha = new PilhaSimples(5);

            pilha.Empilhar(10);
            pilha.Empilhar(20);

            var removido = pilha.Desempilhar();

            Assert.Equal(20, removido);
            Assert.Equal(10, pilha.Topo());
        }

        [Fact]
        public void PilhaVaziaAodesempilhar()
        {
            var pilha = new PilhaSimples(5);

            pilha.Empilhar(10);

            pilha.Desempilhar();

            Assert.Null(pilha.Topo());
        }

        [Fact]
        public void DesempilharPilhaVaziaDeveRetornarNull()
        {
            var pilha = new PilhaSimples(5);

            var removido = pilha.Desempilhar();

            Assert.Null(removido);
        }

        [Fact]
        public void DeveRetornarNull()
        {
            var pilha = new PilhaSimples(5);

            Assert.Null(pilha.Topo());
        }

        [Fact]
        public void TesteDelimite()
        {
            var pilha = new PilhaSimples(2);

            pilha.Empilhar(10);
            pilha.Empilhar(20);


            pilha.Empilhar(30);

            Assert.Equal(20, pilha.Topo());
        }
    }
}