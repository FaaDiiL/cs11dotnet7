var a = 4.5;
var b = 2.5;
var answear = Add(a, b);

WriteLine($"{a} + {b} = {answear}");
WriteLine("Press ENTER to end the app.");
ReadLine(); // wait for press ENTER


double Add(double a, double b)
{
    return a + b; // deliberate bug!
}