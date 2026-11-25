using Tesseract;

namespace TextRecognition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imagePath = args.Length > 0 ? args[0] : "Auto3.png";
            string tessDataPath = args.Length > 1 ? args[1] : "testDataPath";
            string language = args.Length > 2 ? args[2] : "deu";

            if (!File.Exists(imagePath))
            {
                Console.Error.WriteLine($"Bild nicht gefunden: {imagePath}");
                Console.Error.WriteLine("Aufruf: TextRecognition <bildpfad> [tessdata-ordner] [sprache]");
                return;
            }

            // OCR-Engine erstellen
            using TesseractEngine engine = new(tessDataPath, language);
            // Laedt Bild als Pix-Objekt, Tesseract eigenes Bildformat
            using var img = Pix.LoadFromFile(imagePath);
            // Texterkennung auf img
            using var page = engine.Process(img);
            string readableText = page.GetText();

            Console.WriteLine(readableText.Trim());
            Console.WriteLine($"Zuverlaessigkeit: {page.GetMeanConfidence():P1}");
        }
    }
}
