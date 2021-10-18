using Aspose.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace converteImage2PDFusingAPi
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "C:\\Users\\shane.gracias\\Documents\\" + "cat.jpg";

            // Initialize new PDF document
            Document doc = new Document();

            // Add empty page in empty document
            Page page = doc.Pages.Add();
            Aspose.Pdf.Image image = new Aspose.Pdf.Image();
            image.File = (path);

            // Add image on a page
            page.Paragraphs.Add(image);

            // Save output PDF file
            doc.Save("C:\\Users\\shane.gracias\\Documents\\" + "ImagetoPDF.pdf");
        }
    }
}
