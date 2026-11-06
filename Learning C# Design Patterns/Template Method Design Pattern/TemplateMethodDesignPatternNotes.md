# Template Method - Design Pattern

**Template Method** is a **Behavioral Design Pattern** that defines the skeleton of an algorithm in a base class, deferring some steps to subclasses without changing the algorithm's overall structure.

## 1. Main Idea

- Defines the overall structure and execution order of an algorithm.
- Allows subclasses to provide different implementations of individual steps.
- Avoids duplicating common algorithm logic across classes.
- Uses inheritance to allow customization while keeping the algorithm consistent.

## 2. Structure

- **Abstract Class:** Defines the Template Method (algorithm skeleton) and declares or implements its individual steps.
- **Concrete Classes:** Implement or override selected steps to provide specific behavior.
- **Template Method:** Calls the individual steps in a predefined order.

## 3. Hooks

Hooks are methods defined in the base class that allow subclasses to optionally customize or extend the algorithm.
- Can provide a default implementation.
- Can be overridden by subclasses.
- Allow optional behavior without requiring every subclass to implement it.

## 4. Advantages & Disadvantages

**Advantages:**
- Reuses common algorithm logic.
- Prevents unnecessary code duplication.
- Maintains a consistent algorithm structure.
- Allows customization of individual steps.

**Disadvantages:**

- Relies on inheritance, which increases coupling between base and derived classes.
- Changes to the base class can affect all subclasses.
- Can become difficult to maintain when the algorithm has too many customizable steps.

## 5. When to Use?

- When multiple classes share the same algorithm structure but implement certain steps differently.
- When you want to define a fixed algorithm while allowing subclasses to customize parts of it.
- When you want to reuse common behavior without duplicating the entire algorithm.
