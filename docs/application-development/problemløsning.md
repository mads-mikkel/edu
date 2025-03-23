# PROBLEMLØSNING
**I denne opgave træner du dine færdigheder i problemløsning.**

## Forudsætninger
Du skal have færdigheder i variable, if-else, løkker, lineære datastrukturer og metoder.

## Formål og begrænsninger
Formålet med disse opgaver, er at du træner dine evner i problemløsning. Derfor mål du ikke anvende AI til andet en at generere større mængder testdata, hvis det skulle være nødvendigt. Mange af opgaverne kan løses ved at kalde indbyggede metoder i System namespace, men det går jo ikke, da du således ikke kan opnå formålet med opgaverne. Du må derfor ikke anvende de indbyggede metoder i de typer der er i namespace System, såsom DateTime, TimeSpan osv.

## Introduktion
* Du skal lave en klasse der hedder ProblemSolver. 
* Klassen skal indeholde én metode til hver opgave. 
* Metoder navngives efter deres formål, f.eks. TextToNumber. 
* Du skal gøre din kode robust - det betyder at der skal kastes undtagelser (exceptions) hvis ikke input er i det korrekte format eller for eksempel er uden for et interval.
* Du skal teste dine løsninger fra Main metoden, i try-catch blokke. Du skal teste både at din metode virker, men også at den kaster en exception. 
* Såfremt en exception fangers her, skal der udskrives en fejlbesked til brugeren med Console.WriteLine.

Her er et eksempel på Main metoden:
```cs
ProblemSolver ps = new();
try
{
    int result = ps.NumberOfSeconds("12:34");
    Console.WriteLine(result);
}
catch(Exception e)
{
    Console.WriteLine("Format error: {e.Message}");
}
```

og her er et eksempel på hvordan man kaster en exception:

```cs
public int NumberOfSeconds(string time)
{
    if(time is null)
    {
        throw new ArgumentNullException(nameof(time));
    }
    int result = default;
    // more code...
    return result;
}
```
Keyword throw fungerer som keyword return: det stopper metoden på den linje hvor der står throw, og returnerer afviklingen til den kaldende metode, nemlig Main metoden, hvor man så skal sørge for at grube en exception i en try-catch blok.

Hint: I stedet for at lave verdens længste Main metode, så kan du lave en statisk metode i Program.cs filen, til hver opgave, og kalde den fra Main metoden. På den måde bevarer du et bedre overblik i alle opgaverne:

```cs
public static void Main(string[] args)
{
    //Exercise01();
    Exercise02();
}

public static void Exercise01()
{
    try
    {
        // success code here...
    }
    catch(Exception e)
    {
        // handle failures here...
    }
}

public static void Exercise02()
{
    try
    {
        // success code here...
    }
    catch(Exception e)
    {
        // handle failures here...
    }
}

// and so on and so on....
```
## Opgaver

### 1 Tidsformat
Lav en metode der tager en streng som input i formatet mm:ss eller tt:mm:ss og returnerer antallet af sekunder.

### 2 Tidsformat igen
Lav det omvendte af nr. 1.1.

### 3 Temperatur
Lav en metode der tager en double som input i grader Kelvin, og en streng der med én karakter, angiver om putput skal være i grader Celsius eller grader Fahrenheit. Metoden skal returnere en double med temperaturværdien for den angivede skala.

### 4 Længde
Lav en metode, der konverterer fra mil til kilometer. Du skal selv vælge datatyper.

### 5 Længde igen
Lav en metode der tager et tal der angiver en længde i kilometer som input, samt en ønsket output skala (mil, svensk mil, meter). Metoden skal returnere den konverterede værdi i den ønskede skala.

### 6 Hvor lang tid er der gået?
Lav en metode der tager to strenge som input i formattet tt:mm, og returnerer differensen mellem de to tidspunkter i formattet tt:mm.

### 7 På restaurant
Lav en metode, der tager regningens samlede beløb, en ønsket drikkepengeprocent samt antallet af gæster som input. Metoden skal udregne den totale regning inklusiv drikkepenge og derefter beregne, hvor meget hver person skal betale – afrundet til nærmeste 0,50 kr.

