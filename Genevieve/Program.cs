using Figgle;

// The string we want to use to print out into the console window.
String genevieve = "Happy Birthday Genevieve!!!!";

// A thread so that this code can launch without freezing up the console window.
new Thread(new ThreadStart(() =>
{
    // An array of colors so we can randomly choose a color for a word or character.
    System.Drawing.Color[] colors = { System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, System.Drawing.Color.Yellow, System.Drawing.Color.OrangeRed, System.Drawing.Color.Aqua, System.Drawing.Color.Beige };

    // Tell the application to try this, if it fails, do something else in the catch statement.
    try
    {
        // Read the Cake.txt file into a string array.
        String[] cakeFile = File.ReadAllLines("Cake.txt", System.Text.Encoding.Unicode);

        // Iterate through the lines
        foreach (String s in cakeFile)
        {
            // Iterate through the characters in the line
            foreach (char c in s)
            {
                // Output pretty colorful characters that will be the contents of the Cake.txt
                Colorful.Console.Write(c, colors[new Random().Next(colors.Length)]);

                // Small 10ms pause in between each character
                Thread.Sleep(10);
            }

            // Print a blank line each time we get a new line from the array.
            Console.WriteLine(String.Empty);
        }
    } catch (Exception)
    {
        // Uh-oh! We couldn't find the file, so let's output some text to let the user know we're missing or can't read the file.
        Colorful.Console.WriteLine("I couldn't print out the cake because the Cake.txt file is missing or unreadable.", System.Drawing.Color.OrangeRed);
    }

    // Create a colorful pyramid of text
    for (int j = 0; j < 5; j++)
    {
        for (int i = 0; i < genevieve.Length; i++)
        {
            Colorful.Console.WriteLine(genevieve.Substring(0, i), colors[new Random().Next(colors.Length)]);
            Thread.Sleep(100);
        }

        for (int i = genevieve.Length; i > 0; i--)
        {
            Colorful.Console.WriteLine(genevieve.Substring(0, i), colors[new Random().Next(colors.Length)]);
            Thread.Sleep(100);
        }
    }

    for (int i = 0; i < 5; i++)
    {
        foreach (char c in genevieve)
        {
            Colorful.Console.Write(c, colors[new Random().Next(colors.Length)]);
            Thread.Sleep(10);
        }

        Console.WriteLine(String.Empty);
    }

    String[] gen2 = genevieve.Split(" ");

    foreach (string s in gen2)
    { 
        Console.WriteLine(FiggleFonts.Ghost.Render(s));
        Thread.Sleep(1000);
    }

    foreach (string s in gen2)
    {
        Console.WriteLine(FiggleFonts.Epic.Render(s));
        Thread.Sleep(1000);
    }

    foreach (string s in gen2)
    {
        Console.WriteLine(FiggleFonts.Doom.Render(s));
        Thread.Sleep(1000);
    }

    foreach (string s in gen2)
    {
        Console.WriteLine(FiggleFonts.DRPepper.Render(s));
        Thread.Sleep(1000);
    }

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    
    Console.WriteLine(FiggleFonts.Epic.Render("I love you"));
    Thread.Sleep(1000);
    Console.WriteLine(FiggleFonts.Epic.Render("and hope this"));
    Thread.Sleep(1000);
    Console.WriteLine(FiggleFonts.Epic.Render("is the BEST"));
    Thread.Sleep(1000);
    Console.WriteLine(FiggleFonts.Epic.Render("birthday"));
    Thread.Sleep(1000);
    Console.WriteLine(FiggleFonts.Epic.Render("ever!!!"));

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(String.Empty);
    }

})).Start();    // Start the thread.

// Wait for the user to press a key before exiting the application.
Console.ReadKey();
