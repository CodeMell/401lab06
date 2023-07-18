# Animal Zoo Console Application

This console application demonstrates the use of Object-Oriented Programming (OOP) principles through a zoo simulation. The application implements various animal classes, showcases inheritance and polymorphism, and exhibits the four main OOP principles: inheritance, polymorphism, abstraction, and encapsulation.

## UML Diagram

Here is a digital UML diagram representing the class hierarchy and relationships in the zoo simulation:

                                     +----------+
                                     |  Animal  |
                                     +----------+
                                          |
                     _____________________|___________________
                    |                     |                   |
               +---------+           +----------+         +----------+
               | Mammal  |           |  Reptile |         |   Bird   |
               +---------+           +----------+         +----------+
                    |                     |                   |
         +-------------------+   +-------------------+
         |                   |   |                   |
      +------+           +------+              +--------+
      | Dog  |           | Cat  |              | Snake  |
      +------+           +------+              +--------+
                            |
                        +--------+
                        | Lizard |
                        +--------+

## OOP Principles

### 1. Inheritance

Inheritance is a fundamental OOP principle that allows classes to inherit properties and behaviors from their parent classes. In this project, we have implemented inheritance in the following ways:
- The classes `Mammal` and `Reptile` inherit from the `Animal` class, inheriting its properties and abstract methods.
- The concrete classes, such as `Dog`, `Cat`, `Snake`, `Lizard`, and `Bird`, inherit from their respective parent classes and gain access to their behaviors and properties.

### 2. Polymorphism

Polymorphism allows objects of different types to be treated as objects of a common base type. It enables flexibility and extensibility in the code by allowing different objects to respond differently to the same method call. In this project, we have demonstrated polymorphism in the following ways:
- The `Animal` class is used as a base type, and objects of concrete animal classes are assigned to it. For example, `Animal dog = new Dog();` allows us to treat a `Dog` object as an `Animal` object.
- The `Eat()` and `Sleep()` methods are defined in the `Animal` class and overridden in the concrete animal classes, allowing each animal to exhibit its specific behavior.

### 3. Abstraction

Abstraction involves the creation of abstract classes or interfaces that provide a common structure and set of methods for related classes. It allows for defining common behavior while leaving the implementation details to the derived classes. In this project, we have applied abstraction in the following ways:
- The `Animal` class is an abstract class that defines the common properties and abstract methods shared by all animals.
- The `Mammal` and `Reptile` classes are abstract classes that further specialize the behavior of animals based on their characteristics.

### 4. Encapsulation

Encapsulation is the principle of bundling data and methods into a single unit, called a class, and hiding the internal details of an object from the outside world. It helps in achieving data abstraction and ensures that the internal state of an object is accessed and modified through controlled methods. In this project, we have implemented encapsulation in the following ways:
- Each animal class encapsulates its specific behaviors and properties. For example, the `Dog` class encapsulates the `Eat()`, `Sleep()`, and `GiveBirth()` methods and the `Name` property.
- Access modifiers (e.g., `public`, `protected`) are used to control the visibility and accessibility of class members, allowing encapsulation to be maintained.

These OOP principles help in creating a well-structured, modular, and extensible codebase by promoting code reusability, flexibility, and maintainability.

