// EXERCÍCIO 01
Console.WriteLine("Escolha o nível de dificuldade" +
    "\n1- Fácil" +
    "\n2- Médio" +
    "\n3- Difícil");
int dificuldade = int.Parse(Console.ReadLine());
switch (dificuldade)
{
    case 1:
        Console.WriteLine("\nVocê tem 5 vidas, dano inimigo 10 e 3 checkpoints.");
        break;
    case 2:
        Console.WriteLine("\nVocê tem 3 vidas, dano inimigo 20 e 2 checkpoints.");
        break;
    case 3:
        Console.WriteLine("\nVocê tem 1 vida, dano inimigo 35 e 0 checkpoints.");
        break;
    default:
        Console.WriteLine("\nDificuldade inválida.");
        break;
}

// EXERCÍCIO 02
Console.WriteLine("\nÉ a sua primeira vez jogando?");
string primeiraVez = Console.ReadLine();
Console.WriteLine("Quer assistir ao tutorial?");
string tutorial = (Console.ReadLine());
if (primeiraVez == "sim" && tutorial == "sim")
{
    Console.WriteLine("\nIniciando tutorial...");
}
else
{
    Console.WriteLine("\nTutorial pulado. Boa sorte!");
}

//EXERCÍCIO 03
Console.WriteLine("\nVocê está escondido?");
string escondido = Console.ReadLine();
Console.WriteLine("Qual nível de barulho foi feito?");
int barulho = int.Parse(Console.ReadLine());
Console.WriteLine("O inimigo está olhando na sua direção?");
string direcao = (Console.ReadLine());
if (escondido == "nao" && direcao == "sim" || barulho >= 70)
{
    Console.WriteLine("\nVocê foi detectado!");
}
else
{
    Console.WriteLine("\nVocê passou despercebido.");
}

//EXERCÍCIO 04
Console.WriteLine("\nQuanto você tem de madeira?");
int madeira = int.Parse(Console.ReadLine());
Console.WriteLine("E de pedra?");
int pedra = int.Parse(Console.ReadLine());
Console.WriteLine("Você possui a receita?");
string receita = (Console.ReadLine());
if (madeira >= 3 && pedra >= 2 && receita == "sim")
{
    Console.WriteLine("\nLança criada com sucesso!");
}
else
{
    Console.WriteLine("\nVocê não possui os recursos necessários.");
}

//EXERCÍCIO 05
Console.WriteLine("\nEscolha o clima da fase" +
    "\n1- Sol" +
    "\n2- Chuva" +
    "\n3- Neve" +
    "\n4- Tempestade");
int clima = int.Parse(Console.ReadLine());
switch (clima)
{
    case 1:
        Console.WriteLine("\nSua velocidade é normal.");
        break;
    case 2:
        Console.WriteLine("\nVocê está com frio.");
        break;
    case 3:
        Console.WriteLine("\nVocê está escorregando.");
        break;
    case 4:
        Console.WriteLine("\nVocê está com dificuldade de enxergar.");
        break;
    default:
        Console.WriteLine("\nClima inválido.");
        break;
}

//EXERCÍCIO 06
Console.WriteLine("\nQual seu nível de reputação?");
int reputacao = int.Parse(Console.ReadLine());
Console.WriteLine("Você entregou um presente?");
string presente = (Console.ReadLine());
if (reputacao >= 50 || presente == "sim")
{
    Console.WriteLine("\nO NPC revelou uma informação secreta.");
}
else
{
    Console.WriteLine("\nO NPC ainda não confia em você.");
}

//EXERCÍCIO 07
Console.WriteLine("\nEscolha um símbolo" +
    "\n1- Lua" +
    "\n2- Sol" +
    "\n3- Estrela" +
    "\n4- Chama");
int simbolo = int.Parse(Console.ReadLine());
switch (simbolo)
{
    case 1:
        Console.WriteLine("\nUma ponte apareceu no caminho.");
        break;
    case 2:
        Console.WriteLine("\nO caminho se iluminou.");
        break;
    case 3:
        Console.WriteLine("\nVocê achou um item secreto no caminho.");
        break;
    case 4:
        Console.WriteLine("\nUma armadilha foi ativada.");
        break;
    default:
        Console.WriteLine("\nNada aconteceu.");
        break;
}

