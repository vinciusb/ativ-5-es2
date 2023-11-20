using Atividade5;
using Xunit;

public class StackTest {

	[Fact]
	public void Pilha_EmpilharEDesempilhar_Sucesso() {
		// Arrange
		Pilha<int> pilha = new Pilha<int>();

		// Act
		pilha.Empilhar(1);
		pilha.Empilhar(2);
		int desempilhado = pilha.Desempilhar();

		// Assert
		Assert.Equal(2, desempilhado);
		Assert.Equal(1, pilha.Tamanho);
	}

	[Fact]
	public void Pilha_TopoSimples_Sucesso() {
		// Arrange
		Pilha<string> pilha = new Pilha<string>();

		// Act
		pilha.Empilhar("Primeiro");
		pilha.Empilhar("Topo");

		// Assert
		Assert.Equal("Topo", pilha.Topo());
	}

	[Fact]
	public void Pilha_DesempilharPilhaVazia_Excecao() {
		// Arrange
		Pilha<double> pilha = new Pilha<double>();

		// Act/Assert
		Assert.Throws<InvalidOperationException>(() => pilha.Desempilhar());
	}
}

