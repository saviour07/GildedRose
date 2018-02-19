# GildedRose

This is a simple inventory management system which adhere's to the following rules:

* All items have a SellIn value which denotes the number of days we have to sell the
item
* All items have a Quality value which denotes how valuable the item is
* At the end of each day our system lowers both values for every item
* Once the sell by date has passed, Quality degrades twice as fast
* The Quality of an item is never negative
* "Aged Brie" actually increases in Quality the older it gets
* “Normal Item” decreases in Quality by 1
* The Quality of an item is never more than 50
* "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
* "Backstage passes", like aged brie, increases in Quality as its SellIn value
approaches
	* Its quality increases by 2 when there are 10 days or less and by 3 when
there are 5 days or less
	* Quality drops to 0 after the concert
* "Conjured" items degrade in Quality twice as fast as normal items

<b>Building the solution</b>

To build the solution, simply open up the solution in VS 2017 and build the root "GuildedRose" solution.

This will also run the solutions unit tests.

<b>Running the application</b>

To run the main console application, either:
1. Set the GuildedRoseApp.csproj as the startup project by right-clicking the GuildedRoseApp.csproj and selecting "Set as StartUp Project" then executing it in the debugger by preseing F5.
2. Building the solution atleast once and running the "GildedRoseApp.exe" executable in the $(SolutionDirectory)/GildedRoseApp/Bin/$(Configuration)/ output directory.

<b>Unit Tests</b>

The unit testing framework used is the default MSTest Test Framework and can be run from within the IDE by using the Test Explorer.

For MSTest to discover the unit tests, the solution needs to be built atleast once.

To open Test Explorer, go to Test -> Windows -> Test Explorer (default keyboard shortcut is Ctrl+E, T).

Within Test Explorer, select the "Run All" option to execute all the tests.