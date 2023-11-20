// Implementação da Pilha (Stack)
namespace Atividade5;

public class Pilha<T> {
	private List<T> itens = null!;

	public Pilha() {
		itens = new List<T>();
	}

	public void Empilhar(T item) {
		itens.Add(item);
	}

	public T Desempilhar() {
		if(itens.Count == 0) {
			throw new InvalidOperationException("A pilha está vazia");
		}

		T item = itens.Last();
		itens.RemoveAt(itens.Count - 1);
		return item;
	}

	public T Topo() {
		if(itens.Count == 0) {
			throw new InvalidOperationException("A pilha está vazia");
		}

		return itens.Last();
	}

	public int Tamanho {
		get { return itens.Count; }
	}
}