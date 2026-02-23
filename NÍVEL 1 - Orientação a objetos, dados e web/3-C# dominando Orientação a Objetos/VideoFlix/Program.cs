////exercício prático sobre namespace.
//using VideoFlix.PlataformaA;
//using VideoFlix.PlataformaB;

////Como resolver o conflito de nomes entre as classes Video das duas plataformas?
//VideoFlix.PlataformaA.Video videoA = new("Plataforma A");
//VideoFlix.PlataformaB.Video videoB = new("Plataforma B");

//agora escrito usando aliases:
using VideoA = VideoFlix.PlataformaA.Video;
using VideoB = VideoFlix.PlataformaB.Video;

VideoA videoA = new("Plataforma A");
VideoB videoB = new("Plataforma B");

//Aula 1 - Faça como eu fiz: organização de código como boa prática
Console.WriteLine("\nAula 1 - Faça como eu fiz: organização de código como boa prática");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Video A: {videoA.NomePlataforma}");
Console.WriteLine($"Video B: {videoB.NomePlataforma}");
Console.ResetColor();