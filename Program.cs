using System;

class Program
{
    static void Main()
    {
        string[] prod = { "Avocado", "Broccoli", "Corn", "Dragon Fruit", "Eggplant", "Fries" };
        int[] price = { 55, 10, 32, 12, 22, 18 };
        string[] desc = { "Lots of Vitamins", "Healthy", "Yellow", "Antioxidants", "A Fruit", "Cheesy" };
        int[] qty = { 252, 101, 123, 300, 115, 188 };

        while (true)
        {
            Console.WriteLine("Choose sorting criteria:");
            Console.WriteLine("1. Price");
            Console.WriteLine("2. Quantity");
            Console.Write("Enter your choice (1 or 2): ");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose sorting order:");
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");
            Console.Write("Enter your choice (1 or 2): ");

            int order = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                SelectionSort(price, order == 1);
            }
            else if (choice == 2)
            {
                SelectionSort(qty, order == 1);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                continue;
            }

            Console.WriteLine("Sorted Products:");
            Console.WriteLine("-----------------");
            for (int i = 0; i < prod.Length; i++)
            {
                Console.WriteLine($"{prod[i]} - {price[i]} - {desc[i]} - {qty[i]}");
            }

            Console.WriteLine("-----------------");

            Console.WriteLine("Do you want to continue? (y/n): ");
            string continueChoice = Console.ReadLine().ToLower();

            if (continueChoice != "y")
            {
                break;
            }
        }
    }

    static void SelectionSort(int[] arr, bool ascending)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if ((ascending && arr[j] < arr[minIndex]) || (!ascending && arr[j] > arr[minIndex]))
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}
