using VenderNoCaixa;

List<Produto> produtos = new List<Produto>();
List<Venda> vendas = new List<Venda>();



int opcao = 0;
while (opcao != 7)
{
    System.Console.WriteLine(("Menu:"));
    System.Console.WriteLine("1 - Cadastrar Produto:");
    System.Console.WriteLine("2 - Registrar Venda");
    System.Console.WriteLine("3 - Consultar Venda");
    System.Console.WriteLine("4 - Forma de Pagamento (Cartão)");
    System.Console.WriteLine("5 - Forma de Pagamento (Cheque)");
    System.Console.WriteLine("6 - Forma de Pagamento (Espécie)");
    System.Console.WriteLine("7 - Sair\nDigite a opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());
}

int op = 0;
while (op != 4)
{
    Console.WriteLine("Menu Produtos e Vendas:");
    Console.WriteLine("1 - Cadastrar Produto");
    Console.WriteLine("2 - Registrar Venda");
    Console.WriteLine("3 - Consultar Venda");
    Console.WriteLine("4 - Sair\nDigite a opção: ");
    op = Convert.ToInt32(Console.ReadLine());
    if op = 1{
        // Lógica para cadastrar um produto
    }
    if op = 2{
        // Lógica para registrar uma venda
    }
    if op = 3{
        // Lógica para consultar uma venda
    }
    if op = 4{
        Console.WriteLine("Saindo...");
    }
}

int opcao = 0;
while (opcao != 4)
{
    Console.WriteLine("Menu Formas de Pagamento:");
    Console.WriteLine("1 - Pagamento em Cartão");
    Console.WriteLine("2 - Pagamento em Cheque");
    Console.WriteLine("3 - Pagamento em Espécie");
    Console.WriteLine("4 - Sair\nDigite a opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());
    if op = 1{
        // Lógica para pagamento no cartão
    }
    if op = 2{
        // Lógica para pagamento em cheque
    }
    if op = 3{
        // Lógica para pagamento em espécie
    }
    if op = 4{
        Console.WriteLine("Saindo...");
    }

}