### 8 Køreturen
Lav en metode, der udregner benzinomkostninger til en biltur. Input er ruteafstanden i kilometer, bilens brændstofforbrug (liter pr. 100 km) og benzinprisen pr. liter. Metoden returnerer den samlede udgift til benzin for turen.

### 9 Elregning
Lav en metode, der beregner en måneds elregning. Input skal inkludere forbrugte kWh, pris pr. kWh og en fast månedlig afgift. Resultatet skal være det totale beløb for elregningen.

### 10 Data, data, data
Lav en metode, der estimerer, hvor længe en mobil datapakke varer. Metoden skal tage datapakkens størrelse (i GB) og det gennemsnitlige daglige dataforbrug (i MB) som input og returnere, hvor mange dage datapakken forventes at holde.

### 11 Parkering er ikke gratis
Lav en metode, der beregner omkostningerne for parkering. Metoden skal tage antallet af parkerede minutter som input, runde op til nærmeste time, og beregne den samlede pris baseret på et fast timebeløb.

### 12 Giv den gas
Lav en metode, der estimerer, hvor mange kalorier der forbruges ved en fysisk aktivitet. Input skal være typen af øvelse (f.eks. løb, cykling, svømning), varigheden i minutter og en intensitetsangivelse (lav, medium, høj). Metoden returnerer en estimeret kalorieforbrænding.

### 13 Husk momsen
Lav en metode, der udregner moms for et køb. Metoden skal tage en pris uden moms og en momssats (fx 25 %) som input og returnere både momsbeløbet og den samlede pris inklusiv moms. 

Hint: Når en metode skal returnere mere end én værdi, anvender man tupler.

### 14 Rabat!
Lav en metode, der beregner den nedsatte pris på en vare. Input er den oprindelige pris og en rabatprocent. Metoden skal returnere både den nye pris og det besparede beløb.

### 15 Vejrudsigten
Lav en metode, der tager en temperatur i Celsius, en luftfugtighed i procent og returnerer en læsevenlig vejrudsigtsstreng, f.eks. "Det er 22°C med 60% luftfugtighed og solrigt vejr."

### 16 En krone sparet, er en krone tjent
Lav en metode, der udregner, hvor mange måneder det vil tage at nå et opsparingsmål. Input er startkapital, månedlig opsparing og en fast årlig rente (brug evt. rentes rente). Returnér den estimerede tid til målopnåelse.

### 17 Størrelse 4 eller medium?
Lav en metode, der konverterer tøjstørrelser fra EU-systemet til det amerikanske system. Input er den danske/EU-størrelse, og metoden returnerer den tilsvarende US-størrelse baseret på en foruddefineret konversionstabel.

### 18 Jeg har ikke mere strøm!
Lav en metode, der estimerer, hvor mange timers drift en mobiltelefon kan levere. Input er batterikapaciteten (i mAh) og det gennemsnitlige strømforbrug (i mAh pr. time). Metoden returnerer den forventede driftstid i timer.

### 19 Pendlerrejsetidsberegner
Lav en metode, der estimerer rejsetiden for en pendler til arbejde. Input skal inkludere afstanden (i km), valg af transportmiddel (f.eks. bil, cykel eller offentlig transport) og den gennemsnitlige hastighed. Returnér den forventede rejsetid i timer og minutter.

### 20 Abonnementer
Lav en metode, der modtager en liste over faste månedlige abonnementer (f.eks. streamingtjenester, internet, avisabonnementer) med deres månedlige pris. Metoden skal returnere en samlet oversigt over de faste udgifter og den totale månedlige sum.

### 21
Lav en metoder der tager en liste af filnavne som input. Metoden skal returnere en key-value liste, med filendelsen som nøgle, og antallet af gange filendelsen optræder i input listen. Du skal selv bygge din key-value liste (Hint: lav en klasse der har to arrays, der er lige lange).