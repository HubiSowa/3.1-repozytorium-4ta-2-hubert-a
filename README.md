# Minutnik � Zadanie 3.1

Aplikacja typu Pomodoro w technologii Avalonia (.NET 8). Cała logika znajduje się w jednym pliku MainWindow.axaml.cs, a aplikacja posiada zaimplementowaną historię cykli.

## 1. Dane i pomiary z lekcji (stan na pa�dziernik 2026)
* **Narzędzie AI:** Claude / ChatGPT
* **Data pomiaru:** 2026-10-28
* **Rozmiar pierwszej wiadomości (po polsku):** ok. 150 tokenów
* **Rozmiar pierwszej wiadomości (po angielsku):** ok. 120 tokenów
* **Okno kontekstu modelu:** 1 000 000 tokenów ([Dokumentacja modeli](https://platform.claude.com/docs/en/models/overview))
* **Maksymalna długość odpowiedzi (Max output):** 128 000 tokenów ([Dokumentacja modeli](https://platform.claude.com/docs/en/models/overview))

## 2. Wynik testu wprowadzania liczb (25,5 vs 25.5)
* **Wartość 25,5 (z przecinkiem):** Aplikacja poprawnie sparsowała wartość dzięki zamianie separatora.
* **Wartość 25.5 (z kropką):** Aplikacja również poprawnie sparsowała wartość (dzięki metodzie .Replace('.', ',')).
