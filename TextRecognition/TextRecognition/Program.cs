using Tesseract;

namespace TextRecognition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tessDataPath = @"C:\Users\tseri\source\repos\TextRecognitionOCR\testDataPath";
            string imagePage = @"C:\Users\tseri\source\repos\TextRecognitionOCR\Auto3.png";
            // Erstellung OCR-Engine   
            using TesseractEngine engine = new(tessDataPath, "deu");
            //Lädt Bild als Pix-Objekt, Tesseract eigenes Bildformat 
            using var img = Pix.LoadFromFile(imagePage);
            //Texterkennung auf img 
            using var page = engine.Process(img);  
            string readableText = page.GetText(); 

            Console.WriteLine($"{readableText}");
            Console.WriteLine($"{page.GetMeanConfidence()}");

 
        }
    }
}
