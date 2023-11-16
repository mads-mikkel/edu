# EF Core Code First - lav DbContext og Entities i to forskellige projekter, fra CLI

## Solution i Visual Studio
Først klargør vi projekterne i vores solution:
1. Lav en ny blank solution.
2. Tilføj et klassebibliotek Entities
3. Tilføj et klassebibliotek EfContexts
4. Lav en project reference fra EfContexts projektet til Entities projektet.
5. I Entities, tilføj en klasse `Booking`:
```cs
public class Booking
{
    public int BookingId { get; set; }
    public DateTime Start { get; set; }
}
```
6. I Entities tilføj en klasse `Customer`:
```cs
public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
}
```
7. Lav 1..* aggregation mellem klasserne så én customer har mange bookings:
```cs
public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public List<Booking> Bookings { get; set; }
}
```
8. Lav aggregationen den anden vej også (bemærk fremmednøgle Id'et):
```cs
public class Booking
{
    public int BookingId { get; set; }
    public DateTime Start { get; set; }
    public Customer Customer { get; set; }
    public int CustomerId { get; set; }
}
```

9. Build din solution i Visual Studio (eller alternativt, kør kommandoen `dotnet build` i Entities mappen fra Terminal/kommandolinje/powershell).

## Installer nødvendige NuGet packages fra CLI
CLI betyder Command Line Interface og er det at udføre kommandoer i  Terminal/kommandolinje/powershell.

1. Naviger hen i EfContexts mappen.
2. Kør `dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.*`. Dette installerer værktøjer til at kunne udføre migrations.
3. Kør `dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.*`. Dette installerer værkstøjer til at lave og kommunikere med en Microsoft SQL Server.
4. Naviger til Entities.
5. Kør  `dotnet add package Microsoft.EntityFrameworkCore --version 7.*` Dette installerer værktøjer til at kunne programmere queries med EF i C#.
6. Build din solution.

## Migrations og oprettelse af databasen
1. Naviger hen til EFContexts.
2. Kør `dotnet ef migrations add InitialCreate`. Dette klargører at databasen kan laves.
3. Kør `dotnet ef database update`. Dette laver databasen.