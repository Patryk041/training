Zrobiłem dwa rozwiązania zadania.

Pierwsze jest w katalogu Simple, znajduje się tam prosta klasa, które implementuje interfejs IDateValidator. Każda część daty jest następnie sprawdzana w osobnych prywatnych metodach.

Drugie jest w katalogu Complex, każda część daty jest sprawdzana w innej klasie. Każda z tych klas implementuje interfejs IDateValidator, dodatkowo klasy sprawdzające rok i miesiąc implementują
stworzony interfejs IConcreteDateValidator, który zawiera metodę z jednym parametrem (dla tych roku i miesiące niepotrzebna jest znajomość innych części daty, natomiast dla dni już tak, aby 
wyliczyć rok przestępny). Mam nadzieję, że o to chodziło z Chain of Responsibility.

Dodałem też do projektu testy.

Pozdrawiam :)