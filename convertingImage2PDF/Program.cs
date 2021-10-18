using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertingImage2PDF
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Document document = new Document();
            using (var stream = new FileStream("test.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                iTextSharp.text.pdf.PdfWriter.GetInstance(document, stream);
                document.Open();
                using (var imageStream = new FileStream("pokemon.png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = Image.GetInstance(imageStream);
                    document.Add(image);
                }
                document.Close();
            }



        }


    }
}
