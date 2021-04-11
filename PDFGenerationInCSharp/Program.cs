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
            // AGPL License! https://youtu.be/QHF3xcWnSD4
            iText7Demo.CreatePDF();
            DinkToPDFDemo.CreatePDFFromHtml(HTMLPage);            
        }
    }
}
