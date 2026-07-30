// EXERCÍCIO 1
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Escreva seu nome");
string nome = Console.ReadLine();
Console.WriteLine("\nBem vindo(a) ao jogo, " + nome);

// EXERCÍCIO 2
string vida = "\nvida atual: 100";
Console.WriteLine(vida);
string vida2 = "\nvida atual: 80";
Console.WriteLine(vida2);

// EXERCÍCIO 3
Console.WriteLine("\nEscreva sua pontuação inicial");
int pontuação = int.Parse(Console.ReadLine());
Console.WriteLine("\nSua pontuação inicial é: " + pontuação);
if (pontuação >= 0)
{
    Console.WriteLine("Você já começou pontuando!");
}
else
{
    Console.WriteLine("Você ainda não tem pontos.");
}

// EXERCÍCIO 4
Console.WriteLine("\nMe diga sua vida");
int vida3 = int.Parse(Console.ReadLine());
Console.WriteLine("\nSua pontuação inicial é: " + vida3);
if (vida3 >= 0)
{
    Console.WriteLine("O jogador ainda está vivo!");
}
else
{
    Console.WriteLine("Game Over.");
}

// EXERCÍCIO 5
Console.WriteLine("\nMe diga sua energia");
int energia = int.Parse(Console.ReadLine());
Console.WriteLine("\nSua energia é: " + energia);
if (energia >= 10)
{
    Console.WriteLine("Você pode atacar!");
}
else
{
    Console.WriteLine("Energia insuficiente.");
}

// EXERCÍCIO 6
Console.WriteLine("\nEscreva sua classe (EX: Guerreiro, mago, arqueiro)");
string classe = (Console.ReadLine());
Console.WriteLine("\nSua classe é: " + classe);
if (classe == "guerreiro")
{
    Console.WriteLine("Você escolheu guerreiro!");
}
else
{
    Console.WriteLine("Classe diferente de guerreiro.");
}

// EXERCÍCIO 7
Console.WriteLine("\nVocê tem a chave?");
bool temChave = true;
if (temChave == true)
{
    Console.WriteLine("A porta abriu.");
}
else
{
    Console.WriteLine("A porta está trancada.");
}

// EXERCÍCIO 8
Console.WriteLine("\nQuantas moedas você tem?");
int moedas = int.Parse(Console.ReadLine());
Console.WriteLine("\nVocê tem: " + moedas);
if (moedas >= 50)
{
    Console.WriteLine("Você pode comprar o item.");
}
else
{
    Console.WriteLine("Moedas insuficientes.");
}
// EXERCÍCIO 9
Console.WriteLine("\nEscreva sua vida atual");
int vida_atual = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o dano recebido");
int dano = int.Parse(Console.ReadLine());
int vida_final = vida_atual - dano;
if (vida_final > 0)
{
    Console.WriteLine("\nSua vida final é: " + vida_final);
}
else
{
    Console.WriteLine("\nVocê foi derrotado");
}

// EXERCÍCIO 10
Console.WriteLine("\nEscreva o nome do seu personagem");
string nome_personagem = (Console.ReadLine());
Console.WriteLine("Escreva sua classe");
string classe_personagem = (Console.ReadLine());
Console.WriteLine("Me diga sua vida");
int vida_personagem = int.Parse(Console.ReadLine());
Console.WriteLine("Me diga sua energia");
int energia_personagem = int.Parse(Console.ReadLine());
Console.WriteLine("\nSeu nome é: " + nome_personagem);
Console.WriteLine("Sua classe é: " + classe_personagem);
Console.WriteLine("Sua vida é: " + vida_personagem);
Console.WriteLine("Sua energia é: " + energia_personagem);
if (vida_personagem > 0)
{
    Console.WriteLine("\nPersonagem pronto para a aventura!");
}
else
{
    Console.WriteLine("\nPersonagem inválido: vida precisa ser maior que zero.");
}

// EXERCÍCIO 11
Console.WriteLine("\nMe diga sua vida atual");
int vida_recente = int.Parse(Console.ReadLine());
Console.WriteLine("Me diga a quantidade de cura necessária");
int cura = int.Parse(Console.ReadLine());
int vidaFinal = vida_recente + cura;
if (vidaFinal >= 100)
{
    Console.WriteLine("Vida final: 100");
}
else
{
    Console.WriteLine("Vida final: " + vidaFinal);
}

// EXERCÍCIO 12
Console.WriteLine("\nEscolha um caminho: \n1- Floresta \n2- Caverna \n3- Castelo");
int caminho = int.Parse(Console.ReadLine());
if (caminho == 1)
{
    Console.WriteLine("Você entrou na floresta.");
}
if (caminho == 2)
{
    Console.WriteLine("Você entrou na caverna.");
}
if (caminho == 3)
{
    Console.WriteLine("Você entrou no castelo.");
}
if (caminho >= 4)
{
    Console.WriteLine("Opção inválida.");
}

// EXERCÍCIO 13
Console.WriteLine("\nQual seu nível atual?");
int nivel = int.Parse(Console.ReadLine());
if (nivel < 5)
{
    Console.WriteLine("\nIniciante.");
}
if (nivel >= 6)
{
    Console.WriteLine("Aventureiro.");
}
if (nivel > 10)
{
    Console.WriteLine("Herói experiente.");
}

// EXERCÍCIO 14
Console.WriteLine("\nQual a sua pontuação?");
int rank = int.Parse(Console.ReadLine());
if (rank >= 500)
{
    Console.WriteLine("Rank S");
}
else if (caminho >= 300)
{
    Console.WriteLine("Rank A");
}
else if (caminho >= 100)
{
    Console.WriteLine("Rank B");
}
else if (caminho <= 0)
{
    Console.WriteLine("Rank C");
}

// EXERCÍCIO 15
