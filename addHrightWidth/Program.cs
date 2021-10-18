using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addHrightWidth
{
    class Program
    {
        static void Main(string[] args)
        {
            iTextSharp.text.Rectangle pageSize = null;

            using (var srcImage = new Bitmap("C:\\Users\\shane.gracias\\Documents\\cat.jpg"))
            {
                pageSize = new iTextSharp.text.Rectangle(0, 0, srcImage.Width, srcImage.Height);
            }

            using (var ms = new MemoryStream())
            {
                var document = new iTextSharp.text.Document(pageSize, 0, 0, 0, 0);
                iTextSharp.text.pdf.PdfWriter.GetInstance(document, ms).SetFullCompression();
                document.Open();
                var image = iTextSharp.text.Image.GetInstance("C:\\Users\\shane.gracias\\Documents\\cat.jpg");
                document.Add(image);
                document.Close();

                File.WriteAllBytes("C:\\Users\\shane.gracias\\Documents\\cheque.pdf", ms.ToArray());
            }
        }
    }
}
