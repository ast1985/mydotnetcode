using System;
class HelloWorld
{
static void Main()
{
#if DebugConfig
    Console.WriteLine("Hello, World!");
#endif
Console.WriteLine("Hello");
}
}