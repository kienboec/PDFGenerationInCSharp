using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Html2pdf;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace PDFGenerationInCSharp
{
    public class iText7Demo_not_working
    {
        //https://kb.itextpdf.com/home/it7kb/examples/itext-7-jump-start-tutorial-chapter-1#c01e01_helloworld.cs
        public static void CreatePDF()
        {
            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter("demo.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("HEADER")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);

            document.Add(header);
            document.Close();
        }

        public static void ConvertHTML()
        {
            File.WriteAllText("input.html", Program.HTMLPage);

            // https://github.com/itext/i7n-pdfhtml
            // https://itextpdf.com/en/products/itext-7/convert-html-css-to-pdf-pdfhtml
            using Stream htmlSource = File.Open("input.html", FileMode.Open);
            using FileStream pdfDest = File.Open("output.pdf", FileMode.OpenOrCreate);
            ConverterProperties converterProperties = new ConverterProperties();
            HtmlConverter.ConvertToPdf(htmlSource, pdfDest, converterProperties);
        }
    }
}
