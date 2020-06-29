using System;

class MainClass {
  public static void Main (string[] args) {

    int counter = 1;
    double total = 0;
    while(counter <= 7)
    
{
    Console.WriteLine("Enter distance in miles covered by car #" + counter);
    int distance = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter time in hours covered by car #" + counter);
    int time = Convert.ToInt32(Console.ReadLine());
    double speed = distance / time;
    Console.WriteLine("Speed of car #" + counter + " is " + speed + " mph");
    total = total + speed;
    counter++;
}
    double average = total / 7;
    Console.WriteLine("The average speed of the 7 cars is " + average);
  }
}