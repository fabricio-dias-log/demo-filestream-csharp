﻿using System.IO;

namespace DemoFileStream;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\temp\file.txt";
        StreamReader sr = null;

        try
        {
            sr = File.OpenText(path);

            string line = sr.ReadLine();

            Console.WriteLine(line);
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
        }
    }
}