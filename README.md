# fiks-politiskbehandling-client-dotnet

Klient bibliotek for [fiks-politiskbehandling](https://github.com/ks-no/fiks-politiskbehandling/).
Biblioteket inneholder json [schema](https://github.com/ks-no/fiks-politiskbehandling-client-dotnet/tree/main/KS.Fiks.IO.Politisk.Behandling.Client/Schema) for FIKS-IO protokollene for politisk behandling, samt ferdige modeller (kommer snart) og hjelp til oppbygging av meldinger som følger protokollene.

Nuget pakken er tilgjengelig på [nuget.org](https://www.nuget.org/packages/KS.Fiks.IO.Politisk.Behandling.Client/). 

Se [Wiki](https://github.com/ks-no/fiks-politiskbehandling/wiki) for fiks-politiskbehandling for mer utfyllende dokumentasjon.

Definisjonen av json schema for protokollene er under arbeid og vil fremdeles kunne forandre seg fra versjon til versjon av denne nuget pakken.

### Arbeid med Json Schema

Det er laget en unit-test som validerer Json Schema mot "meta-schema" definert av [JSON Schema](https://json-schema.org/) når man commiter en endring. Ved endringer av schema filer skal man lage en PR og sjekke at byggingen og dermed også unit-tester er ok. Så kan man be om en review og merge det inn når det er godkjent av reviewer. 

Json Schema skal nå være på [draft-2020-12](https://json-schema.org/draft/2020-12/schema)

### Arbeid med modeller generert av Json Schema
Det er laget en "generator" som skal generere modeller ut fra Json Schema når det blir gjort endringer. Denne generatoren er ikke sikkert blir god nok til å ikke kreve manuelt ettersyn, men kan være en god hjelp ved arbeid på nye versjoner. 

Det planlegges også verktøy for å hjelpe til med opprettelse av meldinger for protokollene. 

