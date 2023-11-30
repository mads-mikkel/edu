# 5.4. SignalR
SignalR er en teknologi der tillader klienter at blive notificeret fra serveren, i stedet for at skulle lave forespørgsler, om der er sket noget nyt. Det kræver at klienten er forbundet til serveren hele tiden. I en sådan forbindelse, kan data udveksles mellem klient og server. Det er i sig ikke nyt at man kan anvende en forbindelse der holdes åben, til dette. SignalR gør det dog noget nemmere i koden, og det er optimeret, således der nemt kan være mange klienter forbundet til serveren, uden at denne overbelastes. 

På serveren skal der være en SignalR Hub til at håndtere forbundne klienter. På klienten skal der være et SignalR bibliotek. Klienten kan være et website og det behøver endda ikke at være ASP.NET Core, da der findes et javascript bibliotek til det. Klienten kan også være en WPF, UWP, .NET MAUI eller Console applikation. Og herudfra kan vi udlede, at klienten skal afvikle kode, som javascript jo kan på websites. Microsofts konkurrent til javascript hedder Blazor, og her kan C# kode afvikles når klienten er et website i ASP.NET Core. Vi behandler Blazor i afsnit 5.5, og fokuserer her på SignalR.

Selve serveren skal være et ASP.NET Core project og kan være et API, et Razor Site eller et MVC site. Klienten kan som nævnt være en hvilken som helst .NET applikation, eller et website med et SignalR javascript bibliotek.
<br><br>

# 5.4.1. Viden
For at opnå viden skal du første gennemlæse disse to sider:
* Microsoft Docs: [Use hubs in SignalR for ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/signalr/hubs?view=aspnetcore-8.0)
* Microsoft Docs: [ASP.NET Core SignalR .NET Client](https://learn.microsoft.com/en-us/aspnet/core/signalr/dotnet-client?view=aspnetcore-8.0&tabs=visual-studio)
<br><br>

# 5.4.2. Opgave
Ud fra denne viden skal du nu løse to opgaver:
1. Lav dokumentation på følgende How To's:
    * Hvordan får man lavet en typestærk Hub på en API server?
    * Hvordan får man forbundet en .NET klient til en Hub?
2. Lav et eksempel med en .NET klient (WPF/UWP/MAUI/Console/Razor/MVC/Blazor) der modtager og sender data (evt. en notifikation) fra/til en SignalR Hub.
Man ser ofte, at en chat bliver brugt som eksempel. Det står dig frit for hvad du ønsker at anvende. Du må dog maksimalt bruge to skoledage på opgaven.
> [!TIP] 
> Keep it simple.

> [!IMPORTANT]
> Hub og klient må ikke have reference til hinanden i Visual Studio, hvis man anvender .NET klient til eksemplet.