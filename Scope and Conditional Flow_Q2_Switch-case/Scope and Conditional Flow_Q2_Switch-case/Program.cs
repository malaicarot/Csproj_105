﻿//---------------------------------------------------------------------
// Question 1: Basic Switch Case
// Write a C# program that prompts the user to enter a number between 1 and 3. Using a switch-case statement,
// display a message based on the number entered. If the number is 1, print "One"; if the number is 2, print "Two"; if the number is 3, print "Three".
// If the number does not match any of these, display a default message.
// Hint: Use Console.ReadLine() to get user input and Convert.ToInt32() to convert the input to an integer.
void printNumbers()
{
    Console.Write("Enter a number between 1 and 3: ");
    string input = Console.ReadLine();


    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("One");
            break;
        case 2:
            Console.WriteLine("Two");
            break;
        case 3:
            Console.WriteLine("Three");
            break;
        default:
            Console.WriteLine("There are no result for this number!");

            break;

    }

}
// printNumbers();

//---------------------------------------------------------------------
// Question 2: Game Character Selection
// In a game, the player can select a character class using numbers 1 to 3.
// Write a C# program that prompts the player to choose a character class.
// Based on the chosen number, display a message indicating the selected class: 1 for Warrior, 2 for Mage, and 3 for Archer.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different cases of character selection.
void characterSelection()
{
    Console.Write("Enter a character class using numbers 1 to 3: ");
    string input = Console.ReadLine();


    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Warrior");
            break;
        case 2:
            Console.WriteLine("Mage");
            break;
        case 3:
            Console.WriteLine("Archer");
            break;
        default:
            Console.WriteLine("This number does not corresponed to any class!");
            break;

    }

}
// characterSelection();

//---------------------------------------------------------------------
// Question 3: Directional Movement
// In a game, the player can move in four cardinal directions: North, South, East, and West.
// Write a C# program that prompts the player to enter a direction using numbers 1 to 4.
// Based on the chosen number, display a message indicating the direction: 1 for North, 2 for South, 3 for East, and 4 for West.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different directional inputs.
void directionalMovement()
{
    Console.Write("Enter a direction using numbers 1 to 4: ");
    string input = Console.ReadLine();


    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("North");
            break;
        case 2:
            Console.WriteLine("South");
            break;
        case 3:
            Console.WriteLine("East");
            break;
        case 4:
            Console.WriteLine("West");
            break;
        default:
            break;

    }

}
// directionalMovement();

//---------------------------------------------------------------------
// Question 4: Day of the Week
// Write a C# program that prompts the user to enter a number between 1 and 7 representing a day of the week.
// Use a switch-case statement to display the name of the corresponding day.
// For example, if the user enters 1, print "Monday"; if 2, print "Tuesday", and so on. If the number does not match any of these, display a default message.
// Hint: Map each number input to a specific day of the week using a switch-case statement.
void dayOfTheWeek()
{
    Console.Write("Enter a number between 1 and 7 representing a day of the week: ");
    string input = Console.ReadLine();


    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("This number does not corresponed to day of the week!");

            break;

    }

}
// dayOfTheWeek();

//---------------------------------------------------------------------
// Question 5: Weapon Selection
// In a game, the player can select a weapon using numbers 1 to 4.
// Write a C# program that prompts the player to choose a weapon. Based on the chosen number, display a message indicating the selected weapon: 1 for Sword, 2 for Bow, 3 for Staff, and 4 for Axe.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different weapon choices.
void weaponSelection()
{
    Console.Write("Choose a weapon using numbers 1 to 4: ");
    string input = Console.ReadLine();


    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Sword");
            break;
        case 2:
            Console.WriteLine("Bow");
            break;
        case 3:
            Console.WriteLine("Staff");
            break;
        case 4:
            Console.WriteLine("Axe");
            break;
        default:
            Console.WriteLine("Have no weapon spells using this number!");

            break;
    }
}
// weaponSelection();

