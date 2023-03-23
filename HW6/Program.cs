// Task

//     Create a class Shape that has:
//     Name
//     Color
//     Position, array of x and y coordinates (int[])
//     getArea - method that will only write in the console that there is no special implementation for area
//     getPerimeter - method that will only write in the console that there is no special implementation for perimeter
// *add method move that is shared among all instances and can be accessed through the class name. It updates the position of the input, by increasing the coordinates for 5.
//     create a setter and getter for the color and name property. The setter/getter will log a corresponding message. The setter should do validation.
//     Add class Rectangle, that inherits from Shape. It should have properties sideA and sideB. Override the getArea and getPerimeter methods correspondingly for a rectangle.
//     Add class Circle, that inherits from Shape. It should have property radius. Override the getArea and getPerimeter methods correspondingly for a circle. Test with few objects.

using HW6;

Shape oblik = new Shape();//Testiranje na klasa SHAPE
oblik.Name = "Formicka_nekoja";
oblik.Color = "Plavo_nebesna";
oblik.getArea();
oblik.getPerimeter();

Rectangle kvadrat = new Rectangle();//Testiranje na klasa RECTANGLE
kvadrat.Name = "Kvadratce_nekoe";
kvadrat.Color = "Rozeva_urnebesna";
kvadrat.getArea();
kvadrat.getPerimeter();


Circle krug = new Circle();//Testiranje na klasa CIRCLE
krug.Name = "krugce_nekoe";
krug.Color = "Bela_podzaprljana";
krug.radius = 15;
krug.getArea();
krug.getPerimeter();