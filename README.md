# DecoratorPattern

**Definition** Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality. 

**Applicability**

Use Decorator 

- to add responsibilities to individual objects dynamically and transparently, that is, without affecting other objects.  
- for responsibilities that can be withdrawn.  
- when extension by subclassing is impractical. Sometimes a large number of independent extensions are possible and would produce an explosion of subclasses to support every combination. Or a class definition may be hidden or otherwise unavailable for subclassing.  

**Consequences**

- More flexibility than static inheritance
- Avoids feature-laden classes high up in the hierarchy
- A decorator and its component aren't identical
- Lots of little objects

**Related Patterns**

- [Adapter](https://github.com/andreidana/AdapterPattern)
- [Composite](https://github.com/andreidana/CompositePattern)
- [Strategy](https://github.com/andreidana/StrategyExample)