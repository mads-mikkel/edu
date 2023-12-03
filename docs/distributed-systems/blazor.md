# 5.4. Blazor
Blazor er et web framework, der tillader afvikling af C# kode i en browser og anvender også Razor syntaksen. Når man tilgår et blazor website, sender browseren et HTTP request til en Blazor server - præcist som vi plejer med Razor og MVC. Blazor serveren sender HTML tilbage til browseren som render det. Hvis brugeren for eksempel navigerer til en ny side på websitet, generes der ikke et ny HTTP request med HTML som svar, spm det jo sker i Razor/MVC og mange andre teknologier. I stedet sender browseren et HTTP request og får kun data tilbage, der kan vises i det HTML browseren fik *første gang*. Dette kaldes en Single Page Application (SPA). Og det er den klientafviklede C# kode, der sender et HTTP request til serveren og behandler de data den får tilbage - ligesom javascript ville gøre.
<br><br>

## 5.4.1. Viden
Du skal se de første 12:30 af en tutorial af Julio Casal og bagefter se en række mindre videoer med Jeff Fritz.
* Julio Casal: [**Blazor Tutorial | CRUD With Blazor, Step By Step**](https://www.youtube.com/watch?v=WfMHUp8tOVE). De første 12:30, giver en rigtig god introduktion til Blazor. 

    > [!IMPORTANT]
    > Du skal være opmærksom på, at Julio taler ret hurtigt, så tag gerne pauser ind i mellem og spol lidt tilbage hvis der var noget du missede.

* Jeff Fritz: **[Blazor for Beginners](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oUJCA3DCzKT79Oe3kdKEceX)**. Du skal gennemse alle 11 videoer. De giver et godt indblik i, hvordan man anvender Blazor i praksis.

## 5.4.2. Opgave - SynthMania
Med inspiration fra Jeff Fritz skal du nu lave et Blazor website, hvor man kan købe analoge synthesizere. Her er kravspecifikationen:

**Funktionelle krav**
1. Der skal være en forside, der beskriver webshoppen.
2. Der skal være en produktside hvor produkterne vises.
3. Man skal have mulighed for at tilføje et produkt til en indkøbskurv og fjerne det igen.
4. Man skal have mulighed for at købe produktet[^1], og få det tilsendt til sin adresse.

[^1]: selve betalingsfunktionen skal bare være et mock.

**Ikke-funktionelle krav**
1. Frontend: Blazor Web Application i Visual Studio
2. Backend: Lav en relationel database, der kan håndtere at en ikke-registreret bruger har en indkøbskurv, hvori der kan være produkter, samt at man kan købe produkter og få tilsendt dem.

## 5.4.3. Skriftlig besvarelse
Besvar disse spørgsmål skriftligt:
1. Forklar med dine egen ord, hvad en SPA er.
2. Hvad er en Razor Component? Giv også et eksempel på, hvordan man bruger en Razor Component.
3. Adskiller data binding i Blazor sig fra måden det gøres på i Razor eller MVC?
4. Hvad sker der konkret når en Blazor applikation skal opdatere det indhold der skal vises i browseren.