Popis pracovného postupu projektu:

## Návrh databázy:
- Definovanie schémy databázy zahŕňajúcej tabuľky pre Kategóriu, Produkt, ŠpecifikáciuKategórie a ŠpecifikáciuProduktu.
- Vytvorenie vzťahov medzi tabuľkami na usporiadanie kategórií produktov, špecifikácií a podrobností o produkte.
- Vytvorenie views ProductDetails a ProductWithSpecifications na agregáciu dát z rôznych tabuliek pre zjednotenie a zjednodušenie dátových operácií.

## Vývoj aplikácie:
- Využitie nástrojov DevExpress a WinForms pre užívateľské rozhranie aplikácie.
- Implementácia úvodnej obrazovky s uvítacou správou, obrázkom a horným menu s tlačidlom "Katalóg".
- Navrhnutie modulu katalógu na zobrazenie zoznamov produktov a detailov pomocou DevExpress prvkov.
- Implementácia gridov na zobrazenie zoznamov produktov a detailov.
- Spracovanie dynamického načítavania detailov produktov na základe výberu.

## Testovanie a Doladovanie:
- Vykonávanie testov na overenie funkčnosti aplikácie.
- Riešenie chýb a jemné upravovanie funkcií na základe výsledkov testovania.

## GitLab:
Nahranie projektu na GitLab pre možnosť kontroly verzií a spolupráce.

## Dokončenie:
Dokončenie aplikácie s overením, že všetky funkcie pracujú podľa očakávania.
Príprava projektu na nasadenie a potenciálne budúce vylepšenia.

## Dokumentácia:
Príprava dokumentácie, vrátane súboru README popisujúceho projekt, jeho štruktúru a inštrukcie na používanie.
Zaznamenávanie zvládnutých výziev, použitých riešení a krokov pri vývoji.

## Hlavné výzvy:
### Komplexita návrhu databázy:
Hlavnou myšlienkou bolo vytvoriť flexibilný katalóg, ktorý umožní mať rôzne typy produktov, ako je to zvyčajne v modernom e-shope. 
Preto bolo rozhodnuté vytvoriť kategórie a príslušné prostrednícke tabuľky, ktoré spájajú produkt, jeho kategóriu a špecifikácie pre danú kategóriu.
Okrem toho boli vytvorené SQL pohľady (views), ktoré zlúčili štyri tabuľky do dvoch a použité na zobrazovanie informácií v gridoch.

### Návrh a Implementácia Užívateľského Rozhrania: 
Keďže tento projekt bol mojou prvou skúsenosťou s WinForm, nejaký čas mi trvalo pochopiť proces vývoja používateľského rozhrania, a ako sa orientovať v sade properties pre každý UI prvok.
