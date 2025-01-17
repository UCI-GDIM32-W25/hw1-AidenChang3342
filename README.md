[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
GDIM 32: Week 1 Homework 1 Break Down Activity

Objects
- UI: 2 Texts that displays Seeds that can be planted/have been planted
- Cat(Player)
- Plant 

Attributes & Actions
- Cat’s Movement (WASD Keys)
- Plant being planted (Space Key)

How Objects affect each other
- When Player presses plant key, a plant game object spawns in the location of the player. Then, it updates the UI text based on how many plant has been planted. 
- Player Spawns Plant
- Plant Updates UI 

[Google Document to Breakdown Link](https://docs.google.com/document/d/1P3CePD4Y1e1deg4QLqAwfXm7iTLPoqPE0LJLTW0kySo/edit?tab=t.0)

## Devlog
Comparing the Breakdown Activity to the the Actual Project, most of my breakdown was directly linked to my Code. Starting with one of the major objects the player notices: The Player Character. They are able to move with WASD keys thanks to "GetKey" Methods which translate the player's position in relation to speed and the time. Then, one other action the player can take is using the SPACE key to plant. 

I used the specific method "GetKeyDown" on the space key so that the UI does not get updated if you just hold down the key, and only registers the one time you actually pressed the button. When the Space key was pressed, it calls the method PlantSeed(). Therefore, the 2 actions the player can do was established within the Player.cs Script. 

When calling the method PlantSeed(), This relates to how objects affect each other, where PlantSeed() will update the variables _numSeedsLeft and _numSeedsPlanted for not only checking if there is a possible plant that can be planted, BUT ALSO in relation to updating the UI. Within the method, I created an if statement to first check if the plants planted was less or equal to 5, then called the method in another file(PlantCountUI) to update the actual plant count to change the UI's text. Of course, before updating the UI's text, I made sure to call the Instantiate method of the plant prefab on the player's positiion first. 

This is very simple game overall, so the number objects and actions are very little(thankfully). It was overall pretty easy to account for all the actions and objects within the game. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
I would make sure to be careful with a sentence like this:

> They are able to move with WASD keys thanks to "GetKey" Methods which translate the player's position in relation to speed and the time

As I'm sure you know, the GetKey method is only used to detect input, but the Transform method is what actually translates the player. Your sentence makes it sound like GetKey is translating the player. Make sure to be super clear in your writing.

I liked that you pointed out the difference between GetKey and GetKeyDown :)

Thank you for formatting your breakdown correctly! However, please make sure to put things like the breakdown in the right section- I moved yours under the header (which starts with a #) that says 'W1L2 In-Class Activity'. You can also remove the prompt text. This will make the Devlog much easier for me to read.
