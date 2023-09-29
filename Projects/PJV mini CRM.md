# PJV mini CRM
## Introduktion
En del af praktik- og jobvejlederens (PJV) arbejde, er at kontakte virksomheder. Det foregår typisk ved at PJV'en ringer til virksomhederne, for at få en aftale i stand til et møde. Her kan der ske tre ting:
1. Der laves aftale om møde.
2. Virksomheden er ikke interesseret.
3. Der kunne ikke træffes afgørelse nu, men der arbejdes på det.

PJV'erne kunne derfor godt tænkte sig et system, til at håndtere information om virksomhedshenvendelser.

## Systembeskrivelse
Det er nødvendigt for PJV'erne, at de kan se hvilke virksomheder der er blevet kontaktet, og hvad deres svar var. De skal også kunne opdatere informationen og lave nye notater om henvendelser til virksomhederne.

De skal kunne se en oversigt over igangværende henvendelser som endnu ikke er afsluttede.

## Kravspecifikation
### Funktionelle krav
1. Brugeren skal kunne se en oversigt over igangværende henvendelser der endnu ikke er afsluttede.
2. Brugeren skal kunne indtaste nye henvendelser og angive dennes status.
3. Brugeren skal kunne søge en virksomhed frem og se hvilke henvendelser der har været.

### Ikke-funktionelle krav
1. Der skal laves en raltionel database (eks. MS SQL Server)
2. Der skal laves et REST Web API, der understøtter de funktionelle krav.