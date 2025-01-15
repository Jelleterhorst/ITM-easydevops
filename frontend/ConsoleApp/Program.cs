// See https://aka.ms/new-console-template for more information
Console.WriteLine("                 EasyDevOps");
Console.WriteLine("               .+@-...  . .-@=                ");
Console.WriteLine("           .@                    @.           ");
Console.WriteLine("         %                          @         ");
Console.WriteLine("      .-                              *       ");
Console.WriteLine("     %                                  @     ");
Console.WriteLine("   .                                     ..   ");
Console.WriteLine("  =                                       ..  ");
Console.WriteLine(" ..                                        .. ");
Console.WriteLine(" = ####. -#############..######.   *#####=  # ");
Console.WriteLine("+ .****. -*************..******#  .******-   .");
Console.WriteLine("% .****.     .****+.... .***#***. ***#***-   %");
Console.WriteLine("= .****.     .****+ ..  .***#***#.#*##***-   %");
Console.WriteLine("+ .****.      ****+     .***#.******.#***-   %");
Console.WriteLine("% .****.      ****+.    .***#.*****# ****-   @");
Console.WriteLine("= .****.     .****+..   .***#..****. ****-   .");
Console.WriteLine(".=.++++.      ****=     .***+  *+++. ++++-. %.");
Console.WriteLine(" ..                                        .. ");
Console.WriteLine("  -                                       ..  ");
Console.WriteLine("   ..                                    :.   ");
Console.WriteLine("     %                                  @     ");
Console.WriteLine("      .+                              %.      ");
Console.WriteLine("        .@                         .@         ");
Console.WriteLine("           .@                   .@            ");
Console.WriteLine("               .-@*..    ..#@:                ");
Console.WriteLine("");
Console.WriteLine("                  EasyDevOps");
Console.WriteLine("                  Ohja en Bram kan niet dammen -Sven F.");


Console.WriteLine("Some information");

            Pause(5000, "Press any key or let me rest for 5 seconds...");

            Console.WriteLine("Some other information");


static void Pause(int waitinmillsec, string promptText = "Press a key to continue...")
    {
        Console.WriteLine(promptText);
        try
        {
            Thread t = new Thread(x => Console.ReadKey());
            t.Start();
            t.Join(waitinmillsec);
        }
        catch (ThreadAbortException)
        {

        }
    }