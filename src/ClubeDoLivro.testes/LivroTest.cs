using ClubeDoLivro.Domains;

namespace ClubeDoLivro.testes
{
    public class LivroTest
    {
        private readonly Livro _livro; 

        public LivroTest()
        {
            _livro = new Livro();
        }

        [Fact]
        public void QuandoEuCrioUmLivro_TodosCamposDevemEstarNulos()
        {
            //Arrange

            //Act
            var livro = new Livro();

            Assert.Null(livro.Autores);
            Assert.Null(livro.Paginas);
            Assert.Null(livro.Edicao);
            Assert.Null(livro.NomeDoLivro);
            Assert.Null(livro.CodigoISBN);
            Assert.Null(livro.Volume);
            Assert.Equal(0, livro.Id);
        }
    }
}