//---------------------------------------------------------------------
// Question 6: Elemental Magic
// In a fantasy game, the player can cast elemental magic spells using numbers 1 to 5.
// Write a C# program that prompts the player to select a magic spell. Based on the chosen number, display a message indicating the selected spell element: 1 for Fire, 2 for Water, 3 for Earth, 4 for Air, and 5 for Lightning.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different spell selections.
void elementalMagic()
{
    Console.Write("Select a magic spell using numbers 1 to 5: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Fire");
            break;
        case 2:
            Console.WriteLine("Water");
            break;
        case 3:
            Console.WriteLine("Earth");
            break;
        case 4:
            Console.WriteLine("Air");
            break;
        case 5:
            Console.WriteLine("Lightning");
            break;
        default:
            Console.WriteLine("Have no magic spells using this number!");

            break;
    }
}
// elementalMagic();

//---------------------------------------------------------------------
// Question 7: Menu Navigation
// Write a C# program that simulates a menu navigation system for a game.
// The user can enter numbers 1 to 4 to navigate through different menu options: 1 for Start Game, 2 for Options, 3 for Load Game, and 4 for Exit.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle user input and navigate between menu options.
void menuNavigation()
{
    Console.Write("Enter numbers 1 to 4 to navigate through menu options: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Start Game");
            break;
        case 2:
            Console.WriteLine("Options");
            break;
        case 3:
            Console.WriteLine("Load Game");
            break;
        case 4:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Have no options using this number!");

            break;
    }
}
// menuNavigation();

//---------------------------------------------------------------------
// Question 8: NPC Interaction
// In an RPG game, the player can interact with non-player characters (NPCs) using numbers 1 to 3.
// Write a C# program that prompts the player to choose an interaction option with an NPC. Based on the chosen number, display a message indicating the selected interaction: 1 for Talk, 2 for Trade, and 3 for Quest.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different interaction options with NPCs.
void NPCInteraction()
{
    Console.Write("Enter numbers 1 -> 3 to choose an interaction option with an NPC: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Talk");
            break;
        case 2:
            Console.WriteLine("Trade");
            break;
        case 3:
            Console.WriteLine("Quest");
            break;
        default:
            Console.WriteLine("Have no options using this number!");
            break;
    }
}
// NPCInteraction();

//---------------------------------------------------------------------
// Question 9: Puzzle Solutions
// In a puzzle-solving game, the player can choose from different solutions using numbers 1 to 5.
// Write a C# program that prompts the player to select a solution for a puzzle. Based on the chosen number, display a message indicating the selected solution option.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different puzzle solution choices.
void puzzleSolutions()
{
    Console.Write("Enter numbers 1 -> 5 to choose solutions: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Solutions 1");
            break;
        case 2:
            Console.WriteLine("Solutions 2");
            break;
        case 3:
            Console.WriteLine("Solutions 3");
            break;
        case 4:
            Console.WriteLine("Solutions 4");
            break;
        case 5:
            Console.WriteLine("Solutions 5");
            break;
        default:
            Console.WriteLine("Have no solutions using this number!");
            break;
    }
}
// puzzleSolutions();

//---------------------------------------------------------------------
// Question 10: Dialogue Choices
// Write a C# program that simulates dialogue choices in a game. The player can select dialogue options using numbers 1 to 4.
// Based on the chosen number, display a message indicating the selected dialogue choice. If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different dialogue options presented to the player.
void dialogueChoices()
{
    Console.Write("Enter numbers 1 -> 4 to select dialogue options: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Dialogue 1");
            break;
        case 2:
            Console.WriteLine("Dialogue 2");
            break;
        case 3:
            Console.WriteLine("Dialogue 3");
            break;
        case 4:
            Console.WriteLine("Dialogue 4");
            break;
        default:
            Console.WriteLine("Have no dialogue using this number!");
            break;
    }
}
// dialogueChoices();
//---------------------------------------------------------------------
// Question 11: Crafting Items
// In a crafting system, the player can select crafting recipes using numbers 1 to 3.
// Write a C# program that prompts the player to choose a crafting recipe.
// Based on the chosen number, display a message indicating the selected recipe: 1 for Potion, 2 for Potion, and 3 for Armor. If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different crafting recipe selections.
void craftingItems()
{
    Console.Write("Enter numbers 1 -> 3 to select crafting recipes: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Recipe for Potion");
            break;
        case 2:
            Console.WriteLine("Recipe for Weapon");
            break;
        case 3:
            Console.WriteLine("Recipe for Armor");
            break;
        default:
            Console.WriteLine("Have no crafting recipe using this number!");
            break;
    }
}
// craftingItems();

