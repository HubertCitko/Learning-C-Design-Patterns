using static FactoryMethod.FactoryMethodPattern;


new NavigationBar();
new DropdownMenu();
new AndroidNavigationBar();
new AndroidDropdownMenu();


namespace FactoryMethod
{

    public class FactoryMethodPattern
    {
        
        public abstract class Element
        {
            protected abstract Button CreateButton();
            public Element() => CreateButton();
        }
        public class NavigationBar : Element
        {
            protected override Button CreateButton() => new Button { Type = "Navigation Bar Button" };
        }
        public class AndroidNavigationBar : Element
        {
            protected override Button CreateButton() => new Button { Type = "Android Navigation Bar Button" };
        }
        
        public class DropdownMenu : Element
        {
            protected override Button CreateButton() => new Button { Type = "Dropdown Menu Button" };
        }
        public class AndroidDropdownMenu : Element
        {
            protected override Button CreateButton() => new Button { Type = "Android Dropdown Menu Button" };
        }
        
        // Product class
        public class Button
        {
            public required string Type
            {
                get; set
                {
                    field = value;
                    Console.WriteLine($"Button created: {value}");
                }
            }
        }
    }
}