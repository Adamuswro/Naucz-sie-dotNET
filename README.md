# Naucz-sie-dotNET
Task solutions from FB group: "Szkoła Dotneta"

Link for FB group
https://www.facebook.com/groups/519961228689021/post_tags?post_tag_id=526613934690417

Performed tasks are pasted below.

# 1
Problem:  
W teorii złożoności obliczeniowej występuje problem 3SUM. Stawiane jest pytanie: czy w ciągu n liczb całkowitych znajdują się takie 3 których suma jest równa zero?
Przykład:  
Dla liczba 5 7 12 -10 4 8 2 -5 9 -4 -2  
Mamy trójki:  
-10 8 2  
9 -5 -4  
12 -10 -2  
7 -5 -2  
Zadanie:  
Napisz funkcję która przyjmie tablicę liczb całkowitych i zwróci wszystkie trójki rozwiązujące powyższy problem.  
Dla chętnych:  
Napisz test jednostkowy sprawdzający czy funkcja spełnia swoje zadanie.  

# 2 DODAWANIE NA PIECHOTĘ
Napisz funkcję, która przyjmie jako parametr tablicę liczb.  
Zsumuj je wszystkie jednak wykonaj działanie po kolei sumując kolejne liczby. Po każdym kroku wyświetl sumę cząstkową na ekranie.  
PRZYKŁAD  
Na wejściu podane są liczby:  
5 9 2 11 18 -5 2  
Na wyjściu wyświetl:  
14  
16  
27  
45  
40  
42  

# 7 LINQ
Dzisiaj nadal ćwiczymy LINQ.  
Przygotowałem dla Was kod 🙂  
https://pastebin.com/zQg9ehJs  
Całe zadanie jest w komentarzach. Myślę, że powinno być wszystko jasne.  

# 8 TABELA W LINQ
Ha to Was zaskoczyłem tytułem co? Tabela? W LINQ? O .... chodzi 🙂  
A no chodzi o to, że jak mamy tabelę powiedzmy z 1000 wyników, to bardzo kiepsko byłoby to wyświetlać na jednej stronie.  
Dlatego też wprowadza się coś, co po polsku brzmi bardzo dziwnie, czyli paginacja 🙂 Najprościej rzecz ujmując, zakładamy na przykład, że na jednej stronie wyświetlać się będzie 25 elementów. No właśnie. W związku z tym zadanie na dzisiaj.  
Napisz metodę, która przyjmie ilość elementów na stronie i numer strony, którą użytkownik chce wyświetlić. Metoda ma zwrócić z kolekcji studentów ich imię, nazwisko, semestr studiów i kierunek, na którym studiują.  

# 13 QUIZ
Wierzę w Was bardzo więc rzućmy się na nieco głębszą wodę 🙂  
Zróbcie aplikację konsolową, która będzie gra w Quiz. Co potrzebujemy?  
Aplikacja konsolowa  
Każde pytanie składa się z pytania i 4 możliwych odpowiedzi.  
W jednej grze graczowi serwowanych jest 5 pytań.  
Po każdym pytaniu gracz od razu dostaje informację, czy odpowiedział dobrze, czy źle.  
Na koniec gry gracz dostaje swój wynik wyrażony w procentach.  
Pytania wraz z odpowiedziami definiujemy w kodzie. Chyba że ktoś jest bardzo ambitny, to możemy zrobić mini bazę danych w pliku (w dowolnej formie: JSON, CSV, whatever).  
Mam nadzieję, że to Wam zajmie ciekawie weekend 🙂  

# 15 Łączenie intów
Zadanie:  
Napisz program konsolowy, w którym w argumentach programu podana zostanie lista liczb naturalnych.  
Połącz liczby w taki sposób, aby powstała najmniejsza i największa możliwa liczba.  
Przykład:  
Wejście - 50, 9, 2, 1  
Poprawny wynik - Min. 12509; Max. 95021  
Podpowiedź do poprawnego wykonania:  
Sprawdź, czy połączone liczby na pewno zmieszczą się w typie int.  