//---------------------------------------------------------------------
// Question 12: Scene Selection
// Write a C# program that simulates scene selection in a game.
// The player can choose scenes using numbers 1 to 5. Based on the chosen number, display a message indicating the selected scene.
// If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different scene selections.
void sceneSelection()
{
    Console.Write("Enter numbers 1 -> 5 to choose scenes: ");
    string input = Console.ReadLine();

    Console.Write("You have chosen scene: ");

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("1");
            break;
        case 2:
            Console.WriteLine("2");
            break;
        case 3:
            Console.WriteLine("3");
            break;
        case 4:
            Console.WriteLine("4");
            break;
        case 5:
            Console.WriteLine("5");
            break;
        default:
            Console.WriteLine("Have no scene using this number!");
            break;
    }
}
// sceneSelection();

//---------------------------------------------------------------------
// Question 13: Quest Progression
// In an adventure game, the player can progress through quests using numbers 1 to 4.
// Write a C# program that prompts the player to select a quest. Based on the chosen number, display a message indicating the selected quest.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different quest selections and progression
void questProgression()
{
    Console.Write("Enter numbers 1 -> 4 to select a quest: ");
    string input = Console.ReadLine();

    Console.Write("You have select a quest: ");

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Monsters: Golem");
            break;
        case 2:
            Console.WriteLine("Monsters: Red amulet");
            break;
        case 3:
            Console.WriteLine("Epic Monsters: Dragon");
            break;
        case 4:
            Console.WriteLine("Epic Monsters: Baron Nashor");
            break;
        default:
            Console.WriteLine("Have no quest using this number!");
            break;
    }
}
// questProgression();
//---------------------------------------------------------------------
// Question 14: Potion Brewing
// In an alchemy system, the player can brew potions using numbers 1 to 3.
// Write a C# program that prompts the player to choose a potion to brew. Based on the chosen number, display a message indicating the selected potion: 1 for Health Potion, 2 for Mana Potion, and 3 for Stamina Potion.
// If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different potion brewing choices.
void potionBrewing()
{
    Console.Write("Enter numbers 1 -> 3 to select a potion brewing: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Health Potion");
            break;
        case 2:
            Console.WriteLine("Mana Potion");
            break;
        case 3:
            Console.WriteLine("Stamina Potion");
            break;
        default:
            Console.WriteLine("Have no brew potions using this number!");
            break;
    }
}
// potionBrewing();

//---------------------------------------------------------------------
// Question 15: Platform Movement
// In a platformer game, the player can move the character using numbers 1 to 4 for directional controls.
// Write a C# program that prompts the player to enter a movement direction. Based on the chosen number, display a message indicating the movement direction: 1 for Left, 2 for Right, 3 for Jump, and 4 for Crouch.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different movement directions, including a default case.
void platformMovement()
{
    Console.Write("Enter numbers 1 -> 4 to select a movement: ");
    string input = Console.ReadLine();

    Console.Write("Your character has moved: ");

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Left");
            break;
        case 2:
            Console.WriteLine("Right");
            break;
        case 3:
            Console.WriteLine("Jump");
            break;
        case 4:
            Console.WriteLine("Crouch");
            break;
        default:
            Console.WriteLine("Have no movement using this number!");
            break;
    }
}
// platformMovement();

//////////////////////Break Statements//////////////////////

