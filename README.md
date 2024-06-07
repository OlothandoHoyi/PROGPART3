The main window is written in XAML code and contains UI elements like as labels, text boxes, buttons, and a list box. These elements are used to enter and show recipe  data. The code-behind file (MainWindow.xaml.cs) provides event handlers for button clicks and other main window functionality.

The primary elements and functionality of the code are broken down as follows:

1. The MainWindow.xaml XAML code:

With the help of numerous elements like the Grid, ColumnDefinition, RowDefinition, Label, TextBox, Button, and ListBox, the XAML code specifies the design and look of the main window.
Additionally, it has attributes for setting things like margin, content, alignment, and event handlers.
The "x:Name" attribute is used to give some items names so that the code-behind file may access them.

2.MainWindow.xaml.cs (code-behind):

The logic and event handlers for the main window are defined in the code-behind file. The main window class extends the Window class and is defined as a partial class. To hold recipe objects, it has a private field called "recipes" of type List <Recipe>. The constructor method is responsible for initializing the main window. Button click event handlers include btnAdd_Click, btnClear_Click, btnSteps_Click, btnScale_Click, and btnFilter_Click.
The event handlers do things like add recipe information to the list box, scale the quantities, empty the list box, and filter recipes based on particular parameters.

3. Steps (Steps.xaml and Steps.xaml.cs) window:

The stages window is where you can add extra steps and details to a recipe. You can add the number of steps you want to include and the description of the steps.
The XAML code defines the window's layout, which includes labels, text fields, and buttons.
The code-behind file contains button click event handlers such as btnAddSteps_Click and btnMain_Click. The btnAddSteps_Click event handler retrieves the step and description values from the text boxes and adds them to the main window's list box via a method call to the AddItems method.
The Steps window is closed by the btnMain_Click event handler.


4.Filter window (Filter.xaml and Filter.xaml.cs):

The Filter window is used to specify filter criteria for recipes.
The XAML code defines the layout of the window, which includes labels, text boxes, combo boxes, and buttons.
The code-behind file provides event handlers for button clicks such as btnFilter_Click and btnCancel_Click.
The btnFilter_Click event handler retrieves the filter criteria from the text boxes and combo box and then applies the filter to the recipes list in the main window. It checks each recipe to see whether it satisfies the filter criteria and adds it to the list box if it does.
The btnCancel_Click event handler cancels the Filter window.






A brief description of what I changed based on the lecturer’s feedback.

I have made significant changes to the readme file, ensuring that it now contains detailed information that provides everything you need to run the app successfully. The updated readme file now includes comprehensive installation instructions, system requirements, and dependencies. It also covers how to configure the app, such as setting up environment variables. Additionally, the readme file provides detailed usage instructions, including how to navigate the app's interface and perform various tasks. I have also included troubleshooting tips and frequently asked questions to address common issues. With this enhanced readme file, you can now confidently set up and run the app without any confusion or difficulty.
# PROGPART3
