// See https://aka.ms/new-console-template for more information
string entradaUser = "";
while(entradaUser != "0")
{
    Console.WriteLine("digite um número entre 1 e 13, o número digitado dará inicio a um programa / digitar zero encerra o programa");
    entradaUser = Console.ReadLine();
        if(entradaUser == "1")
    {
        Somar2Num();
    }
            if(entradaUser== "2")
    {
            MetrosMili();
    }
                if(entradaUser == "3")
    {
                CauculaAumento();
    }
                    if(entradaUser == "4")
    {
                    CalculaDesconto();
    }
                        if(entradaUser == "5")
    {
                        AluguelCarro();
    }
                            if(entradaUser == "6")
    {
                            IMC();
    }
                                if(entradaUser == "7")
    {
                                Tabuada();
    }
                                    if(entradaUser == "8")
    {
                                    Multi3();
    }
                                        if(entradaUser == "9")
    {
                                        Fatorialde1a10();
    }
                                            if (entradaUser == "10")
    {
                                            ImpostoDeRenda();
    }
                                                if (entradaUser == "11")
    {
                                                Adivinha();
    }
                                                    if(entradaUser == "12")
    {
                                                    Financiamento();
    }
                                                        if(entradaUser == "13")
    {
                                                        aposentadoria();
    }
}

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
    Console.WriteLine($"dê seu peso e altura, respectivamente");
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
    //não irei considerar os dependentes porque não achei a base de cálculo
    double Renda;
    Console.WriteLine("informe o total de sua renda");
    Renda = float.Parse(Console.ReadLine());
    if (Renda <= 1903.98)
    {
        Console.WriteLine("você está isento");
    }
    else
    {
        if (Renda > 1903.98 && Renda <= 2826.65)
        {
            Renda = Renda * 0.075;
            Console.WriteLine($"o valor a ser pago será de: {Renda} / peteleco bem dado pelo estado");
        }
        else
        {
            if(Renda >2826.65 && Renda < 3751.05)
            {
                Renda = Renda * 0.15;
                Console.WriteLine($"o valor a ser pago será de: {Renda} / pescotapa do estado");
            }
            else
            {
                if(Renda>3751.05 && Renda <= 4664.68)
                {
                    Renda = Renda * 0.225;
                    Console.WriteLine($"o valor a ser pago será de: {Renda} / facada do estado");
                }
                else {
                    Renda = Renda * 0.275;
                    Console.WriteLine($"o valor a ser pago será de: {Renda} / estripado pelo estado");
                     }
            }
        }
    }
}

void Adivinha()
{
    int userTent, numAleatorio;
    Random rand = new Random();
    numAleatorio = rand.Next(1, 100);
    Console.WriteLine("chute um número entre 1 e 100, você tem 10 tentativas para acertar o número");
    for(int i = 0; i < 10; i++)
    {
        userTent = int.Parse(Console.ReadLine());
        if (userTent == numAleatorio)
        {
            userTent = numAleatorio;
            Console.WriteLine($"você acertou!");
            break;
        }      
    }
    Console.WriteLine($"você gastou todas suas tentativas! o número aleatório era: {numAleatorio}");
}

void Financiamento()
{
    /*
    Quando é a taxa de financiamento de veículos?
Taxas no financiamento de carros, segundo o BC

Em média, as taxas mensais atualmente estão entre 0,91% e 3,86%, e anuais, entre 11,42% e 57,52%. Porém, podem mudar de uma semana para outra; por isso, o indicado é verificar periodicamente até comprar o veículo.
    */
    double valorVeic, parcela, taxa, valorFinc = 0;
    Console.WriteLine("informe o valor de um veículo e o número de parcelas no financiamento, respectivamente");
    valorVeic = float.Parse(Console.ReadLine());
    parcela = float.Parse(Console.ReadLine());
    taxa = (valorVeic * 0.02) * parcela;
    if(parcela == 1)
    {
        taxa = valorVeic * 0.12;
    }
    valorFinc =  valorVeic + taxa;
    Console.WriteLine($"o valor total foi: {valorFinc}");
}
void aposentadoria()
{
    //está sendo considerado que a rentabilidade anual é 4.5%, portanto a rentabilidade mensal será de 0.375 
    double idadeAtual, idadeAposent, anosContri, ValorPmes, acumulador=0, montante=0, jurosComposto=0;
    Console.WriteLine("informe sua idade atual e com que idade você planeja se aposentar");
    idadeAtual = double.Parse(Console.ReadLine());
    idadeAposent = double.Parse(Console.ReadLine());
    anosContri = idadeAposent - idadeAtual;
    Console.WriteLine("diga quanto você contribui por mês");
    ValorPmes = double.Parse(Console.ReadLine());
    for (int i = 0; i < anosContri; i++)
    {        
        acumulador = acumulador + (ValorPmes*12);
        jurosComposto = jurosComposto + acumulador * 0.045;
        montante = acumulador + jurosComposto;
        Console.WriteLine(jurosComposto);
    }
    Console.WriteLine($"o acumulado por {anosContri} anos de contribuição,contribuindo {ValorPmes} $$ por mês foi: {montante}");
    Console.WriteLine($"o total gerado pela rentabilidade foi: {jurosComposto}");
}
