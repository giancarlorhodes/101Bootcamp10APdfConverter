using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101Bootcamp10APdfConvertNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
             /// http://www.pdfsharp.net/wiki/HelloWorld-sample.ashx
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            PdfSharp.Drawing.XFont font = new PdfSharp.Drawing.XFont("Verdana", 14, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString("I am using PdfSharp !!!, .NET 4.8, Core .NET 5 thru exception", font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.Center);

            // TODO - how to do line breaks ????
            //gfx.DrawString("http://www.pdfsharp.net/wiki/HelloWorld-sample.ashx\n", font, XBrushes.Black,
            //new XRect(0, 0, page.Width, page.Height),
            //XStringFormats.Center);
            //gfx.DrawString(".NET 4.8, core 3.1 thru an error\n", font, XBrushes.Black,
            //new XRect(0, 0, page.Width, page.Height),
            //XStringFormats.Center);

            // Save the document...
            const string filename = "HelloWorld.pdf";
            document.Save(filename);

            // ...and start a viewer.
            Process.Start(filename);

        }
    }
}
