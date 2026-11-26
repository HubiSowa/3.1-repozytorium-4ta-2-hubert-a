# Co miał robić — Minutnik Pomodoro

## Co robi
1. Program pozwala uruchamiać, pauzować i resetować odliczanie czasu.
2. Program pokazuje pozostały czas (`mm:ss`) oraz status (`Praca` / `Przerwa`).
3. Program pozwala ustawiać czas pracy i przerwy (również z kropką lub przecinkiem).
4. Program pokazuje liczbę ukończonych cykli pracy.
5. Program pokazuje listę ukończonych cykli z godziną i numerem cyklu.

## Czego nie robi
- Nie zapisuje historii ani ustawień po zamknięciu aplikacji.
- Nie gra dźwięku ani nie wysyła powiadomień po zakończeniu etapu.
- Nie ma podziału na krótkie i długie przerwy.

## Po czym poznam
1. Kiedy kliknę „Start”, to czas zaczyna spadać co sekundę, a przycisk zmienia się na „Pauza”.
2. Kiedy wpiszę `25.5` lub `25,5` i zresetuję/uruchomię odliczanie, to ustawi się 25:30.
3. Kiedy skończy się czas pracy (`00:00`), to licznik cykli rośnie o 1, wpada wpis do historii i startuje przerwa.
4. Kiedy kliknę „Pauza”, to odliczanie staje, a przycisk wraca na „Start”.
5. Kiedy kliknę „Reset”, to odliczanie staje, wraca status „Praca” i czas z pola pracy.

## Do ustalenia
- Czy „Reset” ma zerować licznik cykli i historię?
- Czy przerwa ma ruszać automatycznie, czy po kliknięciu?
- Co ma się dziać przy wpisaniu `0` lub liczby ujemnej?