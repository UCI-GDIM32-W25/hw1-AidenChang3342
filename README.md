[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!

--------------------------
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
--------------------------
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

Comparing the Breakdown Activity to the the Actual Project, most of my breakdown was directly linked to my Code. Starting with one of the major objects the player notices: The Player Character. They are able to move with WASD keys thanks to "GetKey" Methods which translate the player's position in relation to speed and the time. Then, one other action the player can take is using the SPACE key to plant. 

I used the specific method "GetKeyDown" on the space key so that the UI does not get updated if you just hold down the key, and only registers the one time you actually pressed the button. When the Space key was pressed, it calls the method PlantSeed(). Therefore, the 2 actions the player can do was established within the Player.cs Script. 

When calling the method PlantSeed(), This relates to how objects affect each other, where PlantSeed() will update the variables _numSeedsLeft and _numSeedsPlanted for not only checking if there is a possible plant that can be planted, BUT ALSO in relation to updating the UI. Within the method, I created an if statement to first check if the plants planted was less or equal to 5, then called the method in another file(PlantCountUI) to update the actual plant count to change the UI's text. Of course, before updating the UI's text, I made sure to call the Instantiate method of the plant prefab on the player's positiion first. 

This is very simple game overall, so the number objects and actions are very little(thankfully). It was overall pretty easy to account for all the actions and objects within the game. 





## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
