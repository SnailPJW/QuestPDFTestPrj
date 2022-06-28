using QuestPDF.Fluent;
using System.IO;

namespace QuestPDFTestPrj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var model = InvoiceDocumentDataSource.GetInvoiceDetails();
            var document = new InvoiceDocument(model);

            // Generate PDF file and show it in the default viewer
            //GenerateDocumentAndShow(document);
            GenerateDocumentAndShow2(document);
        }
        static void GenerateDocumentAndShow2(InvoiceDocument document)
        {
            const string filePath = "invoice.pdf";

            byte[] pdfByte = document.GeneratePdf();

            File.WriteAllBytes(filePath, pdfByte);

        }
    }
}
