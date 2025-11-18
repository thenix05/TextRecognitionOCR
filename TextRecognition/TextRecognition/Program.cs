using Tesseract;

namespace TextRecognition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testDataPath = @"C:\Users\tseri\source\repos\TextRecognitionOCR\testDataPath";
            string imagePage = @"C:\Users\tseri\source\repos\TextRecognitionOCR\Auto3.png";

            using TesseractEngine engine = new(testDataPath, "eng");
            using var img = Pix.LoadFromFile(imagePage);
            using var page = engine.Process(img);
            string readableText = page.GetText();

            Console.WriteLine($"{readableText}");
            Console.WriteLine($"{page.GetMeanConfidence()}");


        }
    }
}
