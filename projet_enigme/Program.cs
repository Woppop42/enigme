// See https://aka.ms/new-console-template for more information
using System.Text;

UTF8Encoding utf8 = new UTF8Encoding();
string pseudo;
int point;
string enigme1 = "Plus elle est grande, moins on la voit. Qui est-elle ?";
string enigme2 = "Sitôt que l’on me nomme je n’existe plus. Qui suis-je ?";
string enigme3 = "J'ai la tête rouge ou rose lorsque je suis parmi mes semblables. Une fois utilisée ma tête est noire. Qui suis-je ?";
// Ajouter des indices
Console.WriteLine("Bienvenue dans le jeu de l'énigme ! Quel est ton pseudo ?");
 pseudo = Console.ReadLine();
Console.WriteLine("Bienvenue " + pseudo + " ! Commençons sans tarder !");
premiereEnigme();
 string premiereEnigme() {

    Console.WriteLine(enigme1);
    string reponse1 = Console.ReadLine();
    if (reponse1 == "L'obscurité")
    {
        Console.WriteLine("Bravo ! Tu as gagné 10 points ! Passonss à l'énigme suivante");
    }
    else
    {
        Console.WriteLine("Mauvaise réponse !");
        Console.WriteLine(enigme1);

    }

    return reponse1;
}
deuxiemeEnigme();
string deuxiemeEnigme() {
    Console.WriteLine(enigme2);
    string reponse2 = Console.ReadLine();
    if (reponse2 == "Le silence")
    {
        Console.WriteLine("Bravo ! Tu as gagné 10 points ! Passons à l'énigme suivante !");
    }
    else
    {
        Console.WriteLine("Mauvaise Réponse !");
        Console.WriteLine(enigme2);
    }
    return reponse2;
}




