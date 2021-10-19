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
            //PdfDocument doc = new PdfDocument();

            //doc.Pages.Add(new PdfPage());

            //XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[0]);

            //XImage img = XImage.FromFile("C:\\Users\\shane.gracias\\Documents\\cat.jpg");

            //xgr.DrawImage(img, 0, 0);

            //doc.Save("C:\\Users\\shane.gracias\\Documents\\rat.pdf");

            //doc.Close();

            using (var document = new PdfDocument())
            {
                PdfPage page = document.AddPage();
                using (XImage img = XImage.FromFile("C:\\Users\\shane.gracias\\Documents\\pokemon.png"))
                {
                    int width = 600;
                    // Calculate new height to keep image ratio
                    var height = (int)(((double)width / (double)img.PixelWidth) * img.PixelHeight);

                    // Change PDF Page size to match image
                    page.Width = width;
                    page.Height = height;

                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    gfx.DrawImage(img, 0, 0, width, height);
                }
                document.Save("C:\\Users\\shane.gracias\\Documents\\bigcat1.pdf");
            }
        }
    }
}
