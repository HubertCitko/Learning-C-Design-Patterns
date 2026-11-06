namespace Factory.AbstractFactory
{
    public class AbstractFactoryPattern
    {
        public void Main()
        {
            new NavigationBar(new Apple());
            new DropdownMenu(new Android());
        }
        public class NavigationBar
        {
            public NavigationBar(IUIFactory factory) => factory.CreateButton();
        }
        public class DropdownMenu
        {
            public DropdownMenu(IUIFactory factory) => factory.CreateButton();
        }

        // Abstract Factory interface
        public interface IUIFactory
        {
            public Button CreateButton();
        }

        // Interface implementations for different platforms
        public class Apple : IUIFactory
        {
            public Button CreateButton()
            {
                return new Button { Type = "Apple Button" };
            }
        }
        
        public class Windows : IUIFactory
        {
            public Button CreateButton()
            {
                return new Button { Type = "Windows Button" };
            }
        }
        public class Android : IUIFactory
        {
            public Button CreateButton()
            {
                return new Button { Type = "Android Button" };
            }
        }
        // Product class
        public class Button
        {
            public required string Type { get; set; }
        }
    }
}
