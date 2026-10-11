List<Despesa> despesas = new List<Despesa> ();
string? opcao = "";
while (opcao != "0")
{
     


Console.WriteLine("=============================");
Console.WriteLine("         Controle de Gastos  ");
Console.WriteLine("=============================");

Console.WriteLine();
Console.WriteLine("1 - Adicione desepesa");
Console.WriteLine("2 - Listar despesas");
Console.WriteLine("3 - ver total");
Console.WriteLine("4 - Remover Despesas");
Console.WriteLine("0 - sair");



Console.WriteLine();

Console.WriteLine("Escolha uma opção: ");

opcao = Console.ReadLine();

Console.WriteLine();
 
switch (opcao)
{
    case "1":
    Console.Write("nome da despesa: ");
     string? nome = Console.ReadLine();

    Console.Write("Valor da Despesa: ");
    decimal valor; 

    while (!decimal.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Valor Inválido. Digite um valor numérico para a despesa:");
                Console.Write("Valor da Despesa: ");
            }

    Despesa novaDespesa = new Despesa();

  novaDespesa.Nome = nome ?? "";
  novaDespesa.Valor = valor;
  despesas.Add(novaDespesa);

  Console.WriteLine();
  Console.WriteLine("Despesa adicionada com sucesso!");


    break;


    case "2":
    Console.WriteLine("==== DESPESAS ====.");

    if(despesas.Count == 0)
        {
            Console.WriteLine("Nenhum despesa cadastrada.");
        }
        else
        {
            foreach (Despesa despesa in despesas)
            {
                Console.WriteLine($"Nome: {despesa.Nome}");
                Console.WriteLine($"Valor: R$ {despesa.Valor:F2}");
                Console.WriteLine("-----------------------------");
            }
        }

    break;

    case "3": 
    Console.WriteLine("Você escolheu ver o total.");
    decimal total = 0;
    foreach (Despesa despesa in despesas)
            {
                total += despesa.Valor;

            }
            Console.WriteLine($"O total das despesas é: R$ {total:F2}");
    break;

    case "4":
    Console.WriteLine("Você escolheu remover uma despesa.");
    if (despesas.Count == 0)
            {
                Console.WriteLine("Nenhuma despesa cadastrada.");
                break;
            }
            Console.WriteLine("===== Remover Despesa =====");

            for (int i = 0; i < despesas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {despesas[i].Nome} - R$ {despesas[i].Valor:F2}");
            }

            Console.WriteLine();
            Console.WriteLine("Digite o número da despesa que deseja remover: ");

            int numeroDespesa; 

            while (!int.TryParse(Console.ReadLine(), out numeroDespesa))
            {
                Console.WriteLine("Número inválido. Digite um número válido da despesa que deseja remover:");
                Console.WriteLine("Digite o número da despesa que deseja remover: ");
            }

            if (numeroDespesa >= 1 && numeroDespesa <= despesas.Count)
            {
                Despesa despesasRemovida = despesas[numeroDespesa - 1];
                despesas.RemoveAt(numeroDespesa - 1);

                Console.WriteLine();
                Console.WriteLine($"Despesa '{despesasRemovida.Nome}' removida com sucesso!");

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Número de despesa inválido.");
            }


    break;

    case "0": 
    Console.WriteLine("programa encerrado.");
    break;

    default: 
    Console.WriteLine("Opção inválida.");
    break;
}
}

