# When polymorphism isn’t always a good idea?

First, let’s be clear at the beginning, polymorphism is an essential part of object-oriented programming that enables you to define behaviour shared by multiple classes but can be changed for each class separately. I would like to share something from my experience in order to showcase in simple examples how to reduce  complexity of code.
In some ways, polymorphism could be constructive for reusing code and keeping the maintainability part. It makes coding less painful. But, like any other programming method, there are times when polymorphism might not be the best option.

## Derived classes behave differently than base classes

Consider a base class called Car with a method called StartEngine() that tells the engine how to start. Suppose you have derived classes like MercedesBenzCar and TeslaModelSCar. In that case, you might be able to use polymorphism to define the StartEngine() method in the base Car class and then override that method in the derived classes to provide the specific implementation for each type of Car. Nonetheless,  this can get you into trouble. Let’s review some code.

If you like read full post check this out this [link]().

