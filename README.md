# Lab07: Animal Zoo Console Application

This console application demonstrates the use of interfaces in the context of a zoo simulation. It includes two interfaces, `IEatable` and `ISleepable`, which define specific behaviors related to eating and sleeping. These interfaces are implemented by various concrete animal classes to ensure that each animal exhibits these behaviors without direct code manipulation.

## What is an Interface?

In object-oriented programming, an interface is a contract or a set of rules that define a specific behavior or functionality that a class must implement. It acts as a blueprint for implementing certain methods and properties without providing the actual implementation details. Interfaces allow different classes to share common behaviors, promoting code reusability and ensuring consistency across different implementations.

## Interfaces in This Project

### Interface: `IEatable`

The `IEatable` interface represents animals that can eat. It defines a single method `Eat()`, which all implementing classes must provide an implementation for. This allows us to treat different animals as eatable entities and call the `Eat()` method on them without knowing their specific types.

### Interface: `ISleepable`

The `ISleepable` interface represents animals that can sleep. It defines a single method `Sleep()`, which all implementing classes must provide an implementation for. Similar to the `IEatable` interface, this allows us to interact with different animals as sleepable entities, without having to be aware of their concrete types.

## Interface Implementations

1. **`Dog` and `Cat` classes**

   The `Dog` and `Cat` classes both implement both the `IEatable` and `ISleepable` interfaces. These animals can eat and sleep, so they provide implementations for both the `Eat()` and `Sleep()` methods. By doing so, we can treat instances of `Dog` and `Cat` as `IEatable` and `ISleepable` respectively, and call the corresponding methods directly.

2. **`Snake` and `Lizard` classes**

   The `Snake` and `Lizard` classes implement the `IEatable` interface. These animals can eat, so they provide an implementation for the `Eat()` method. We can treat instances of `Snake` and `Lizard` as `IEatable` objects and call the `Eat()` method on them.

3. **`Bird` class**

   The `Bird` class implements the `ISleepable` interface. This animal can sleep, so it provides an implementation for the `Sleep()` method. We can treat instances of `Bird` as `ISleepable` objects and call the `Sleep()` method.

## Interface Diagram

The following diagram shows the interfaces and their relationships with the concrete animal classes:

```
           +----------+          +----------+
           |  Animal  |          |  Animal  |
           +----+-----+          +-----+----+
                |                      |
                |                      |
                |                      |
           +----+------+         +-----+------+
           |  Dog      |         |  Cat      |
           +--+-------+         +-----+------+
              ^                        ^
              |                        |
              |                        |
              |                        |
       +------+--------+      +--------+------+
       |  Snake       |      |  Lizard      |
       +-------------+      +--------------+
       
               +-----+
               | Bird |
               +-----+
```

This diagram illustrates that the `Dog` and `Cat` classes inherit from the `Animal` class and implement both the `IEatable` and `ISleepable` interfaces. On the other hand, the `Snake` and `Lizard` classes inherit from `Animal` and implement only the `IEatable` interface. Finally, the `Bird` class inherits from `Animal` and implements the `ISleepable` interface. The interfaces ensure that each animal exhibits the specific behaviors they represent, and we can interact with these behaviors without knowing the concrete animal types.