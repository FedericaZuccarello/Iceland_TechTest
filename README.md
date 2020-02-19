# Iceland_TechTest
Program to automate the inventory management based on some roles.

We are a small convenience store with a prime location in a prominent city ran by a friendly
shopkeeper named Alison. We also buy and sell only the finest goods. Unfortunately, our goods are
constantly degrading in quality as they approach their sell by date. We currently update our
inventory manually.
Your task is to write a program to automate the inventory management based on the following
rules:
Rules:
• All items have a SellIn value which denotes the number of days we have to sell the item
• All items have a Quality value which denotes how valuable the item is
• At the end of each day our system lowers both values for every item
• Once the sell by date has passed, Quality degrades twice as fast
• The Quality of an item is never negative
• The Quality of an item is never more than 50
• "Aged Brie" actually increases in Quality the older it gets
• “Frozen Item” decreases in Quality by 1
• "Soap" never has to be sold or decreases in Quality
• "Christmas Crackers", like “Aged Brie”, increases in Quality as its SellIn value approaches; Its
quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less
but quality drops to 0 after Christmas
• "Fresh Item" degrade in Quality twice as fast as “Frozen Item”
Input : A list of items in the current inventory. Each line in the input represents an inventory item
with Item name, its sell-in value and quality e.g. “ Christmas Crackers -1 2” => Christmas Crackers
are past sellin value by 1 day with quality 2.
Output : Updated inventory after adjusting the quality and sellin days for each item after 1 day.

Notes:
You may use external libraries or tools for building or testing purposes e.g. (JUnit, NUnit, Xunit etc).
You should NOT use any executables (e.g. bat, class, cmd, exe, jar, jsp msi etc) in your submission.
We need to be able to build and run your program therefore, please submit your code on github as a
public repository and provide us a link to clone your repository. Your submission should contain the
source code and clear instructions on how to build, test and run the program (preferably a Readme).

--------------------------------------------------------------------------------------------------------------------------------

