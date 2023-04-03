using System;

internal static class Program
{
    static void Main()
    {
        Person P = new Person("AGQY367683AGSDT239", "Qtsr356200910SG", "Jack", "Skywalker", "+12098567433", "skysky7@gmail.com", "male", "01.06.1999");
        P.ConsoleOutput();
        P.FileOutput("data.txt"); //повне розташування -> ...\bin\Debug\net6.0
    }
}