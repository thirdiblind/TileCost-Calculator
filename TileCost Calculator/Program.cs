using System;
using System.Xml.Schema;

namespace TileCost_Calculator
{
    internal class Program
    {

        const float PI = (float)Math.PI; // For the circle area calculation
        const float AREA_PER_HOUR = 20f; // Units of area one can work in an hour
        const float HOURLY_RATE = 86f; // Hourly labor rate

        const int RECTANGULAR_ROOM = 1;
        const int NON_RECTANGULAR_ROOM = 2;
        const int TRIANGULAR_ROOM = 1;
        const int CIRCULAR_ROOM = 2;

        static void Main(string[] args)
        {
            //Declaring float 
            float area = 0;

            Console.WriteLine("Hello, this is a Tile Cost Calculator. Calculate the cost of flooring based on total area, labor and material cost.");
            
            //Set shape of room
            Console.WriteLine();
            Console.WriteLine("To start, select a room shape:");
            Console.WriteLine("1. For rectangular rooms.");
            Console.WriteLine("2. For non-rectangular rooms.");
            Console.Write("Enter your choice (1 or 2): ");
            int roomShape = Int32.Parse(Console.ReadLine());
            

            //Error handling for when option 1 or 2 is NOT selected.. 
            if (roomShape == RECTANGULAR_ROOM || roomShape == NON_RECTANGULAR_ROOM)
            {

                //Rectangular room calcuation
                if (roomShape == RECTANGULAR_ROOM)
                {
                    //Set Width
                    Console.Write("Enter the width of the room: ");
                    int width = Int32.Parse(Console.ReadLine());

                    //Set Length
                    Console.Write("Enter the lenth of room: ");
                    int length = Int32.Parse(Console.ReadLine());

                    //Calculate area of the rectangular room
                    area = width * length;
                }

                //Non-Rectangular room calculations (Triangle and Circle)
                if (roomShape == NON_RECTANGULAR_ROOM)
                {
                    //Set shape of non-rectangular room
                    Console.WriteLine();
                    Console.WriteLine("Okay, so the room is non-rectangular.");
                    Console.WriteLine("To start, select a room shape:");
                    Console.WriteLine("1. For triangular rooms.");
                    Console.WriteLine("2. For circular rooms.");
                    Console.Write("Enter your choice (1 or 2): ");
                    int nonRectRoomShape = Int32.Parse(Console.ReadLine());
                    
                    //Did not implement error handling here

                    //Triangular room calcuation
                    if (nonRectRoomShape == TRIANGULAR_ROOM)
                    {
                        Console.WriteLine("To calculate the area of a triangle, width must by multipled by length, then dividied by 1/2. ");
                        Console.WriteLine();

                        //Set Width
                        Console.Write("Enter the width of the room: ");
                        int widthTriangle = Int32.Parse(Console.ReadLine());

                        //Set Length
                        Console.Write("Enter the lenth of room: ");
                        int lengthTriangle = Int32.Parse(Console.ReadLine());

                        //Calculate area of the triangle
                        area = (widthTriangle * lengthTriangle) / 2;
                    }

                    //Circle room calcuation
                    if (nonRectRoomShape == CIRCULAR_ROOM)
                    {
                        Console.WriteLine("To calculate the area of a circle, pie is multipled by radius squared. ");

                        //Set Radius
                        Console.Write("Enter the radius of the circular room: ");
                        float radiusCircle = float.Parse(Console.ReadLine());

                        //Calculate area of the circle
                        area = (radiusCircle * 2 * PI);
                    }
                }

                //Set cost per unit
                Console.Write("Enter the cost per unit of flooring for the room: ");
                float costPerUnit = float.Parse(Console.ReadLine());

                //Calculate all costs
                float materialCost = area * costPerUnit;
                float laborHours = area / AREA_PER_HOUR;
                float laborCost = laborHours * HOURLY_RATE;
                float totalCost = laborCost + materialCost;

                //Output all costs
                Console.WriteLine();
                Console.WriteLine("Cost of materials: $" + materialCost);
                Console.WriteLine();
                Console.WriteLine("Cost of labor: $86/hr * " + laborHours + " hours = $" + laborCost);
                Console.WriteLine();
                Console.WriteLine("Total cost: $" + totalCost);
            }
            else
            {
                Console.WriteLine("Your input does not match a room type. Close and run the program again.");
            }
        }
    }
}