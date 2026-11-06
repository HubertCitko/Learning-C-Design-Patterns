namespace Factory.Factory
{
    public class FactoryPattern
    {
        void Main()
        {
            new NavigationBar();
            new DropdownMenu();
        }

        public class NavigationBar
        {
            public NavigationBar() => ButtonFactory.CreateButton();
        }
        public class DropdownMenu
        {
            public DropdownMenu() => ButtonFactory.CreateButton();
        }
        public class ButtonFactory
        {
            public static Button CreateButton()
            {
                return new Button { Type = "Default Button" };
            }
        }
        public class Button
        {
            public required string Type { get; set; }
        }
    }
}
