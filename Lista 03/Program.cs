// EXERCÍCIO 01
int passo = 0;

while (passo != 10)
{
    if (passo < 10)
    {
        Console.WriteLine("o personagem deu mais um passo" +
        "\npassos atuais: " + passo);
        passo++;
    }
    if (passo == 10)
    {
        Console.WriteLine("\nVocê chegou ao seu destino");
    }
}

// EXERCÍCIO 02
Random sorteio = new Random();
int dado = sorteio.Next(1, 7);

while (dado != 6)
{
    Console.WriteLine("O número sorteado foi: " + dado);
    dado = sorteio.Next(1, 7);

}
Console.WriteLine("\nVocê tirou 6! fim da rolagem");

// EXERCÍCIO 03
sorteio = new Random();
int porta = sorteio.Next(1, 6);

while (porta != 5)
{
    Console.WriteLine("A porta continua fechada..." + porta);
    porta = sorteio.Next(1, 7);

}
Console.WriteLine("\nA porta abriu!");

// EXERCÍCIO 04
sorteio = new Random();
int item_raro = sorteio.Next(1, 11);
Console.WriteLine("\nVocê está procurando um item raro");
while (item_raro != 10)
{
    Console.WriteLine("Você ainda não o encontrou! Continuar procurando?");
    string item = (Console.ReadLine());
    if (item == "s")
        item_raro = sorteio.Next(1, 11);
}
Console.WriteLine("\nVocê encontrou o item raro!" +
    " Tentativas: ");

// EXERCÍCIO 05
Random secreto = new Random();
Console.WriteLine("\nAdivinhe o número de 1 a 20");
int numero = secreto.Next(1, 21);
int numero2 = int.Parse(Console.ReadLine());
while (numero2 != numero)
{
    if (numero2 > numero)
    {
        Console.WriteLine("O número secreto é menor.");
        numero2 = int.Parse(Console.ReadLine());
    }
    if (numero2 < numero)
    {
        Console.WriteLine("O número secreto é maior.");
        numero2 = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Você acertou!");