using System;
using System.Collections.Generic;
using System.Text;
using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using PdfSharpCore.Utils;


namespace _101Bootcamp10APdfConverter
{
    internal class PdfSharpCoreConverter
    {

        internal void Convert(string inTextToConvert, string inPathAndFile)
        {
            GlobalFontSettings.FontResolver = new FontResolver();

            var document = new PdfDocument();
            var page = document.AddPage();

            var gfx = XGraphics.FromPdfPage(page);
            var font = new XFont("Arial", 20, XFontStyle.Bold);

            var textColor = XBrushes.Black;
            var layout = new XRect(20, 20, page.Width, page.Height);
            var format = XStringFormats.Center;

            string _text = "Hello World!";

            if (inTextToConvert != null) 
            {
                _text = inTextToConvert;
            }

            gfx.DrawString(_text, font, textColor, layout, format);

            string fileAndPath;

            if (inPathAndFile != null)
            {
                fileAndPath = inPathAndFile;
            }
            else 
            { 
                fileAndPath = @"C:\Temp\PDFCreateExampleCore.pdf"; 
            }
            document.Save(fileAndPath);
        }

    }
}
