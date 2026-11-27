namespace EsportsHub.Console.Menus
{
    public class MainMenu
    {
        public void Display()
        {
            int option;
            while (true)
            {
                ShowInterface();

                if (!int.TryParse(System.Console.ReadLine(), out option))
                {
                    DisplayInvalidInput();
                    continue;
                }
                if (!HandleOption(option))
                {
                    break;
                }
            }
        }
            
        

        private void ShowInterface()
        {
            System.Console.WriteLine("================================");
                System.Console.WriteLine("\t  ESPORTSHUB");
                System.Console.WriteLine("================================\n");

                System.Console.WriteLine("1. View Teams");
                System.Console.WriteLine("2. View Players\n");

                System.Console.WriteLine("0. Exit");

                System.Console.WriteLine("\n================================");

                System.Console.Write("Please select an option: ");
        }

        private bool HandleOption(int option)
        {
            switch (option)
            {
                case 0:
                    System.Console.WriteLine("Exiting the application...");
                    return false;
                case 1:
                    // Handle option 1
                    break;
                case 2:
                    // Handle option 2
                    break;
                default:
                    System.Console.WriteLine("Invalid option. Please enter a number between 0-2.");
                    break;
            }
            return true;
        }
        private void DisplayInvalidInput()
        {
            System.Console.WriteLine(
                "Invalid input. Please try again.\n"
            );
        }
    }
}