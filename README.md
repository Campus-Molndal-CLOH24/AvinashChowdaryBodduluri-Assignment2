# AvinashChowdaryBodduluri-Assignment2

## About the Project:
- It is a Vehicle Management Project for a simple vehicle factory in C# that can create and manage different types of vehicles by object-oriented principles such as inheritance, polymorphism and interfaces.
  
## Classes
- **Program:** Contains Main method to start the console application.
- **CarImpl:** Based on which Car instance is created. Also has few methods for Car actions. It also has Implementations specific for a Car to Methods defined by Ivehicle & IDriveable interfaces.
- **MotorcycleImpl:** Based on which Motorcycle instance is created. It also has Implementations Specific for a Motorcycle to Methods defined by Ivehicle & IDriveable interfaces.
- **IVehicle:** Interface that has basic properties for a Vehicle. Also has few methods to be implemented(1.to check if engine is on or not, to start engine & to stop engine) 
- **ICar:** Interface that Car specific properties. 
- **IMotorcycle:** Interface that Motorcycle specific properties. 
- **IDriveable:** Interface that has a Drive method to be Implemented. 
- **IVehicleFactory:** Interface that has CreateVehicle Method to be Implemented for creating a vehicle instance. 

## License
- This project is licensed under the **MIT License**.
