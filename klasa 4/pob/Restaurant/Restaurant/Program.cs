namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Reservation> reservations = new List<Reservation>();
            int count = 1;
            bool running = true;
            Logger logger = Logger.GetInstance();  
            FileHandler fileHandler = new FileHandler();
            fileHandler.CreateFile();
            logger.Log("Aplikacja uruchomiona.");
            List<string> scheme = new List<string>();
            UIHandler uiHandler = new UIHandler();
            uiHandler.setAtMainScreen(true);
            scheme.Add("");
            scheme.Add("Witaj w systemie rezerwacji");
            scheme.Add("");
            scheme.Add("Możliwe opcje:");
            scheme.Add("1. Zarezerwuj pojedynczy stolik");
            scheme.Add("2. Zarezerwuj całą salę");
            scheme.Add("3. Wyświetl aktualne rezerwacje");
            scheme.Add("4. Wyświetl aktualny log");
            scheme.Add("");
            scheme.Add("Naciśnij Q, aby wyjść");
            scheme.Add("");

            uiHandler.SetScheme(scheme);
            uiHandler.DrawUI();

            while (running)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        uiHandler.setAtMainScreen(false);
                        Console.Clear();
                        Console.Write("Podaj dane rezerwującego: ");
                        string nameTable = Console.ReadLine();

                        Console.Write("Podaj datę (yyyy-MM-dd domyślnie na jutro): ");
                        string data = Console.ReadLine();
                        if (DateTime.TryParse(data, out DateTime dateTable))
                        {
                            dateTable = DateTime.Parse(data);
                        }
                        else
                        {
                            dateTable = DateTime.Now.AddDays(1);
                        }
                        Reservation reservationTable = ReservationFactory.Create(1);

                        reservationTable = new ReservationBuilder(reservationTable)
                            .SetName(nameTable)
                            .SetType("Stolik")
                            .SetDate(dateTable)
                            .SetReservationNumber(count)
                            .Build();
                        reservations.Add(reservationTable);
                        Console.Clear();
                        uiHandler.DrawUI();
                        break;

                    case "2":
                        uiHandler.setAtMainScreen(false);
                        Console.Clear();
                        Console.Write("Podaj dane rezerwującego: ");
                        string nameWhole = Console.ReadLine();

                        Console.Write("Podaj datę (yyyy-MM-dd domyślnie na jutro): ");
                        string data2 = Console.ReadLine();
                        if (DateTime.TryParse(data2, out DateTime dateWhole))
                        {
                            dateWhole = DateTime.Parse(data2);
                        }
                        else
                        {
                            dateWhole = DateTime.Now.AddDays(1);
                        }

                        Reservation reservationWhole = ReservationFactory.Create(2);

                        reservationWhole = new ReservationBuilder(reservationWhole)
                            .SetName(nameWhole)
                            .SetType("Stolik")
                            .SetDate(dateWhole)
                            .SetReservationNumber(count)
                            .Build();
                        reservations.Add(reservationWhole);
                        Console.Clear();
                        uiHandler.DrawUI();
                        break;

                    case "3":
                        uiHandler.setAtMainScreen(false);
                        Console.Clear();
                        foreach (var reservation in reservations)
                        {
                            Console.WriteLine(reservation.ReservationNumber + " " + reservation.Name + " " + reservation.Type + " "+ reservation.Date);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        uiHandler.setAtMainScreen(true);
                        break;
                    case "4":
                        uiHandler.setAtMainScreen(false);
                        Console.Clear();
                        var lines = fileHandler.ReadFile();
                        foreach ( var line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        uiHandler.setAtMainScreen(true);
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        uiHandler.DrawUI();
                        break;
                }
            }
        }
    }
}