//---------------------------------------------------------------------
// Question 16: Weapon Upgrades
// In a game, the player can upgrade their weapon using different materials.
// Write a C# program that prompts the player to choose a material for weapon upgrade.
// Based on the chosen number, display a message indicating the selected material. Use a switch-case statement to handle the different material choices: 1 for Iron, 2 for Steel, 3 for Gold, and 4 for Diamond.
// After displaying the selected material, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different material choices and use break statements to exit the switch-case block.
void weaponUpgrades()
{
    Console.Write("Enter numbers 1 -> 4 to choose a material for weapon upgrade: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Iron");
            break;
        case 2:
            Console.WriteLine("Steel");
            break;
        case 3:
            Console.WriteLine("Gold");
            break;
        case 4:
            Console.WriteLine("Diamond");
            break;
        default:
            Console.WriteLine("Have no materials using this number!");
            break;
    }
}
// weaponUpgrades();

//---------------------------------------------------------------------
// Question 17: Spell Casting
// In a fantasy game, the player can cast spells using different magic elements.
// Write a C# program that prompts the player to select a spell element. Based on the chosen number, display a message indicating the selected spell element: 1 for Fire, 2 for Water, 3 for Earth, and 4 for Air.
// After displaying the selected element, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different spell elements and use break statements to exit the switch-case block.
void spellCasting()
{
    Console.Write("Enter numbers 1 -> 4 to select a spell element: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Fire");
            break;
        case 2:
            Console.WriteLine("Water");
            break;
        case 3:
            Console.WriteLine("Earth");
            break;
        case 4:
            Console.WriteLine("Air");
            break;
        default:
            Console.WriteLine("Have no spell element using this number!");
            break;
    }
}
// spellCasting();

//---------------------------------------------------------------------
// Question 18: Skill Selection
// In a role-playing game (RPG), the player can choose skills to improve their character's abilities.
// Write a C# program that prompts the player to select a skill for enhancement. Based on the chosen number, display a message indicating the selected skill: 1 for Strength, 2 for Agility, 3 for Intelligence, and 4 for Vitality.
// After displaying the selected skill, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different skill selections and use break statements to exit the switch-case block.
void skillSelection()
{
    Console.Write("Enter numbers 1 -> 4 to select a skill for enhancement: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Strength");
            break;
        case 2:
            Console.WriteLine("Agility");
            break;
        case 3:
            Console.WriteLine("Intelligence");
            break;
        case 4:
            Console.WriteLine("Vitality");
            break;
        default:
            Console.WriteLine("Have no skills using this number!");
            break;
    }
}
// skillSelection();

//---------------------------------------------------------------------
// Question 19: Puzzle Solutions
// In a puzzle-solving game, the player can choose from different solutions to progress through the game.
// Write a C# program that prompts the player to select a solution for a puzzle. Based on the chosen number, display a message indicating the selected solution option.
// After displaying the selected solution, include a break statement to terminate the switch-case block.
// Hint: Use switch-case statements to handle different puzzle solution choices and use break statements to exit the switch-case block.
void puzzleSolutions2()
{
    Console.Write("Enter numbers 1 -> 4 to select a solution for a puzzle: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Solutions 1");
            break;
        case 2:
            Console.WriteLine("Solutions 2");
            break;
        case 3:
            Console.WriteLine("Solutions 3");
            break;
        case 4:
            Console.WriteLine("Solutions 4");
            break;
        default:
            Console.WriteLine("Have no solutions using this number!");
            break;
    }
}
// puzzleSolutions2();
//---------------------------------------------------------------------
// Question 20: Potion Brewing
// In an alchemy system, the player can brew potions using different ingredients.
// Write a C# program that prompts the player to choose an ingredient for potion brewing. Based on the chosen number, display a message indicating the selected ingredient: 1 for Herb, 2 for Mushroom, 3 for Flower, and 4 for Crystal.
// After displaying the selected ingredient, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different ingredient choices and use break statements to exit the switch-case block.
void PotionIngredients()
{
    Console.Write("Enter numbers 1 -> 4 to choose an ingredient for potion brewing: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Herb");
            break;
        case 2:
            Console.WriteLine("Mushroom");
            break;
        case 3:
            Console.WriteLine("Flower");
            break;
        case 4:
            Console.WriteLine("Crystal");
            break;
        default:
            Console.WriteLine("Have no ingredients using this number!");
            break;
    }
}
// PotionIngredients();

