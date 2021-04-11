using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinkToPdf;

namespace PDFGenerationInCSharp
{
    public class DinkToPDFDemo
    {
        public static void CreatePDFFromHtml(string htmlPage)
        {
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
                        HtmlContent = htmlPage,
                        WebSettings = { DefaultEncoding = "utf-8" },
                        HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 },

                    }
                }
            };
            converter.Convert(doc);
        }
    }
}
