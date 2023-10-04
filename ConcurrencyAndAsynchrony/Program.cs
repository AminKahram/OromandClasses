using ConcurrencyAndAsynchrony.Create_StartThread;

CharPrinter charPrinter = new CharPrinter();

Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
dashPrinterWorker.Name = "Abbas";

Console.WriteLine($"{dashPrinterWorker.Name} is alive before start {dashPrinterWorker.IsAlive}");

dashPrinterWorker.Start();
Console.WriteLine($"{dashPrinterWorker.Name} is alive after start {dashPrinterWorker.IsAlive}");

charPrinter.PrintStar();

Console.WriteLine($"{dashPrinterWorker.Name} is alive after print star start {dashPrinterWorker.IsAlive}");

Console.ReadLine();

Console.WriteLine($"{dashPrinterWorker.Name} is alive after print star start {dashPrinterWorker.IsAlive}");

Console.ReadLine();