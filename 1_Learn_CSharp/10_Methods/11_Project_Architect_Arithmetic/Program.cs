/*
Architect Arithmetic
Architects have big ideas – but big ideas can be expensive. How expensive? It depends on the size.

In this project, you’ll use methods to build a program that calculates the material cost for any architect’s floor plan. For example, the floor plan of the Pantheon in Rome, Italy:

The Pantheon blueprint shows that it is comprised of two approximate areas: there is a large circular area and a smaller rectangle that protrudes out of the circle

…can be (approximately) broken into a circle and a rectangle:

The Pantheon can be broken into a circle with a 21.5-meter radius and a rectangle that is 15 meters by 18 meters

Using mathematical formulas, we can calculate the area of each shape and find the total:

double totalArea = Circle(21.5) + Rect(15, 18);

Copy to Clipboard

You’ll be defining area methods like Circle() and Rect(), but we’ll provide the formulas for you to use.

Finally, we multiply the total area by the cost of each unit of flooring material. Let’s assume that tiles cost ₤100 each:

double tileCost = 100;
double totalCost = totalArea * tileCost;

Copy to Clipboard

Although the floor plan isn’t exactly one circle and rectangle, this approximation is good enough for estimating costs. Let’s get started!

Tasks
0/10 complete
Mark the tasks as complete by checking them off
Define Methods
1.
We’ll need to define a method for each basic shape. Let’s start with rectangles. Define a method with two parameters (length and width) that returns the area of the rectangle.

Here’s the formula for rectangular area:

a
r
e
a
=
l
e
n
g
t
h
×
w
i
d
t
h
area=length×width
For all numbers in this project, use the double data type.

2.
Now circles. Define a method with one parameter (radius) that returns the area of the circle.

Use Math.PI to represent the number pi, and Math.Pow() to square the radius.

a
r
e
a
=
π
×
r
a
d
i
u
s
2
area=π×radius 
2
 
3.
We’ll also need triangles. Define a method with two parameters (bottom and height) that returns the area of the triangle.

a
r
e
a
=
0
.
5
×
b
o
t
t
o
m
×
h
e
i
g
h
t
area=0.5×bottom×height
4.
Test that your methods work with these test cases:

A rectangle with length 4 and width 5 has an area of 20.
A circle with radius 4 has an area of about 50.
A triangle with base 10 and height 9 has an area of 45.
Don’t forget that you need to use dotnet run to run the program!

Calculate Cost
5.
Find the area of the floor plan. We’ll use an adapted version of the ancient city in Mexico: Teotihuacan, which you can see as image to the right.

On paper or in your head, break down the floor plan using circles, rectangles, and triangles.

6.
Calculate the area of each part, add them together, and store the result in a variable.

7.
Multiply the total area by the cost of flooring material – 180 Mexican pesos – and store the result in a variable.

8.
Write the result to the console, explaining what the number means. Use string interpolation.

9.
Pesos should only have two decimal places, so use a built-in method to round the value.

10.
For an extra challenge, try these additions:

Make the entire program a method so that you can execute it in your Main() method with one line:
CalculateTotalCost();

Copy to Clipboard

Determine the total cost for the Taj Mahal in Agra, India and the Al-Masjid al-haram (Great Mosque) in Mecca, Saudi Arabia.
The Blueprint of the Taj Mahal reveals that it is comprised of a large square with a small right triangle missing at each of the four corners. The square has a side length of 90.5 meters. The base and height of each triangle is 24 meters.

The Blueprint of the Great Mosque of Mecca reveals that it is comprised of two main areas: a smaller rectangle and a larger rectangle. The smaller rectangle is 106 meters by 180 meters. The larger rectangle is 284 meters by 264 meters, but there is a triangular area missing from the larger rectangle. The missing triangle has a base of 264 meters and a height of 84 meters.

Use conditional statements and Console.ReadLine() to allow users to pick which monument for which they’d like to calculate a cost.
What monument would you like to work with? Teotihuacan
The plan for that monument costs 748510782.02 pesos!

*/

using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(AreaRectangle(4, 5)); // 20
      Console.WriteLine(AreaCircle(4));       // 50.26548245743669
      Console.WriteLine(AreaTriangle(10, 9)); // 45

      double areaTriangleTeo = AreaRectangle(750, 500);
      double areaRectangleTeo = AreaRectangle(2500, 1500);
      double halfAreaCircleTeo = AreaCircle(375) / 2;
      double totalAreaTeo = areaTriangleTeo + areaRectangleTeo + halfAreaCircleTeo;
      Console.WriteLine(totalAreaTeo);
      double costOneArea = 180;
      double totalCostTeo = Math.Round((totalAreaTeo * costOneArea), 2);
      

      Console.WriteLine($"Teotihuacan plan cost {totalCostTeo} Mexican Peso");
    }
    // 1. We’ll need to define a method for each basic shape. Let’s start with rectangles. Define a method with two parameters (length and width) that returns the area of the rectangle.
    static double AreaRectangle(double length, double width)
    {
      double area = length * width;
      return area;
    }

    // 2. Now circles. Define a method with one parameter (radius) that returns the area of the circle. Use Math.PI to represent the number pi, and Math.Pow() to square the radius.
    static double AreaCircle(double radius)
    {
      double area = Math.PI * (radius * radius);
      return area;
    }

    // 3. We’ll also need triangles. Define a method with two parameters (bottom and height) that returns the area of the triangle.
    static double AreaTriangle(double bottom, double height)
    {
      double area = 0.5 * bottom * height;
      return area;
    }


  }
}


