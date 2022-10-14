using System;
using System.Diagnostics;
using System.IO;
using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using PdfSharpCore.Utils;


namespace _101Bootcamp10APdfConverter
{
    internal class Program
    {

        // https://github.com/ststeiger/PdfSharpCore
        static void Main(string[] args)
        {
            Console.WriteLine("Type of the text you want converted to a PDF here ");
            string _text = Console.ReadLine();

            string _fileAndPath = @"D:\Temp\PDFCreateExampleCore.pdf";
            PdfSharpCoreConverter converter = new PdfSharpCoreConverter();
            converter.Convert(_text, _fileAndPath);
            Console.WriteLine("File location: {0}", _fileAndPath);
            Console.ReadKey();
        }
    }
}
