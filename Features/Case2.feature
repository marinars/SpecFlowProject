Feature:Select color
Form 2 - Changing colors on form 2
Scenario:Selecting an existing color
Given That the user wants to select an existing color in the system
When and selects the color YELLOW
Then the box should change color

Scenario:Selecting a non-existent color
Given That the user wants to select an existing color in the system
When and selects the green color
Then the box should change color
