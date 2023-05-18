using System.IO;

Console.WriteLine("Hello, World");

string fileName = @"C:\Users\ckomati\source\repos\multitasking\multitasking\bin\Debug\net6.0\srija.txt";
FileInfo fi = new FileInfo(fileName);
try
{
    if (fi.Exists)
    {
        fi.Delete();
    }
    using (StreamWriter sw = fi.CreateText())
    {
        sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
        sw.WriteLine("Author: Srija");
        sw.WriteLine("Add one more line");
        sw.WriteLine("Add one more line ");
        sw.WriteLine("Done!");
    }
    using (StreamReader sr = File.OpenText(fileName))
    {
        string s = "";
        while ((s = sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
        
    
