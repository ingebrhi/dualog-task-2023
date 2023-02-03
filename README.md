# dualog-task-23
My solution to the Dualog internship task. 

## Understanding of requirements
I have implemented all the requirements as I understood them. A short explenation follows concerning my changes.

I implemented the IFormattable interface with knots as the default value, but wanted the user input to dictate how the vessels would show. Knots is therfore the default in the interface, but not when you run the program, as the user needs to input whether they would like knots or meters per second. 

I also added the speed to the constructor in the vessel-class, to make it easier to implement this into each vessel. 

## Testing
I strugguled with Xunit testing in Visual Studio Code. It would not recognize my project at all. This is therfore a brief explenation of how I would have liked to test

For one a unit test checking the type of vessel would be benficial. Also, a unit test to check the added fields for each type of vessel. I would also check that my exceptions are thrown as they are supposed to. Finally I would test the interface, especially if knots is the default and if both KN and MS work.