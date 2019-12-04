package Produto;

import java.util.ArrayList;

public class ProdutoControlador {
	private ManipularProduto repositorio;

	public boolean exists(Produto produto) {
		int a = repositorio.ConsultarProduto(produto).size();
		if (a == 0) {
			return true;
		} else
			return false;
	}

	public ArrayList<Produto> ConsultarProduto(Produto produto) {
		return repositorio.ConsultarProduto(produto);
	}

	public boolean inserirProduto(Produto produto) {

		if (exists(produto)) {

			boolean novoproduto = repositorio.inserirProduto(produto);

			if (novoproduto) {

				return true;

			} else {

				return false;

			}

		}

		else {

			return false;

		}
	}

	public boolean excluirProduto(Produto produto) {
		return repositorio.excluirProduto(produto);
	}

	public ProdutoControlador() {
		repositorio = ProdutoRepositorioList.getInstance();
	}

}
