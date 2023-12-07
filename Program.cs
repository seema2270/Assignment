namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            // Create an instance of the Car class
            Car myCar = new Car("Toyota", 2022, 25000.50f);

            // Display car details
            Console.WriteLine("Car Details:");
            myCar.DisplayCarDetails();




            
               // Create an instance of the BankAccount class
                BankAccount myAccount = new BankAccount("123456789");

                // Perform a deposit of 1000 units
                myAccount.Deposit(1000m);

                // Withdraw 500 units
                myAccount.Withdraw(500m);

                // Print out the final balance
                Console.WriteLine($"Final Balance: {myAccount.GetBalance()} units");





            // Create an instance of the Rectangle class
            Rectangle myRectangle = new Rectangle(4.5f, 3.2f);

            // Call the CalculateArea method and print out the result
            float area = myRectangle.CalculateArea();
            Console.WriteLine($"Area of the rectangle: {area}");

            // Create an instance of the Circle class with a radius of 5
            Circle myCircle = new Circle(5);

            // Call the CalculateArea method and print out the result
            float area2 = myCircle.CalculateArea();
            Console.WriteLine($"Area of the circle: {area2}");





            // Create an instance of the Student class
            Student johnDoe = new Student("John Doe", 20, "Computer Science");

            // Call the Introduce method
            johnDoe.Introduce();




            Stack<int> intStack = new Stack<int>();

            // Perform various push and pop operations
            intStack.Push(10);
            PrintStack(intStack);

            intStack.Push(20);
            PrintStack(intStack);

            intStack.Push(30);
            PrintStack(intStack);

            int poppedItem = intStack.Pop();
            Console.WriteLine($"Popped item: {poppedItem}");
            PrintStack(intStack);

            int peekedItem = intStack.Peek();
            Console.WriteLine($"Peeked item: {peekedItem}");
            PrintStack(intStack);
        }

        // Helper method to print the remaining items in the stack
        static void PrintStack<T>(Stack<T> stack)
        {
            Console.WriteLine("Stack Contents:");
            if (stack.IsEmpty())
            {
                Console.WriteLine("Empty");
            }
            else
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }





            // Create an instance of the Calendar class
            Calendar myCalendar = new Calendar();

            // Call the PrintWeekdays method
            myCalendar.PrintWeekdays();





            // Create two instances of the Point2D struct
            Point2D pointA = new Point2D(1.0f, 2.0f);
            Point2D pointB = new Point2D(4.0f, 6.0f);

            // Calculate the distance between the two points
            float distance = DistanceCalculator.CalculateDistance(pointA, pointB);

            // Print out the result
            Console.WriteLine($"Distance between Point A and Point B: {distance}");
        }

       
    }

   

}