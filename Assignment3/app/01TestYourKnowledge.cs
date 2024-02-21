// 1. What are the six combinations of access modifier keywords and what do they do? 
// public: Accessible from any code in the same assembly or another assembly that references it.
// private: Accessible only from within the same class or struct.
// protected: Accessible only within the same class or its derived classes.
// internal: Accessible only within the same assembly.
// protected internal: Accessible within the same assembly or from within a derived class in any assembly.
// private protected: Accessible within the same assembly by types derived from the containing class.
// 2.What is the difference between the static, const, and readonly keywords when applied to a type member?
// static: A static member is callable on a class even when no instance of the class has been created. 
// The static modifier is used to declare a static member, which belongs to the type itself rather than to a specific object.
// const: A constant member is defined at compile time and cannot be changed at runtime. 
// Constants are declared as a field, using the const keyword and must be initialized as they are declared.
// readonly: A readonly member represents an unchanging value.
// 3. What does a constructor do?
// A constructor is a special method of a class or structure in object-oriented programming that initializes an object of that type.
// 4. Why is the partial keyword useful?
// The partial keyword is used to create a partial class. A partial class is a class that can be split into two or more files.
// 5. What is a tuple?
// A tuple is a data structure that is an ordered list of elements. Each element can be of a different type.
// 6. What does the C# record keyword do?
// The record keyword is used to define a reference type that provides built-in functionality for encapsulating data.
// 7. What does overloading and overriding mean?
// Overloading: Overloading is defining multiple methods with the same name but with different parameters.
// Overriding: Overriding is a feature that allows a subclass or child class to provide a specific implementation of 
//a method that is already provided by one of its super-classes or parent classes.
// 8. What is the difference between a field and a property?
// A field is a variable that is declared directly in a class or struct. A property is a member that provides a flexible
// mechanism to read, write, or compute the value of a private field.
// 9. How do you make a method parameter optional?
// You can make a method parameter optional by assigning a default value to the parameter.
// 10. What is an interface and how is it different from abstract class?
// An interface is a reference type that is similar to a class. It is a collection of abstract methods. An abstract class is a class that cannot
// be instantiated and is typically used as a base class for other classes.
// 11. What accessibility level are members of an interface?
// Members of an interface are implicitly public and abstract.
// 12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.
// True
// 13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
// True
// 14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
// False
// 15. True/False. Abstract methods can be used in a normal (non-abstract) class. 
// False
// 16. True/False. Normal (non-abstract) methods can be used in an abstract class. 
// True
// 17. True/False. Derived classes can override methods that were virtual in the base class. 
// True
// 18. True/False. Derived classes can override methods that were abstract in the base class. 
// True
// 19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the base class.
// False
// 20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.
// False
// 21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
// True
// 22. True/False. A class can have more than one base class.
// False
// 23. True/False. A class can implement more than one interface.
// True