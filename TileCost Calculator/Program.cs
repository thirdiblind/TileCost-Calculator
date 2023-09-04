using System;
namespace TileCost_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is a Tile Cost Calculator. Calculate the cost of flooring based on total area and material cost.");
            //Set Width
            Console.WriteLine("How many rooms need flooring?");
            string totalRoomsInput = Console.ReadLine();
            int totalRooms = Int32.Parse(totalRoomsInput);
            int grandTotalCost = 0;
            int totalArea = 0;
            int totalHours = 0;

            for (int roomNumber = 1; roomNumber <= totalRooms; roomNumber++)
            {
                Console.WriteLine("Enter the width of room " + roomNumber + ":");
                string widthInput = Console.ReadLine();
                int width = Int32.Parse(widthInput);
                //Set Length
                Console.WriteLine("Enter the lenth of room " + roomNumber + ":");
                string lengthInput = Console.ReadLine();
                int length = Int32.Parse(lengthInput);
                int area = width * length;
                //Set Cost Per Unit of Flooring
                Console.WriteLine("Enter the cost per unit of flooring for room " + roomNumber + ":");
                string costPerUnitInput = Console.ReadLine();
                int costPerUnit = Int32.Parse(costPerUnitInput);
                //Calculate totalCost of room
                int costPerRoom = width * length * costPerUnit;
                //Output individual room cost
                Console.WriteLine("Cost of room " + roomNumber + ": $" + costPerRoom);
                totalArea += area;
                grandTotalCost += costPerRoom;
                //Output Total Cost of Flooring
            }
            totalHours = totalArea / 20;  //  20 units per hour 

            Console.WriteLine("Total cost of labor = ("+totalArea+" units / 20 units per hour) = "+totalHours+ " | "+totalHours+" hours * $86.00 per hour: $" + totalHours * 86);
            Console.WriteLine("Total cost of flooring: $" + grandTotalCost);
        }
    }
}