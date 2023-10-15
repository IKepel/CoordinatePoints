using CoordinatePoints;

var point1 = new Point(1, 2);
var point2 = new Point (1, 5);

int distance1 = Point.GetDestancebetweenPoints(point1, point2);
int distance2 = point1.GetDistanceToPoint(point2);

Console.WriteLine($"Static method distance = {distance1}");
Console.WriteLine($"Simple metod distance = {distance2}");
Console.WriteLine($"Number of points = {Point.Counter}");