//EXERCÍCIO 08
Console.WriteLine("\nQual o nível de bateria da sua câmera?");
int bateria = int.Parse(Console.ReadLine());
Console.WriteLine("Tem algum monstro na tela?");
string monstro = Console.ReadLine();
Console.WriteLine("Você apertou o botão de gravar?");
string gravar = Console.ReadLine();
if (bateria > 0 && monstro == "sim" && gravar == "sim")
{
    Console.WriteLine("\nCena assustadora gravada!");
}
else if (bateria > 0 && monstro == "nao" && gravar == "sim")
{
    Console.WriteLine("\nVocê gravou, mas nada de interessante apareceu.");
}
else
{
    Console.WriteLine("\nA câmera está sem bateria.");
}

//EXERCÍCIO 09
Console.WriteLine("\nEscolha seu ataque" +
    "\n1- Ataque leve" +
    "\n2- Ataque pesado" +
    "\n3- Ataque especial" +
    "\n4- Esquivar");
int ataque = int.Parse(Console.ReadLine());
Console.WriteLine("\nQual a quantidade de energia possuída?");
int energia = int.Parse(Console.ReadLine());
switch (ataque)
{
    case 1:
        Console.WriteLine("\nVocê não gastou energia para esse ataque.");
        break;
    case 2:
        if (energia >= 15)
        {
            Console.WriteLine("\nSeu ataque funcionou!");
        }
        else
        {
            Console.WriteLine("\nEnergia insuficiente para o ataque.");
        }
        break;
    case 3:
        if (energia >= 30)
        {
            Console.WriteLine("\nSeu ataque funcionou!");
        }
        else
        {
            Console.WriteLine("\nEnergia insuficiente para o ataque.");
        }
        break;
    case 4:
        if (energia >= 10)
        {
            Console.WriteLine("\nSeu ataque funcionou!");
        }
        else
        {
            Console.WriteLine("\nEnergia insuficiente para o ataque.");
        }
        break;
    default:
        Console.WriteLine("\nNada aconteceu.");
        break;
}

//EXERCÍCIO 10 (DESAFIO)
Console.WriteLine("\nEvento especial! Escolha para qual área você vai:" +
    "\n1- Floresta" +
    "\n2- Ruínas" +
    "\n3- Laboratório" +
    "\n4- Praia");
int evento = int.Parse(Console.ReadLine());
Console.WriteLine("\nVocê chegou no evento.");
Console.WriteLine("\nQual seu nível?");
int nivel = int.Parse(Console.ReadLine());
Console.WriteLine("\nVocê possui algum item especial?");
string item = Console.ReadLine();
Console.WriteLine("\nVocê está acompanhado de um aliado?");
string aliado = Console.ReadLine();
switch (evento)
{
    case 1:
        if (nivel >= 5 && item == "sim" || aliado == "sim")
        {
            Console.WriteLine("\nÁrea escolhida: Floresta" +
                "\nEvento especial: Um animal selvagem apareceu!" +
                "\nVocê resolveu o evento com sucesso!");
        }
        else
        {
            Console.WriteLine("\nÁrea escolhida: Floresta" +
                "\nEvento especial: Um animal selvagem apareceu!" +
                "\nVocê não estava preparado para esse evento.");
        }
        break;
    case 2:
        if (nivel >= 5 && item == "sim" || aliado == "sim")
        {
            Console.WriteLine("\nÁrea escolhida: Ruínas" +
                "\nEvento especial: Uma armadilha antiga foi ativada!" +
                "\nVocê resolveu o evento com sucesso!");
        }
        else
        {
            Console.WriteLine("\nÁrea escolhida: Ruínas" +
                "\nEvento especial: Uma armadilha antiga foi ativada!" +
                "\nVocê não estava preparado para esse evento.");
        }
        break;
    case 3:
        if (nivel >= 5 && item == "sim" || aliado == "sim")
        {
            Console.WriteLine("\nÁrea escolhida: Laboratório" +
                "\nEvento especial: Um robô descontrolado apareceu!" +
                "\nVocê resolveu o evento com sucesso!");
        }
        else
        {
            Console.WriteLine("\nÁrea escolhida: Laboratório" +
                "\nEvento especial: Um robô descontrolado apareceu!" +
                "\nVocê não estava preparado para esse evento.");
        }
        break;
    case 4:
        if (nivel >= 5 && item == "sim" || aliado == "sim")
        {
            Console.WriteLine("\nÁrea escolhida: Praia" +
                "\nEvento especial: Uma tempestade repentina apareceu!" +
                "\nVocê resolveu o evento com sucesso!");
        }
        else
        {
            Console.WriteLine("\nÁrea escolhida: Praia" +
                "\nEvento especial: Uma tempestade repentina apareceu!" +
                "\nVocê não estava preparado para esse evento.");
        }
        break;
    default:
        Console.WriteLine("\nOpção inválida.");
        break;
}
