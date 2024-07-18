using System;

using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace ConsoleAppTin
{
    class Program
    {
        static void Main(string[] args)
        {
            var pdfPath = @"C:\TMP\Tel.pdf";
            PdfDocument document = PdfReader.Open(pdfPath);
            document.Info.Title = "";
            document.Info.CreationDate = new DateTime(2024,06,15);
            document.Info.ModificationDate = new DateTime(2024, 06, 15);
            document.Info.Author = "";
            document.Info.Elements.SetValue("ICNAppName", new PdfString("More Advanced Generator" ));
            document.Info.Application = "Advanced Generator";
            document.Info.Producer = @"iText® 5.4.4 ©2000-2013 1T3XT BVBA (AGPL-version)";
            document.PdfWriterLayout = PdfWriterLayout.Compact;

            //document.Info.Elements.Remove(PdfDocumentInformation.Keys.CreationDate);
            //document.Info.Elements.Remove(PdfDocumentInformation.Keys.ModDate);
            pdfPath = @"C:\TMP\Tel - after PdfSharp..pdf";
            document.Save(pdfPath);
        }
    }
}
