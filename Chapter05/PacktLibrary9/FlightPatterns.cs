using System;

namespace PacktLibrary9
{
    public class BusinessClassPassenger
    {
        public override string ToString()
        {
            return $"Business Class";
        }
    }

    public class FirstClassPassenger
    {
        public int AirMiles { get; set; }

        public override string ToString()
        {
            return $"First class with {AirMiles:N0} air miles";
        }
    }

    public class CoachClassPassenger
    {
        public double CarryOnKG { get; set; }

        public override string ToString()
        {
            return $"Coach Class with {CarryOnKG:N2} kg carry on";
        }
    }
}