# 16 Fibonacci
Coś, co każdy programista musi chociaż raz napisać w swojej karierze  
Zadanie:  
Napisz program konsolowy, który wypisze pierwsze n liczb ciągu Fibonacciego, gdzie n zostanie podane w argumentach aplikacji.  
Załóż, że pierwszymi liczbami ciągu jest 0 i 1.  
Przykład:  
Wejście - 10  
Poprawny wynik - 0 1 1 2 3 5 8 13 21 34  

# 20 Full
Nowy tydzień to nowe rozdanie. A jak nowe rozdanie to zagrajmy w karty.  
Zadanie:  
Napisz program konsolowy, który będzie w stanie na podstawie podanych w pliku listy rąk pokerowych   wyświetlić na ekranie ręce, w których jest FULL.  
Dla osób niegrających w karty. Jedna ręka to pięć różnych kart.  
FULL to ręka, w której mamy 3 karty z jedną wartością i 2 karty z drugą wartością.  
Wszystkie operacje na obiektach należy wykonywać za pomocą LINQ.  
Przykład:  
Mamy podaną listę rąk przedzielonych średnikiem:  
"4♣ 5♦ 6♦ 7♠ 10♥;10♣ Q♥ 10♠ Q♠ 10♦;6♣ 6♥ 6♠ A♠ 6♦;2♣ 3♥ 3♠ 2♠ 2♦;2♣ 3♣ 4♣ 5♠ 6♠".  
Wyświetl na ekranie:  
10♣ Q♥ 10♠ Q♠ 10♦  
2♣ 3♥ 3♠ 2♠ 2♦  

# 21 PowerValidator
Stwórz funkcję, która przyjmie dwie listy:
IEnumerable<int> numbers
IEnumerable<int> squares
Niech funkcja zwróci true jeśli elementy z pierwszej listy podniesione do kwadratu będą odpowiadały wartościom na tych samych pozycjach w drugiej liście.
Nie używaj pętl. Dozwolony jest tylko LINQ.
Przykład:
numbers {1,2,3,4,5} squares {1,4,9,16,25}
zwróci true
numbers {1,2,3,4,5} squares {2,2,9,16,25}
zwróci false

# 24 RobotsFactory
Jesteś w fabryce robotów. Każdy robot kiedy schodzi z taśmy produkcyjnej, ma swoje określone parametry i nazwę.
Stwórz więc program, który będzie tworzył obiekty robotów z unikalną nazwą składającą się z dwóch liter i trzech cyfr, a także nadający losowo jeden z trzech parametrów (Translator, CoffeeMaking, Bartender).
Czasem jednak potrzeba robot przywrócić do ustawień fabrycznych. W takiej sytuacji robot powinien zresetować swoją nazwę i powinna zostać mu nadana kolejna. Parametry powinny pozostać bez zmian.
Pamiętaj jednak, że tworzenie losowych nazw może spowodować kolizję w unikalności. Zabezpiecz program tak, aby raz wykorzystana nazwa nigdy nie została użyta ponownie.

# 25 FactoryMethod
Mam dla Ciebie wyjątkowe zadanie. Wejdź na tą stronę: https://refactoring.guru/design-patterns/factory-method
Przeczytaj dokładnie opis wzorca projektowego Metody wytwórczej. Jest to jeden ze wzorców opisanych przez tzw. Gang of Four wiele lat temu.
Przeczytaj i zrozum, do czego się go używa, a następnie:
Stwórz aplikację konsolową, która pomoże w tworzeniu dokumentów. Chcemy tworzyć dokumenty różnych typów (jak na przykład CV, Raport, Opowiadanie). Każdy typ dokumentu musi składać się z konkretnych stron (np. CV składa się ze strony z umiejętnościami, doświadczeniem, edukacją i danymi osobowymi, a Opowiadanie składa się ze strony ze wstępem, rozwinięciem i zakończeniem).
Przemyśl odpowiednio strukturę klas do rozwiązania tego zadania.
(dane strony powinny jedynie wyświetlać się na ekranie jako nazwa strony np. "Strona umiejętności")
