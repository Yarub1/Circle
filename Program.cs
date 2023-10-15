using System;
/// <summary>
/// The code provided defines three classes: Circle, Sphere, and Triangle. Each class has methods to calculate the area and/or
/// perimeter of the corresponding shape.The Main method creates instances of these classes and calls the respective methods to
/// calculate and display the results.
/// </summary>

class Circle
{
    /// <summary>
    /// This block of code defines the Circle class. It has two private fields: _pi and _radius.
    /// _pi stores the value of pi (approximately 3.141), and _radius stores the radius of the circle.
    /// The class has a constructor that takes an int parameter radius and assigns it to the _radius field.
    /// It also has two methods: GetArea() and GetCircumference(). GetArea() calculates and returns the area
    /// of the circle using the formula pi * radius * radius. GetCircumference() calculates and returns the
    /// circumference of the circle using the formula 2 * pi * radius.
    /// </summary>

    private float _pi = 3.141f; // Define a private field _pi with the value of Pi for circle area calculations.
    private int _radius;       // Define a private field _radius to store the radius of the circle.

    public Circle(int radius) // Constructor for the Circle class that takes a radius as a parameter.
    {
        _radius = radius;    // Initialize the _radius field with the provided radius.
    }

    public float GetArea() // Method to calculate and return the area of the circle.
    {
        return _pi * _radius * _radius; // Calculate the area using the formula: Pi * radius^2.
    }

    public float GetCircumference() // Method to calculate and return the circumference of the circle.
    {
        return 2 * _pi * _radius; // Calculate the circumference using the formula: 2 * Pi * radius.
    }
}

class Sphere
{
    /// <summary>
    /// This block of code defines the Sphere class. It has two private fields: _pi and _radius. _pi stores the value of pi
    /// (approximately 3.141), and _radius stores the radius of the sphere. The class has a constructor that takes an int
    /// parameter radius and assigns it to the _radius field. It also has two methods: GetSurfaceArea() and GetVolume().
    /// GetSurfaceArea() calculates and returns the surface area of the sphere using the formula 4 * pi * radius * radius.
    /// GetVolume() calculates and returns the volume of the sphere using the formula (4 / 3) * pi * radius * radius * radius.
    /// </summary>
    
    private float _pi = 3.141f; // Define a private field _pi with the value of Pi for sphere calculations.
    private int _radius;       // Define a private field _radius to store the radius of the sphere.

    public Sphere(int radius) // Constructor for the Sphere class that takes a radius as a parameter.
    {
        _radius = radius;    // Initialize the _radius field with the provided radius.
    }

    public float GetSurfaceArea() // Method to calculate and return the surface area of the sphere.
    {
        return 4 * _pi * _radius * _radius; // Calculate the surface area using the formula: 4 * Pi * radius^2.
    }

    public float GetVolume() // Method to calculate and return the volume of the sphere.
    {
        return (4 / 3f) * _pi * _radius * _radius * _radius; // Calculate the volume using the formula: (4/3) * Pi * radius^3.
    }
}

class Triangle
{/// <summary>
 /// This block of code defines the Triangle class. It has five private fields: _base, _height, _sideA, _sideB, and _sideC.
 /// _base stores the length of the base of the triangle, _height stores the height of the triangle, and _sideA, _sideB, and _sideC
 /// store the lengths of the three sides of the triangle. The class has a constructor that takes five int parameters and assigns
 /// them to the respective fields. It also has two methods: GetArea() and GetPerimeter().
 /// GetArea() calculates and returns the area of the triangle using the formula 0.5 * base * height.
 /// GetPerimeter() calculates and returns the perimeter of the triangle by adding the lengths of all three sides.
 /// </summary>

 private int _base;  // Define a private field _base to store the base length of the triangle.
 private int _height; // Define a private field _height to store the height of the triangle.
 private int _sideA; // Define private fields _sideA, _sideB, and _sideC to store the lengths of the triangle's sides.
 private int _sideB;
 private int _sideC;

 public Triangle(int @base, int height, int sideA, int sideB, int sideC) // Constructor for the Triangle class.
 {
        //the @base keyword is used to refer to the base class from within a derived class.
        //It is used to access members of the base class that have been overridden or hidden by members in the derived class.
        //In this example, the Rectangle class inherits from the Shape class and overrides the GetArea() method.
        //Inside the GetArea() method of the Rectangle class, we use the @base keyword to access the GetArea() method of the base class.
        //This allows us to calculate the area of the rectangle by doubling the area of the base shape.
      
     _base = @base;   // Initialize _base field with the provided base length.
     _height = height; // Initialize _height field with the provided height.
     _sideA = sideA;   // Initialize _sideA field with the length of side A.
     _sideB = sideB;   // Initialize _sideB field with the length of side B.
     _sideC = sideC;   // Initialize _sideC field with the length of side C.
 }

 public float GetArea() // Method to calculate and return the area of the triangle.
 {
     return 0.5f * _base * _height; // Calculate the area using the formula: (base * height) / 2.
 }

 public int GetPerimeter() // Method to calculate and return the perimeter of the triangle.
 {
     return _sideA + _sideB + _sideC; // Calculate the perimeter by summing the lengths of all sides.
 }
}

class Program
{
    static void Main(string[] args)
    {//Here creates instances of the Circle, Sphere, and Triangle classes,
     //passing the required parameters to their constructors. It then calls the respective methods
     //to calculate the area and/or perimeter of each shape and stores the results in variables.
     //Finally, it uses Console.WriteLine() to display the calculated values on the console.

     Circle circle1 = new Circle(5); // Create an instance of the Circle class with a radius of 5.
     Circle circle2 = new Circle(6); // Create another instance of the Circle class with a radius of 6.

     float area1 = circle1.GetArea(); // Calculate the area of the first circle.
     float area2 = circle2.GetArea(); // Calculate the area of the second circle.

     Console.WriteLine($"Area of Circle 1: {area1}"); // Print the area of the first circle.
     Console.WriteLine($"Area of Circle 2: {area2}\n"); // Print the area of the second circle.

     Sphere sphere = new Sphere(5); // Create an instance of the Sphere class with a radius of 5.
     float surfaceArea = sphere.GetSurfaceArea(); // Calculate the surface area of the sphere.
     float volume = sphere.GetVolume(); // Calculate the volume of the sphere.

     Console.WriteLine($"Surface Area of Sphere: {surfaceArea}"); // Print the surface area of the sphere.
     Console.WriteLine($"Volume of Sphere: {volume}\n"); // Print the volume of the sphere.

     Triangle triangle = new Triangle(6, 8, 10, 10, 10); // Create an instance of the Triangle class with specified parameters.
     float triangleArea = triangle.GetArea(); // Calculate the area of the triangle.
     int perimeter = triangle.GetPerimeter(); // Calculate the perimeter of the triangle.

     Console.WriteLine($"Area of Triangle: {triangleArea}"); // Print the area of the triangle.
     Console.WriteLine($"Perimeter of Triangle: {perimeter}"); // Print the perimeter of the triangle.
    }
}
