
## Single Responsibility Principle**

The single responsibility principle states that every class should have only one responsibility and that responsibility should be entirely encapsulated by the class. 
All its services should be narrowly aligned with that responsibility.  
SRP applies to both Object Oriented 

The **advantages** of following the Single Responsibility Principle (SRP) include the following:

    Better code organization and maintainability.
    Improved readability and understanding of code.
    Easier debugging and testing of code.
    A higher degree of code reusability.
    Facilitation of parallel development and implementation of new features.
    Ability to make changes to code with less risk of introducing bugs.

Some of the **disadvantages** of the Single Responsibility Principle (SRP) include the following:

    Potential for over-engineering, leading to too much abstraction and unnecessary code.
    Difficulties in determining the appropriate granularity of responsibilities.

## **Open Closed Principle**

It states that software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification. 
It mean When applications requirements change, we should be able to expand the module.
In other words, we should have the ability to extend classes, making them more functional. At the same time, the behavior of the old methods does not change, and class itself is not changing to.

**Benefit** of this principle is **Maintainability**: The closed nature of the modules ensures that changes to one part of the software code don't affect other parts. 
This will reduce the likelihood of unintended bugs or complexity and make the system easier to maintain.

## **Liskov Substitution Principle**

Derived types must be completely substitutable for their base types that mean, if S is a subtype of T, then objects of type T in a program may be replaceable with objects of type S without altering any of the desirable properties of that program or without affecting the correctness of the program.
It specifically deals with the concept of subtyping and inheritance in OOP. 
Code that adheres to LSP is **loosely dependent** to each other and encourages **code reusability**. 

## **Interface Segregation Principle**

Interface segregation principle (ISP) states that no class code should be forced to depend on methods it does not use. 
ISP splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about the methods that are of interest to them.
ISP emphasis on Smaller, Focused Interfaces. Each interface represents a cohesive set of related methods. When classes implement these smaller interfaces, they only depend on the methods they need, avoiding unnecessary and unused functionalities. This selective implementation reduces dependencies and coupling between classes.
ISP is intended to keep a **system decoupled**  and thus make it easier to **refactor, change, and redeploy**.

## **Dependency Inversion Principle**

Dependency inversion talks about the coupling between the different classes or modules.
The main motto of the dependency inversion is any higher classes should always depend upon the abstraction of the class rather than the detail.
This aims to reduce the coupling between the classes is achieved by introducing abstraction between the layer, thus doesn’t care about the real implementation.
**The principle states:**
High-level modules should not depend on low-level modules. Both should depend on abstractions.
Abstractions should not depend on details. Details should depend on abstractions.

**Pros of Dependency Injection**

1. *Better Testability*
One of the main advantages of using dependency injection is that it can greatly improve the testability of your code. By separating dependencies from the class that uses them, it’s much easier to create unit tests for that class. You can simply create a mock object to simulate the behavior of the dependency, rather than having to create a real instance of it. This makes it easier to write tests that are isolated and repeatable.

2. *Easier to Maintain*
Another advantage of dependency injection is that it can make your code easier to maintain. By separating dependencies from the class that uses them, you can make changes to those dependencies without having to change the class itself. This can reduce the risk of introducing bugs and make it easier to modify your code as your application evolves.

3. *Better Code Reusability*
Dependency injection can also make it easier to reuse code across multiple applications. By creating reusable classes and interfaces, you can inject them into different classes and applications without having to duplicate code. This can save time and reduce the amount of code you need to maintain.

4. *Reduced Coupling*
Dependency injection can help reduce coupling between classes in your application. Coupling refers to the degree to which one class depends on another. When a class creates its own dependencies, it’s tightly coupled to those dependencies. By using dependency injection, you can reduce that coupling by creating a separation between the class and its dependencies.

**Cons of Dependency Injection**

1. *Increased Complexity*
One potential downside of dependency injection is that it can add complexity to your code. When you use DI, you’re creating additional classes and interfaces to manage your dependencies. This can make your code harder to understand and more difficult to maintain.

2. *Performance Overhead*
Another potential downside of dependency injection is that it can add some performance overhead. When you use DI, you’re creating additional objects and interfaces that need to be managed by the .NET runtime. This can slow down your application, especially if you have a large number of dependencies.

