# TextRecognitionOCR

Konsolenanwendung in C#, die Text aus einem Bild liest. Sie nutzt die Tesseract-OCR-Engine über das NuGet-Paket Tesseract und gibt den erkannten Text sowie die Zuverlässigkeit der Erkennung aus.

Entstanden als Übungsprojekt während der Informatikmittelschule, um zu verstehen, wie Texterkennung funktioniert und wie zuverlässig sie bei unterschiedlichen Vorlagen ist.

## Verwendung

```
TextRecognition <bildpfad> [sprache]
```

Beispiel:

```
TextRecognition images/Auto3.png deu
```

Ausgabe:

```
GR·999999
Zuverlässigkeit: 87.4 %
```

Ohne Sprachangabe wird `deu` verwendet.

## Voraussetzungen

- .NET SDK
- NuGet-Paket `Tesseract`
- Im Ordner `tessdata` die passende Sprachdatei, zum Beispiel `deu.traineddata`

## Testbilder

Die Bilder zeigen Schweizer Kontrollschilder mit der Musternummer 999999 sowie einen Flyer der Informatikmittelschule. Sie enthalten keine echten Halterdaten.

## Was ich dabei gelernt habe

- Die Erkennungsqualität hängt stark von Kontrast und Schriftgrösse ab. Beim Flyer war die Zuverlässigkeit deutlich höher als beim Kontrollschild.
- `GetMeanConfidence` liefert einen Durchschnittswert über die erkannten Wörter. Ein hoher Wert heisst nicht automatisch, dass der Text stimmt.
- Tesseract erwartet die Sprachdateien in einem eigenen Ordner. Ein falsch gesetzter Pfad führt schon beim Erstellen der Engine zu einer Exception, nicht erst beim Verarbeiten.

## Nächste Schritte

- Mehrere Bilder in einem Durchlauf verarbeiten
- Vorverarbeitung testen (Graustufen, Schwellenwert) und messen, ob die Zuverlässigkeit steigt
