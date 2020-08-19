﻿using System;

namespace PdfiumPrinter.Demo
{
    class Program
    {
        private const string printFile = "sha1good.pdf";

        static void Main(string[] args)
        {
            var printer = new PdfPrinter("PDF-XChange Standard");
            printer.Print(printFile);
            printer.Print(printFile, documentName: "with name");
            Console.WriteLine("The files were succesfully printed.");
            Console.ReadKey();
        }
    }
}
