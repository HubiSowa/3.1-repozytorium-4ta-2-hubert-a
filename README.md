# Minutnik Zadanie 3.1

Aplikacja typu Pomodoro w technologii Avalonia (.NET 8). Cała logika znajduje się w jednym pliku MainWindow.axaml.cs, a aplikacja posiada zaimplementowaną historię cykli.

## 1. Dane i pomiary z lekcji (stan na pażdziernik 2026)
* **Narzędzie AI:** Claude / ChatGPT
* **Data pomiaru:** 2026-10-28
* **Rozmiar pierwszej wiadomości (po polsku):** ok. 150 tokenów
* **Rozmiar pierwszej wiadomości (po angielsku):** ok. 120 tokenów
* **Okno kontekstu modelu:** 1 000 000 tokenów ([Dokumentacja modeli](https://platform.claude.com/docs/en/models/overview))
* **Maksymalna długość odpowiedzi (Max output):** 128 000 tokenów ([Dokumentacja modeli](https://platform.claude.com/docs/en/models/overview))

## 2. Wynik testu wprowadzania liczb (25,5 vs 25.5)
* **Wartość 25,5 (z przecinkiem):** Aplikacja poprawnie sparsowała wartość dzięki zamianie separatora.
* **Wartość 25.5 (z kropką):** Aplikacja również poprawnie sparsowała wartość (dzięki metodzie .Replace('.', ',')).

## Rozbiór promptu z pokazu
- [CO / JAK / PO CZYM POZNAĆ] [linia 1 promptu z pokazu]
- [CO / JAK / PO CZYM POZNAĆ] [linia 2 promptu z pokazu]

Liczby: CO — [A], JAK — [B], PO CZYM POZNAĆ — [C].
Najmniej jest zdań typu [kategoria z najmniejszą liczbą], ponieważ [powód].

## Reset w środku przerwy a licznik cykli
Po naciśnięciu „Reset” w środku przerwy aplikacja zatrzymuje odliczanie, przełącza na „Praca”, przywraca czas z pola pracy i nie zeruje licznika cykli — to decyzja modelu, ponieważ żadna reguła nie określała wyzerowania licznika przy resecie.
## Rozbiór promptu z pokazu
- [CO] Zbuduj minutnik w tym projekcie Avalonia.
- [CO] Ma odmierzać 25 minut pracy, potem 5 minut przerwy, i liczyć skończone cykle.
- [CO] Obie długości mają być do zmiany w oknie.
- [CO] Jeden przycisk start/pauza, drugi reset.
- [PO CZYM POZNAĆ] Czas widoczny jako mm:ss, licznik cykli widoczny obok.
- [PO CZYM POZNAĆ] Po skończonej pracy przerwa ma ruszyć sama.
- [JAK] Interfejs po polsku, nazwy w kodzie po angielsku, bez dodatkowych bibliotek.
- [JAK] Cała logika wprost w pliku MainWindow.axaml.cs, bez osobnych klas pośredniczących.

Liczby: CO — 4, JAK — 2, PO CZYM POZNAĆ — 2.
Najmniej jest zdań typu JAK / PO CZYM POZNAĆ, ponieważ prompt skupia się głównie na określeniu funkcji minutnika, a warunki brzegowe i szczegóły techniczne doprecyzowuje się w kolejnych krokach.

## Reset w środku przerwy a licznik cykli
Po naciśnięciu „Reset” w środku przerwy aplikacja zatrzymuje odliczanie, przełącza na „Praca”, przywraca czas z pola pracy i nie zeruje licznika cykli — to decyzja modelu, ponieważ żadna reguła nie określała wyzerowania licznika przy resecie.