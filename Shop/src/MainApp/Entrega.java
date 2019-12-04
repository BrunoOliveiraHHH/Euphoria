package MainApp;

import java.util.Scanner;

import Cliente.*;
import Produto.ProdutoControlador;
import Produto.Produto;
import Cliente.Associado;
import Util.ConsoleInterface;
import Util.InterfaceUsuario;

public class Entrega {
	public static void main(String[] args) {

		InterfaceUsuario menu = new ConsoleInterface();

		System.out.println("Bem vindo a Distribuidora !");

		System.out.println("Selecione uma opção :");

		String opcoesMenu[] = { "1. Inserir produto", "2. Retirar produto", "3. Status produto" };

		menu.construirOpcoesMenu(opcoesMenu);

		Scanner input = new Scanner(System.in);

		int menuu = input.nextInt();

		if (menuu == 1) {

			System.out.println("Insira nº produto (1-3)");
			int pdt = input.nextInt();

			ProdutoControlador dc = new ProdutoControlador();

			switch (pdt) {

			case 1:

				Produto produto1 = new Produto();
				produto1.setId(1);
				produto1.setNome("Produto1");

				dc.inserirProduto(produto1);

				if (dc.inserirProduto(produto1) == true) {

					System.out.println(produto1.getId() + " " + produto1.getNome());

				} else {

					System.out.println("Não Foi Possivel Fazer o Cadastro");

				}

				break;

			case 2:
				Produto produto2 = new Produto();
				produto2.setId(2);
				produto2.setNome("Produto2");

				dc.inserirProduto(produto2);

				if (dc.inserirProduto(produto2) == true) {

					System.out.println(produto2);

				} else {

					System.out.println("Não Foi Possivel Fazer o Cadastro");

				}

				break;

			case 3:
				Produto produto3 = new Produto();
				produto3.setId(3);
				produto3.setNome("Produto3");

				dc.inserirProduto(produto3);

				if (dc.inserirProduto(produto3) == true) {

					System.out.println(produto3);

				} else {

					System.out.println("Não Foi Possivel Fazer o Cadastro");

				}

				break;

			default:
				System.out.println(menu);
			}
		} else if (menuu == 2) {
			ProdutoControlador dc = new ProdutoControlador();
			dc.excluirProduto(new Produto(1, "Produto1"));
			for (Produto d : dc.ConsultarProduto(new Produto(1, "Produto1")))
				System.out.println(d.getNome());
		} else if (menuu == 3) {
			ProdutoControlador dc = new ProdutoControlador();
			for (Produto d : dc.ConsultarProduto(new Produto()))
				System.out.println(d.getId() + " " + d.getNome());

			for (Produto d : dc.ConsultarProduto(new Produto(1, "Produto1")))
				System.out.println("Encontrei: " + d.getNome());
		}

		// Associado associado = new Cliente(menu, "Cliente");
		// associado.listarProduto();
	}
}
