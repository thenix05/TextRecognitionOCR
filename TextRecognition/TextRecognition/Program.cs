using Tesseract;

namespace TextRecognition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testDataPath = @"C:\Users\tseri\source\repos\TextRecognitionOCR\testDataPath";
            string imagePage = @"C:\Users\tseri\source\repos\TextRecognitionOCR\SG_Kontrollschild.png";


            using TesseractEngine engine = new(testDataPath, "eng");
            using var img = engine.Process(Pix.LoadFromFile(imagePage));
            string readableText = img.GetText();
            Console.WriteLine($"d{readableText}");

        }
    }
}
