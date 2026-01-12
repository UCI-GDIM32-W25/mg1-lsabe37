[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Write your Devlog here!

Leo Abe, he/him

The plan I wrote in the MG1 breakdown activity helped me write the code for updating the UI text. In the plan, I wrote that the text should update when the user presses the space bar. When the user presses the space bar, they will plant a seed, which should cause the number of planted seeds to go up by 1 and the number of remaining seeds to go down by 1. Using this idea, I created a method called UpdateSeeds in the PlantCoutnUI class. This method takes in two int values, one for the number of seeds remaining and one for the number of seeds planted, and displays these two int values in the form of strings using ToString(). I then called the UpdateSeeds method in the Player class. This method is called inside an if statement which runs only if the number of seeds remaining is greater than 0 and the user pressed the space bar. This if statement is inside an Update method. With this code, whenever the player presses the space button, as long as there are more than 0 seeds remaining, a plant prefab will be instantiated at the position of the player game object's transform and the UI will add 1 count to the number of seeds planted and subtracted 1 count from the number of seeds remaining. Once the number of seeds remaining reaches 0, nothing will happen when the player presses the space bar.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
