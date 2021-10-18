using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace pdfsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfDocument doc = new PdfDocument();

            doc.Pages.Add(new PdfPage());

            XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[0]);

            XImage img = XImage.FromFile("C:\\Users\\shane.gracias\\Documents\\cat.jpg");

            xgr.DrawImage(img, 0, 0);

            doc.Save("C:\\Users\\shane.gracias\\Documents\\rat.pdf");

            doc.Close();
        }
    }
}
