# Övning 3

3.3) Arv
13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
attribut, i vilken klass bör vi lägga det?
Bird är den närmsta föräldern att ärva ifrån och den mest logiska.

14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
  Animal är den närmsta gemensamma föräldern för alla barnen.

3.4) Mer polymorfism
9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
  Hundlistan tar endast instanser med typen Dog och kan därför inte hitta specifika attributer som nrOfTricks som endast finns på Dog och inte Horse.

10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
    List<Animal> fungerar.

12. Skriv ut samtliga Animals Stats() genom en foreach loop.
13. Testa och se så det fungerar.
14. F: Förklara vad det är som händer.
    Listan loopas igenom för varje djurinstans som finns.
    Varje instans äger en metod vid namn Stats, denna blir först overridad med instansets egna attributer sedan kallad,  
    det retunerade värdet skrivs ut i Console.WriteLine med strängvärdet.
    
17. Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri
sträng.
18. Kommer du åt den metoden från Animals listan?
19. F: Varför inte?
    Metoden finns inte i förälderns klass och har alltså inte ärvts.
20. Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals.
