# 5.1 Razor Pages

Razor Pages er et ASP.NET framework, der er lightweight og fokuserer på at kunne konstruere websites hurtigt og fleksibelt uden at bryde med princippet om Separation of Concerns og med begrænset interaktion fra brugeren.

Målet er, at du først konstruerer et lille website ud fra en tutorial, og derefter konstruerer et tilsvarende lille website til Turbokart. 

Du kommer til at lære hvordan man konstruerer et lille website med Razor Pages ved:
* at lære om projektstrukturen i Visual Studio
* at lære hvordan Razor Pages sider genereres lokalt og hostes på Kestrel serveren
* at lære hvordan man blander HTML og C# kode i det der kaldes Razor syntaks

Derudover stifter du bekendtskab med: 
* hvordan man forbinder websitet med en database ved brug af Entity Framework Core Code First
* hvordan man anvender `DbContext` objektet med Dependency Injection og Inversion of Control

## Indhold
**5.1.1 [Viden](#511-viden)**

**5.1.2 [Fourth Coffee tutorial](#512-fourth-coffee-tutorial)**

**5.1.3 [turbokart.dk](#513-turbokartdk)**

## 5.1.1 Viden
I dette og næste afsnit skal du opnå viden og færdigheder i at konstruere et lille website med Razor Pages. Du skal anvende [Learn Razor Pages](https://www.learnrazorpages.com/), dog læse de to første sider (og deres undersider):
* Home
* ASP.NET Core

Det giver dig den nødvendige viden for at kunne komme i gang med tutorialen i næste afsnit.

## 5.1.2 Fourth Coffee tutorial
Følge [denne](https://www.learnrazorpages.com/razor-pages/tutorial/bakery) tutorial fra Learn Razor Pages. 

OBS:
> Der bliver anvendt dotnet fra kommandolinjen til at lave selve ASP.NET Razor Pages projektet, prøv at se om du kan lave det i Visual Studio i stedet.

Når du har gennemført tutorialen, så forbered svar på disse spørgsmål til drøftelse:
1. Hvordan var din oplevelse med at lave et website i Razor Pages, der har tilgang til data i en database, i forhold til hvad du ellers har prøvet?
2. Hvilket formål og ansvar har en `PageModel`?
3. Hvilket regler gælder for HTTP requests og tilhørende handlers?
4. Hvorfor skal vi ikke lave et objekt af `BakerContext`?
5. Hvad var din oplevelse med at lave databasen med Code First?

HINT:
> På hver af siderne er der links til andre steder på Learn Razor Pages. Det er en god idé at klikke på de fleste af dem, for at få viden til at kunne svare på spørgsmålene.

## 5.1.3 turbokart.dk
Nu skal du lave sitet til turbekart.dk. Læse [casen om turbokart](/docs/distributed-systems/turbokart.md), og konstruer sitet.