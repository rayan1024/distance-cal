// Distance Calculator Assignment
#nullable disable
Console.Clear();

// Ask the user to enter the coordinates of the first point
Console.WriteLine("Enter the coordinates of the first point (x y):");
double x1 = double.Parse(Console.ReadLine());

double y1 = double.Parse(Console.ReadLine());

// Prompt the user to enter the coordinates of the second point
Console.WriteLine("Enter the coordinates of the second point (x y):");
double x2 = double.Parse(Console.ReadLine());

double y2 = double.Parse(Console.ReadLine());

// Calculate the distance between the two points using the distance formula.
// Square the differnce between the x and y values, add them and take the square root

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

// Print the distance to the console
Console.WriteLine($"The distance between the two points is: {distance}");