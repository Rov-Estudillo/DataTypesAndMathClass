internal class Program
{
    private static void Main(string[] args)
    {
        //array for 5 grades that we need to enter
        double[] grades = new double[5];

        //loop to ask for 5 grades
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"Enter Grade {i + 1}: ");
            //converting the input to double adn checking if the input is valid
            while (!double.TryParse(Console.ReadLine(), out grades[i]))
            {
                Console.Write("Invalid input. Please enter a valid Grade: ");
            }              
        }

        //calculating the average
        double ave = 0;
        foreach (var grade in grades)
        {
            ave += grade;
        }
        ave /= grades.Length;

        //printing the result
        Console.WriteLine();
        int aveInt = (int)Math.Floor(ave);
        Console.WriteLine($"The averege is {ave} and round off to {aveInt}");
        
    }
}