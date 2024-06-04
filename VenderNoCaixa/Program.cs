using VenderNoCaixa;

List<Produto> produtos = new List<Produto>();
List<Venda> vendas = new List<Venda>();

int opcao = 0;
while (opcao != 7)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Cadastrar Produto:");
    Console.WriteLine("2 - Mostrar Produtos");
    Console.WriteLine("3 - Consultar Venda");
    Console.WriteLine("4 - Forma de Pagamento (Cartão)");
    Console.WriteLine("5 - Forma de Pagamento (Cheque)");
    Console.WriteLine("6 - Forma de Pagamento (Espécie)");
    Console.WriteLine("7 - Sair\nDigite a opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 1)
    {
        CadastrarProduto(produtos);
    }
    else if (opcao == 2)
    {
        MostrarProdutos(produtos);
    }
    else if (opcao == 3)
    {
        ConsultarVenda(vendas);
    }
    else if (opcao == 4)
    {
        PagamentoCartao();
    }
    else if (opcao == 5)
    {
        PagamentoCheque();
    }
    else if (opcao == 6)
    {
        PagamentoEspecie();
    }
    else if (opcao == 7)
    {
        Console.WriteLine("Saindo...");
    }
}

static void CadastrarProduto(List<Produto> produtos)
{
    Console.WriteLine("Digite o código do produto:");
    int codigo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o nome do produto:");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite a quantidade em estoque:");
    int estoque = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o preço do produto:");
    double preco = Convert.ToDouble(Console.ReadLine());

    Produto produto = new Produto(codigo, nome, estoque, preco);
    produtos.Add(produto);

    Console.WriteLine("Produto cadastrado com sucesso!");
}

static void MostrarProdutos(List<Produto> produtos)
{
    Console.WriteLine("Lista de Produtos:");
    foreach (Produto produto in produtos)
    {
        Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Estoque: {produto.Estoque}, Preço: {produto.Preco}");
    }
}

static void ConsultarVenda(List<Venda> vendas)
{
    Console.WriteLine("Digite o dia da venda para consulta:");
    int dataConsulta = Convert.ToInt32(Console.ReadLine());
    Venda vendaConsulta = vendas.Find(v => v.Data == dataConsulta);

    if (vendaConsulta != null)
    {
        vendaConsulta.Mostrar();
    }
    else
    {
        Console.WriteLine("Venda não encontrada!");
    }
}

static void PagamentoCartao()
{
    Console.WriteLine("Digite o dia do pagamento:");
    int dataCartao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o valor do pagamento:");
    double valorCartao = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite os dados da transação:");
    string dadosTransacao = Console.ReadLine();
    Console.WriteLine("Digite o resultado da transação:");
    int resultadoTransacao = Convert.ToInt32(Console.ReadLine());

    Cartao cartao = new Cartao(dataCartao, valorCartao, dadosTransacao, resultadoTransacao);
    cartao.Mostrar();
}

static void PagamentoCheque()
{
    Console.WriteLine("Digite a data do pagamento:");
    int dataCheque = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o valor do pagamento:");
    double valorCheque = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o número do cheque:");
    long numeroCheque = Convert.ToInt64(Console.ReadLine());
    Console.WriteLine("Digite a data de depósito:");
    int dataDeposito = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite a situação do cheque:");
    int situacaoCheque = Convert.ToInt32(Console.ReadLine());

    Cheque cheque = new Cheque(dataCheque, valorCheque, numeroCheque, dataDeposito, situacaoCheque);
    cheque.Mostrar();
}

static void PagamentoEspecie()
{
    Console.WriteLine("Digite a data do pagamento:");
    int dataEspecie = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o valor do pagamento:");
    double valorEspecie = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a quantia recebida:");
    double quantiaRecebida = Convert.ToDouble(Console.ReadLine());
    double troco = quantiaRecebida - valorEspecie;

    Especie especie = new Especie(dataEspecie, valorEspecie, quantiaRecebida, troco);
    especie.Mostrar();
}
