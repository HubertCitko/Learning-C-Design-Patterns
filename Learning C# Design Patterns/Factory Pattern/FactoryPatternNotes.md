# Factory, Abstract Factory, Factory Method - Design Patterns

## 1. Simple Factory (Factory)

Centralizes object creation in a single class. The factory uses conditional logic to decide which concrete object to instantiate based on the client's input.

- One factory creates different implementations of a product.
- Simple to implement.
- Adding new product types usually requires modifying the factory.

## 2. Factory Method

Defines an abstract creation method in a base class, allowing subclasses to decide which concrete object to instantiate.

- Uses inheritance and method overriding.
- Subclasses implement the creation method.
- Separates object creation from object usage.

## 3. Abstract Factory

Provides an interface for creating **families of related objects** without specifying their concrete classes.

- Each concrete factory creates a compatible family of products.
- Uses factory and product interfaces.
- Makes switching between product families easy.
- Adding a new product type requires updating all concrete factories.

## 4. Main Differences

| Pattern          | Main idea                            | Creation mechanism       |
| ---------------- | ------------------------------------ | ------------------------ |
| Simple Factory   | One factory decides what to create.  | Conditional logic        |
| Factory Method   | Subclasses decide what to create.    | Inheritance / overriding |
| Abstract Factory | Creates families of related objects. | Factory interfaces       |

## 5. TO REMEMBER

- **Simple Factory:** Create one of several possible implementations.
- **Factory Method:** Let subclasses decide which implementation to create.
- **Abstract Factory:** Create multiple related objects that belong together.
