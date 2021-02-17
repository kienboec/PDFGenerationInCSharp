using System.IO;
using DinkToPdf;

namespace PDFGenerationInCSharp
{
    class Program
    {
        public static readonly string HTMLPage = @"
<html>
<head><title>Test Page for generation</title></head>
<body>
<h1>Example</h1>
<p>... if you can read this, you won the generation game</p>
</body>
</html>
";



        static void Main(string[] args)
        {
            // iText7Demo_not_working.CreatePDF();
            // iText7Demo_not_working.ConvertHTML();

            // https://github.com/rdvojmoc/DinkToPdf
            // https://github.com/rdvojmoc/DinkToPdf/tree/master/v0.12.4/64%20bit
            var converter = new BasicConverter(new PdfTools());
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Landscape,
                    PaperSize = PaperKind.A4Plus,
                    Out = @"test.pdf",
                },
                Objects = {
                    new ObjectSettings() {
                        PagesCount = true,
                        HtmlContent = HTMLPage,
                        WebSettings = { DefaultEncoding = "utf-8" },
                        HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 },
                        
                    }
                }
            };
            converter.Convert(doc);
        }
    }
}
