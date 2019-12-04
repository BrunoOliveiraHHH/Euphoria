package Pedido;

import java.util.ArrayList;

public interface ManipularPedido {
	public boolean inserirPedido(Pedido pedido);

	public boolean alterarPedido(Pedido pedido);

	public boolean excluirPedido(Pedido pedido);

	ArrayList<Pedido> ConsultarPedido(Pedido pedido);
}
