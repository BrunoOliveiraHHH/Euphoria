package Pedido;

import java.util.ArrayList;

import Pedido.ManipularPedido;

public class PedidoRepositorioList implements ManipularPedido {
	private static PedidoRepositorioList instance;
	private ArrayList<Pedido> Pedido;

	private PedidoRepositorioList() {
		Pedido = new ArrayList<Pedido>();
	}

	public static synchronized PedidoRepositorioList getInstance() {
		if (instance == null) {
			instance = new PedidoRepositorioList();
		}
		return instance;
	}

	@Override
	public boolean inserirPedido(Pedido pedido) {

		return pedido.add(pedido);
	}

	@Override
	public boolean alterarPedido(Pedido pedido) {
		return pedido.add(pedido);
	}

	@Override
	public boolean excluirPedido(Pedido pedido) {
		for (int i = 0; i < pedido.size(); i++) {
			if (pedido.get(i).getNome().compareToIgnoreCase(pedido.getNome()) == 0) {
				pedido.remove(i);
				return true;
			}
		}

		return false;
	}

	@Override
	public ArrayList<Pedido> Consultarpedido(Pedido pedido) {
		ArrayList<Pedido> pedidoRetorno = new ArrayList<Pedido>();
		if (pedido.getId() > 0) {
			for (int i = 0; i < pedido.size(); i++) {
				if (pedido.get(i).getId() == pedido.getId()) {
					pedidoRetorno.add(pedido.get(i));
				}
			}
			return pedidoRetorno;
		}
		return pedidoRetorno;

	}

}
