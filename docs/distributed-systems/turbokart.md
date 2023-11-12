# TURBOKART
En case til implementering af distribuerede systemer.

# Indhold

# 1. Systembeskrivelse
Turbokart er en virksomhed der tilbyder hæsblæsende gokart oplevelser!

Din opgave er at udvikle et system bestående af flere applikationer, der kommunikerer sammen.

# 2. Applikationer og datakilder
## 2.1. Datakilder
A. **TurbokartDB** er en database til Turbokarts forretningsdomæne.
B. **SessionDB** er en database til omgangstider.

## 2.2. Applikationer med brugergrænseflader
1. **turbokart.dk** er virksomhedens offentlige website.
2. **Turbokart Booking Management** er et internt website.
3. **Turbokart Pro** er et offentligt website til professionelle kartere.
4. **Turbokart Live** er et offentligt website til at vise omgangstider live.

## 2.3. Applikationer uden brugergrænseflader
5. **Gateway API** er et REST web API, der modtager offentlige HTTP forespørgsler, og router forespørgslerne til de relevante API'er.
6. **Auth API** er et REST web API, der håndterer autentificerer brugere til Turbokart Pro og ansattes login til Turbokart Booking Management.
7. **Turbokart API** er et REST web API, der håndterer tilgang til data i TurbokartDB.
8. **Session API** er et REST web API, der håndterer tilgang til data i SessionDB.
9. **SessionHub** er en SignalR server (SignalR Hub), der notificerer forbundne klienter om omgangstider.
10. **Marada Timer Tech** er et bibliotek til at simulere omgangstider.

# 3. Kravspecifikation
## 3.1. Funktionelle krav
### 3.1.1. turbokart.dk
1. Forsiden skal indeholde et logo, en overskrift "Turbokart", samt en kort beskrivelse af Turbokart.
2. Der skal være navigation til en bookingside, hvor brugeren kan booke en tid til at køre gokart for 1-20 personer. Flere bookings kan godt køre i samme session (warm-up, kvalifikation og grand prix), men der må ikke være flere end 20 karts i en session.
3. Der skal være navigation til en side med priser og beskrivelse af de to produkter man kan købe (lad dig inspirere af [vandelgokart.dk](https://vandelgokart.dk/)): 
    * enkelt grandprix
    * dobbelt grandprix
4. Nederst på hver side skal der være kontaktoplysninger og åbningstider.

## 3.2. Ikke funktionelle krav
Systemwide skal systemet implementeres i en CLEAN microservice arkitektur.


### 3.2.1. Datakilder

A. **TurbokartDB**: relationel MS SQL database.

B. **SessionDB**: relationel MS SQL database.


### 3.2.2. turbokart.dk
1. Implementeres med ASP.NET Razor Pages.
2. Forsiden skal designes med farver, layout og fonte, der illustrerer "en hæsblæsende oplevelse".


