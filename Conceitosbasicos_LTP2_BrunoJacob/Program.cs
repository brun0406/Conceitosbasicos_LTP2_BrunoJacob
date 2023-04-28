// See https://aka.ms/new-console-template for more information
Somar2Num();
MetrosMili();
CauculaAumento();
CalculaDesconto();
AluguelCarro();
IMC();
Tabuada();
Multi3();
Fatorialde1a10();
ImpostoDeRenda();

void Somar2Num()
{
    int[] num = new int[2];
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine("informe um número inteiro");
        num[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("a soma dos valores dados é: " + (num[0] + num[1]));
}

void MetrosMili()
{
    float Metr;
    Console.WriteLine("informe uma medida em metros");
    Metr = float.Parse(Console.ReadLine());
    Console.WriteLine($"a medida informada em milimetros é igual a: {Metr * 1000}");
}

void CauculaAumento()
{
    float SalarAtual, PercentAumento, ValorAumento, SalarFinal;
    Console.WriteLine("informe o salário do funcionário de uma empresa e, após, o percentual de seu aumento");
    SalarAtual = float.Parse(Console.ReadLine());
    PercentAumento = float.Parse(Console.ReadLine());
    PercentAumento = PercentAumento / 100;
    SalarFinal = SalarAtual * (PercentAumento + 1);
    ValorAumento = SalarFinal - SalarAtual;
    Console.WriteLine($"o salário incial foi: {SalarAtual} / o percentual de aumento digitado foi: {PercentAumento * 100}%");
    Console.WriteLine($"o salário final do funcionário se tornou : {SalarFinal} / o total de aumento foi: {ValorAumento}");
}

void CalculaDesconto()
{
    float ValorInic, PercentMerc, ValorDesc, FinalMerc;
    Console.WriteLine("digite o valor de uma mercadoria e, após, seu desconto");
    ValorInic = float.Parse(Console.ReadLine());
    PercentMerc = float.Parse(Console.ReadLine());
    ValorDesc = ValorInic * PercentMerc / 100;
    FinalMerc = ValorInic - ValorDesc;
    Console.WriteLine($"o valor inicial da mercadoria informado é: {ValorInic} / o desconto dado foi de: {PercentMerc}%");
    Console.WriteLine($"o valor final da mercadoria se tornou: {FinalMerc} / o total de descunto foi: {ValorDesc}$");
}

void AluguelCarro()
{
    double TotalDias, KmInicial, KmFinal, PrecoKm, TotalAlug;
    Console.WriteLine("informe o total de dias alugados, seguido da kilometragem inicial e final");
    TotalDias = float.Parse(Console.ReadLine());
    TotalDias = TotalDias * 95;
    KmInicial = float.Parse(Console.ReadLine());
    KmFinal = float.Parse(Console.ReadLine());
    PrecoKm = (KmFinal - KmInicial) * 0.35;
    TotalAlug = TotalDias + PrecoKm;
    Console.WriteLine($"o preço por dias alugados foi: {TotalDias} / o total de quilometros rodados foi: {KmFinal - KmInicial} / o preço por quilometros rodados foi: {PrecoKm}");
    Console.WriteLine($"o preço final foi: {TotalAlug}");
}

void IMC()
{
    float peso, altura, imc;
    Console.WriteLine($"dê seu peso e altura");
    peso = float.Parse(Console.ReadLine());
    altura = float.Parse(Console.ReadLine());
    imc = peso / (altura * altura);
    if (imc <= 18.5)
    {
        Console.WriteLine("você está abaixo do peso");
    }
    else
    {
        if (imc >= 18.6 && imc < 24.9)
        {
            Console.WriteLine("seu peso é o ideal");
        }
        else
        {
            if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("levemente acima do peso");
            }
            else
            {
                if (imc >= 30 && imc < 35)
                {
                    Console.WriteLine("obesidade grau I");
                }
                else
                {
                    if (imc >= 35 && imc < 40)
                    {
                        Console.WriteLine("obesidade grau II");
                    }
                    else
                    {
                        Console.WriteLine("obesidade mórbida");
                    }
                }
            }
        }
    }
}

void Tabuada()
{
    int NumTabuada, Result;
    Console.WriteLine("digite um número inteiro de sua preferência");
    NumTabuada = int.Parse(Console.ReadLine());
    for (int i = 1; i < 11; i++)
    {
        Result = NumTabuada * i;
        Console.WriteLine($"{NumTabuada}*{i}={Result}");
    }
}

void Multi3()
{
    Console.WriteLine("múltiplos de 3 entre 1 e 100");
    for (int i = 1; i < 101; i++)
    {
        if (i % 3 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

void Fatorialde1a10()
{
    int Fat = 1;
    Console.WriteLine("fatorial dos números de 1 a 10");
    for (int i = 1; i < 11; i++)
    {
        Fat = Fat * i;
        Console.WriteLine(Fat);
    }
}

void ImpostoDeRenda()
{
    Console.WriteLine("imposto é roubo!");
}
