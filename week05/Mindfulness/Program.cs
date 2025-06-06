using System;
namespace Mindfulness;
class Program
{
     static void Main(string[] args)
    {
        ListingActivity listing = new ListingActivity();
        listing.Run();

        ReflectingActivity reflecting = new ReflectingActivity();
        reflecting.Run();
    }
}