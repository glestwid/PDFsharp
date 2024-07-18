using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pdfPath = @"C:\TMP\BofA BULLZIP.pdf";
            PdfDocument document = PdfReader.Open(pdfPath);
            //document.Info.CreationDate = DateTime.MinValue;
            //document.Info.ModificationDate = DateTime.MinValue;
            document.Info.Author = "Bank of America";
            document.Info.Application = "Bank of America";
            document.Info.Producer = "TargetStream StreamEDS rv1.7.41 for Bank of America";
            document.PdfWriterLayout = PdfWriterLayout.Compact;

            document.Info.Elements.Remove(PdfDocumentInformation.Keys.CreationDate);
            document.Info.Elements.Remove(PdfDocumentInformation.Keys.ModDate);
            pdfPath = @"C:\TMP\BofA - BULLZIP - after PdfSharp.pdf";
            document.Save(pdfPath);
        }
    }
}
