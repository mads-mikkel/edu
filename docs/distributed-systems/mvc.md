# 5.3 MVC
MVC er et designmønster man anvender både til websites og web API'er i ASP.NET Core. Man anvender det også på andre platforme, og det er designet til at håndtere HTTP requests fra en klient til en webserver. Razor Pages er en variant af MVC i ASP.NET Core, hvor der er mindre fokus på mulighed for at konfigurere, og mere fokus på at være produktiv. Denne side omhandler MCV templaten i Visual Studio, og læringen omfatter to trin: Du skal først følge en tutorial, der gennemgår hvad MVC er og hvordan man gør i Visual Studio. Så skal du implementere Turbokart Booking Management i Turbokart casen.


## 5.3.1. Viden
Du skal se [denne video](https://www.youtube.com/watch?v=jhj9ouy7x1g) og selv gøre som der bliver gjort. På denne måde, får du en hands-on oplevelse af MVC i ASP.NET Core i Visual Studio. Det er denne viden du skal anvende til at lave Turbokart Booking Management.

**OBS:**
> Til denne opgave skal der ikke udvikles hverken Gateway API eller Auth API.


## 5.3.2 Implementation af Turbokart Booking Management
Denne opgave kan løses både individuelt og i en gruppe. Du har på forhånd fået at vide hvad du skal.
Du finder kravspecifikationen i [Turbokart casen](/docs/distributed-systems/turbokart.md). Der er afsat 2,5 dag til det, inklusive skriftlig besvarelse og fremlæggelse for holdet.

### 5.3.2.1 Løsning individuelt
Du skal have fokus på at implementere kravene i kravspecifikationen, men også den skriftlige besvarelse og din fremlæggelse for holdet. 

### 5.3.2.2 Løsning i gruppe
I skal vælge mellem to måder at løse opgaven på:
* **Med versionsstyring:** Her skal I anvende git til versionsstyring og læreren sørger for at lave et repository på [AspIT's github](https://github.com/aspit-cv) til jer. I skal lave en ny solution til turbokart casen, og så overføre al eksisterende kode til den - det vil også sige, at I skal blive enige om hvem der bidrager med hvilken kode. Når I skal til at lave applikationen, skal I sørge for at der er en master branch, og en dev branch der kommer fra master branch. Når man laver en ny feature, er det vigtigt at man også laver en ny branch til den. Det er også vigtigt at man holder sin egen branch opdateret med alt det nyeste fra dev branch. Find gerne selv ud af mere omkring best practice samarbejde i git.
OBS: Det giver god mening at anvende denne solution bagefter til de kommende opgaver og til eksamen.
* **Uden versionsstyring**: Her skal I anvende jeres egen turbokart solution til opgaven. Samarbejdet går her ud på, at i sparrer omkring opgavens løsning.


## 5.3.3. Skriftlige spørgsmål
Din lærer lader dig vide, hvordan og hvornår du skal besvare følgende spørgsmål. Bemærk at disse spørgsmål er til MVC generelt:

1. Med hvilken komponent i MVC kommunikerer en HTTP klient? (Model, View eller Controller).
2. Beskriv formål og ansvarsområde for hver komponent i MVC.
3. Læs følgende situation: 
    > en bruger indtaster en ny *ting* og klikker på "Gem" knappen. Brugeren får nu vist alle *ting*, inklusive den nye *ting* brugeren lige har indtastet. 

    Forklar hvad der sker henholdsvis på klienten og på serveren, med fokus på anvendelsen af MVC.
4. Hvad *skal* hhv. *kan* en action method returnere? - hvorfor er det sådan?
5. Forklar hvordan det virker at anvende `return View()` i en action method, og controlleren så gør det korrekte.
6. Hvordan virker det, at man kan sende et argument af en model type til en parameter på en action method?
7. Hvad er fordelene og ulemperne ved at anvende Model klasserne som Entities i f.eks. CLEAN arkitektur?
8. Find de tre mest anvendte platforme ud over ASP.NET, der også bruger MVC.

## 5.3.4. Gode råd
Planlæg arbejdet (eventuelt i Microsoft Planner):
1. Skab overblik over de forskellige opgaver der skal løses.
2. Lav en rækkefølge over opgaverne, og husk den skriftlige besvarelse.

Til selve opgaverne kan du med fordel vælge at inddrage disse værktøjer:
* lave et diagram over TurbokartDB, hvor brugere er tilføjet som tabel. 
* Implementer nu diagrammet med EF Code First migration.
* Lav et klassediagram over BookingUseCase, og overvej hvilke nye metoder der skal være, samt om der er behov for at eksisterende metoder ændres - og notér resultatet af disse overvejelser ned med argumenter om hvorfor ændringerne er nødvendige.
* Lav dokumentation for systemet ved at lave en oversigt over URL'er og portnumre med tilhørende beskrivelser.