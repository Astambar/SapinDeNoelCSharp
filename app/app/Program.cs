string Pyramide(int hauteur, string corps = "*")
{
    string drawPyramide = "";
    string decorateur = string.Empty;
    string decorateur2 = string.Empty;
    string tempLine = string.Empty;
    int countPhase = 0;
    for (int i = hauteur; i > 0; i--)
    {
        countPhase++;
        decorateur = DecoratorDim(i," ");
        tempLine = DecoratorCorpsDim(countPhase, corps);
        drawPyramide += $"{decorateur}{tempLine}\n";
    }
    return drawPyramide;
}
string Tronc(int hauteur, string troncDecorator = "|")
{
    string tronc = string.Empty;
    if (hauteur % 3 == 0)
    {        
        if (hauteur >= 3)
            for (int i = 0; i < hauteur / 3; i++)
            {
                tronc += troncDecorator;
            }
    }
    else
    {
        for (; hauteur % 3 != 0; hauteur++)
            ;
        return Tronc(hauteur,troncDecorator);
    }
    return tronc;
}
string Sapin(string pyramide ,string tronc)
{
    return pyramide + tronc;
}

string DecoratorDim(int longueur, string character )
{
    string decorateur = string.Empty;
    for (int i = 0; i < longueur - 1; i++)
    {
        decorateur += character;
    }
    return decorateur;
}
string DecoratorCorpsDim(int longueur, string character)
{
    string decorateur = string.Empty;
    for (int i = 0; i < longueur * 2 - 1; i++)
    {
        decorateur += character;
    }
    return decorateur;
}


while(true)
{
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, 0);
    Console.Write(Tronc(4));
    Thread.Sleep(17);
}