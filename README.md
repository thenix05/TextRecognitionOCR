# TextRecognitionOCR

Konsolenanwendung in C#, die Text aus einem Bild liest. Sie nutzt die Tesseract-OCR-Engine über das NuGet-Paket Tesseract und gibt den erkannten Text sowie die Zuverlässigkeit der Erkennung aus.

Entstanden als Übungsprojekt während der Informatikmittelschule, um zu verstehen, wie Texterkennung funktioniert und wie zuverlässig sie bei unterschiedlichen Vorlagen ist.

## Verwendung

```
TextRecognition <bildpfad> [tessdata-ordner] [sprache]
```

Aus dem Wurzelverzeichnis des Repositorys genügt:

```
TextRecognition Auto3.png
```

Ausgabe:

```
GR·999999
Zuverlaessigkeit: 87.4 %
```

Ohne Angaben werden `Auto3.png`, der Ordner `testDataPath` und die Sprache `deu` verwendet.

## Voraussetzungen

- .NET SDK
- NuGet-Paket `Tesseract`
- Die passende Sprachdatei im tessdata-Ordner, hier `deu.traineddata` in `testDataPath`

## Testbilder

Im Repository liegen Aufnahmen von Schweizer Kontrollschildern mit der Musternummer 999999 sowie ein Flyer der Informatikmittelschule. Sie enthalten keine echten Halterdaten.

## Was ich dabei gelernt habe

- Die Erkennungsqualität hängt stark von Kontrast und Schriftgrösse ab. Beim Flyer war die Zuverlässigkeit deutlich höher als beim Kontrollschild.
- `GetMeanConfidence` liefert einen Durchschnittswert über die erkannten Wörter. Ein hoher Wert heisst nicht automatisch, dass der Text stimmt.
- Tesseract erwartet die Sprachdateien in einem eigenen Ordner. Ein falsch gesetzter Pfad führt schon beim Erstellen der Engine zu einer Exception, nicht erst beim Verarbeiten.

## Nächste Schritte

- Mehrere Bilder in einem Durchlauf verarbeiten
- Vorverarbeitung testen (Graustufen, Schwellenwert) und messen, ob die Zuverlässigkeit steigt
