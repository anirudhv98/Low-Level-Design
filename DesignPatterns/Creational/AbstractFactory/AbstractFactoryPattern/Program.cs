using AbstractFactoryPattern;

IGUIFactory gUIFactory = new MacFactory();

IButton button = gUIFactory.CreateButton();

ICheckbox checkbox = gUIFactory.CreateCheckbox();

button.Render();

checkbox.Render();