string selectedMenu = Menu.ShowMenu();
bool show = selectedMenu == "";
while (show)
{
    selectedMenu = Menu.ShowMenu();
    show = selectedMenu == "";
}

internal class Menu
{
    public static string ShowMenu()
    {
        Console.Clear();
        string returnMessage = "";
        Console.WriteLine($"Dage tilbage på skole: {Time.PrintAndenInterval()}");
        Console.WriteLine("Vælg:");
        Console.WriteLine("1) Søg på Elev");
        Console.WriteLine("2) Søg på lærer");
        Console.WriteLine("3) Søg på Fag");
        Console.Write("\r\nVælg 1, 2 eller 3: ");
        Console.WriteLine();
        var choice = Console.ReadKey();
        switch (choice.Key)
        {
            case ConsoleKey.D1:
                Console.Clear();
                return PrintInfo(PersonInfo.Elev);
            case ConsoleKey.D2:
                Console.Clear();
                return PrintInfo(PersonInfo.Lærer);
            case ConsoleKey.D3:
                return PrintInfo(PersonInfo.Fag);
            default:
                Console.Clear();
                Console.WriteLine("Fejl. Forkert indtastet.");
                break;
        }
        return returnMessage;
    }

    public static string PrintInfo(PersonInfo p)
    {
        string returnMessage = "";
        switch (p)
        {
            case PersonInfo.Elev:
                return PrintElevInfo();
            case PersonInfo.Lærer:
                return PrintLærerInfo();
            case PersonInfo.Fag:
                return PrintFagInfo();
            default:
                Console.WriteLine("Fejl.");
                break;
        }
        return returnMessage;
    }
    public static string PrintElevInfo()
    {
        string returnMessage = "";
        try
        {
            Console.WriteLine("Hvad er elevID'et?");

            string? elevID = Console.ReadLine();

            SøgeKriterier.ElevInfo print = H1.GetElevInfo(elevID);
            //unboxing
            List<object> listAfFag = (List<object>)print.result1;
            List<object> listAfLærer = (List<object>)print.resultat2;
            for (int x = 0; x < listAfFag.Count; x++)
            {
                //læseligt
                string? fag = listAfFag[x].ToString();
                Console.WriteLine($"{fag}, {listAfLærer[x]}");
                Console.ReadKey();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Noget gik galt.");
        }
        return returnMessage;
    }
    public static string PrintLærerInfo()
    {
        string returnMessage = "";
        try
        {
            Console.WriteLine("Hvem er læreren?");

            string? lærer = Console.ReadLine();

            SøgeKriterier.ElevInfo printR = H1.GetLærerInfo(lærer);

            //unboxing
            List<object> listAfFag = (List<object>)printR.result1;
            List<object> listAfElever = (List<object>)printR.resultat2;

            for (int x = 0; x < listAfFag.Count; x++)
            {
                //læseligt
                string? fag = listAfFag[x].ToString();
                string ss = listAfElever[x].GetType().Name;
                List<ElevModel> elever = (List<ElevModel>)listAfElever[x];
                foreach (ElevModel elev in elever)
                {
                    Console.WriteLine($"{fag}, {elev.ForNavn} {elev.EfterNavn}");
                    Console.ReadKey();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Noget gik galt.");
        }
        return returnMessage;
    }
    public static string PrintFagInfo()
    {
        string returnMessage = "";
        try
        {
            Console.WriteLine("Hvad er dit fag?");

            string? fag = Console.ReadLine();

            SøgeKriterier.ElevInfo print = H1.GetFagInfo(fag);

            List<object> listAfLærer = (List<object>)print.result1;
            List<object> listAfElever = (List<object>)print.resultat2;

            for (int x = 0; x < listAfLærer.Count; x++)
            {
                string? lærer = listAfLærer[x].ToString();
                string ss = listAfElever[x].GetType().Name;
                List<ElevModel> elever = (List<ElevModel>)listAfElever[x];
                foreach (ElevModel elev in elever)
                {
                    Console.WriteLine($"{lærer}, {elev.ForNavn} {elev.EfterNavn}");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Noget gik galt.");
        }
        return returnMessage;
    }
}