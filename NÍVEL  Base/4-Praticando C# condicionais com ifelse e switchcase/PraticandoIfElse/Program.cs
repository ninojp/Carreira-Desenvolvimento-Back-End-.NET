//será que é necessário usar o namespace completo para acessar a classe AulaPratica1, ou seja, PraticandoIfElse.AulaPratica1? Sim, é necessário usar o namespace completo para acessar a classe AulaPratica1, a menos que você tenha uma declaração de using para o namespace PraticandoIfElse no início do seu arquivo. Se você tiver a declaração de using, poderá acessar a classe diretamente como AulaPratica1. Caso contrário, você precisará usar o nome completo do namespace para acessar a classe.
using PraticandoIfElse;

void exibiTitulo()
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\n Desafios práticos.");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(@"
                 /\
               |   |
               |   |===( )   //////
               |   |   |||  | o o|   Hit any key to continue...
               |___|    ||| ( c  )                  ____
                         ||| \= /                  ||   \_
                          ||||||                   ||     |
                          ||||||                ...||__/|-´
                          ||||||             __|________|__
                            |||             |______________|
                            |||             || ||      || ||
                            |||             || ||      || ||
    ------------------------|||-------------||-||------||-||-------
                            |__>            || ||      || ||
    ");
    Console.ResetColor();
}
exibiTitulo();
//=======================================================================

//string resultado = new AulaPratica1().VerificaCondicaoSaldo();
//Console.WriteLine($"\n{resultado}");
//=======================================================================

//new AulaPratica1().ExibiMSG();
//=======================================================================

//new AulaPratica1().ClassificacaoAluno();
//=======================================================================

//new AulaPratica1().VerificaAcesso();
//=======================================================================

//new AulaPratica1().ClassificaFaixaEtaria();
//=======================================================================

// Calculadora de operações básicas - Aula 2 Desafio 1
//new AulaPratica2().Calculadora();
//=============================================

//Saudação personalizada - Aula 2 Desafio 2
new AulaPratica2().SaudacaoPersonalizada();
//=============================================

//Sistema de recompensas - Aula 2 Desafio 3
new AulaPratica2().SistemaRecompensas();
//=============================================

//Refatorando a organização de livros - Aula 2 Desafio 4
new AulaPratica2().OrganizaLivros();
//=============================================

////Autenticação de usuário - Aula 2 Desafio 5
new AulaPratica2().AutentificaUsuario();