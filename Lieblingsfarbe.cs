//Schreibe ein Programm, das den Benutzer nach seiner Lieblingsfarbe fragt und dann eine entsprechende Nachricht ausgibt.

void printOptions()
{
    Console.WriteLine("\nWas ist deine Lieblingsfarbe? ");
    Console.WriteLine("1. Blau");
    Console.WriteLine("2. Schwarz");
    Console.WriteLine("3. Grün");
    Console.WriteLine("4. Lila/Pink");
    Console.WriteLine("5. Orange");
    Console.WriteLine("6. Rot");
    Console.WriteLine("7. Gelb");
    Console.WriteLine("8. Exit");
}

int option = 0;

do
{
    printOptions();
    try { option = int.Parse(Console.ReadLine()); }
    catch { }

    if (option == 1) { Console.WriteLine("\nAls typische Vernunftmenschen sind Blau-Liebhaber zwar ehrgeizig, " +
        "weisen aber keine unkontrollierbare Impulsivität auf. " +
        "In ihrer Besonnenheit liegt auch das Geheimnis ihres Erfolgs: " +
        "Sie treffen rational durchdachte Entscheidungen und verfolgen ihre Ziele hartnäckig. " +
        "Allerdings kann diese Hartnäckigkeit auch schon einmal zur Sturheit werden. " +
        "Blau-Typen gelten oftmals als loyale Freunde, die Rücksicht nehmen und sich auf ihr Gegenüber einlassen."); }
    else if (option == 2) { Console.WriteLine("\nSchwarz ist puristisch. Die klassischen Schwarz-Fans lieben klare Strukturen genauso sehr wie den Individualismus. " +
        "Einheitsbrei kommt für sie nicht in Frage; stattdessen bilden sie sich eine eigene Meinung."); }
    else if (option == 3) { Console.WriteLine("\nGrün steht für Kontinuität. Auf einen Grün-Liebhaber kann man sich in der Regel verlassen. " +
        "Mit ihrer ausgeglichenen Art sind sie aufmerksame Ratgeber, die ehrlich und einfühlsam argumentieren. " +
        "Über die angebliche Sturheit der naturverbundenen Grün-Fans kann man angesichts dieser positiven Eigenschaften leicht hinwegschauen."); }
    else if (option == 4) { Console.WriteLine("\nKünstlerische, spirituelle und kreative Veranlagung hat eine Farbe: Lila oder Violett. " +
        "Diese kann sich unterschiedlich äußern; so gehört Humor ebenso zu den Talenten des Lila-Fans wie auch Phantasie oder Sensibilität. " +
        "Sie können sich leicht in ihr Gegenüber hineinversetzen, sind aufgrund ihrer sensiblen Art aber auch schnell verletzt."); }
    else if (option == 5) { Console.WriteLine("\nStillsitzen macht Orange-Fetischisten keinen Spaß, sie brauchen Action. " +
        "Sport kann ein Ventil für ihre anhaltende Aktivität darstellen. Mit Orange-Typen wird es bestimmt nicht langweilig; " +
        "daher sind sie oftmals auch sehr beliebt. Tiefe Freundschaften können da allerdings manchmal auf der Strecke bleiben."); }
    else if (option == 6) { Console.WriteLine("\nRot ist Power. Rot-Fans wissen, was sie wollen und wie sie es durchsetzen. " +
        "Kritikfähigkeit ist nicht unbedingt ihre Stärke. Daher sollten Sie öfter mal ganz bewusst innehalten."); }
    else if (option == 7) { Console.WriteLine("\nSonne pur. Gelb-Liebhaber haben meist ein sehr sonniges und zufriedenes Gemüt. " +
        "Offen und humorvoll begegnen sie anderen und verfügen darum oft über einen großen Freundeskreis."); }
    else if (option == 8) { break; }
    else { Console.WriteLine("*** Gebe bitte einen gültigen Wert ein! ***"); }

}
while (option != 8);
Console.WriteLine("Bis zum nächsten Mal!");