//---------------------------------------------------------------------
// Question 21: NPC Interactions
// In a game world, the player can interact with non-player characters (NPCs) in various ways.
// Write a C# program that simulates NPC interactions based on player input. Prompt the player to choose an interaction option with an NPC using numbers 1 to 3: 1 for Talk, 2 for Trade, and 3 for Quest.
// After displaying the selected interaction, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different NPC interaction options and use break statements to exit the switch-case block.
void NPCInteractions2()
{
    Console.Write("Enter numbers 1 -> 3 to choose an interaction option with an NPC: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Talk");
            break;
        case 2:
            Console.WriteLine("Trade");
            break;
        case 3:
            Console.WriteLine("Quest");
            break;
        default:
            Console.WriteLine("Have no options using this number!");
            break;
    }
}
// NPCInteractions2();

//---------------------------------------------------------------------
// Question 22: Scene Navigation
// Write a C# program that simulates scene navigation in a game.
// The player can choose scenes using numbers 1 to 5 to navigate through different game environments.
// After displaying the selected scene, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different scene selections and use break statements to exit the switch-case block.
void sceneNavigation()
{
    Console.Write("Enter numbers 1 -> 5 to navigate through different game environments: ");
    string input = Console.ReadLine();

    switch (Convert.ToInt32(input))
    {
        case 1:
            Console.WriteLine("Dungeon");
            break;
        case 2:
            Console.WriteLine("Windy Hill");
            break;
        case 3:
            Console.WriteLine("Clouds City");
            break;
        case 4:
            Console.WriteLine("Volcano");
            break;
        case 5:
            Console.WriteLine("Shibuya City");
            break;
        default:
            Console.WriteLine("Have no scene using this number!");
            break;
    }
}
// sceneNavigation();

//---------------------------------------------------------------------
// Question 23: Quest Progression
// In an adventure game, the player can progress through quests using different options.
// Write a C# program that prompts the player to select a quest option. After displaying the selected quest option, include a break statement to terminate the switch-case block.
// Hint: Use switch-case statements to handle different quest options and use break statements to exit the switch-case block.
void questProgression2()
{
    Console.Write("Enter numbers 1 -> 4 to select a quest option: ");
    string input = Console.ReadLine();

   switch (Convert.ToInt32(input))
    {
        case 1: 
            Console.WriteLine("Epic Monsters: Dragon");
            break;
        case 2:
            Console.WriteLine("Epic Monsters: Baron Nashor");
            break;
        case 3:
            Console.WriteLine("Epic Monsters: Vilemaw");
            break;
        case 4:
            Console.WriteLine("Epic Monsters: Poro King");
            break;
        default:
            Console.WriteLine("Have no quest using this number!");
            break;
    }
}
// questProgression2();

//---------------------------------------------------------------------
// Question 24: Menu Navigation
// Write a C# program that simulates menu navigation in a game.
// The player can navigate through menu options using numbers 1 to 4: 1 for Start, 2 for Options, 3 for Load Game, and 4 for Exit.
// After displaying the selected menu option, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different menu options and use break statements to exit the switch-case block.
void menuNavigation2()
{
    Console.Write("Enter numbers 1 -> 4 to navigate through menu options: ");
    string input = Console.ReadLine();

   switch (Convert.ToInt32(input))
    {
        case 1: 
            Console.WriteLine("Start");
            break;
        case 2:
            Console.WriteLine("Options");
            break;
        case 3:
            Console.WriteLine("Load Game");
            break;
        case 4:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Have no menu using this number!");
            break;
    }
}
// menuNavigation2();