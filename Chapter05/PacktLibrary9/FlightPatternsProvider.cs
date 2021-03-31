namespace PacktLibrary9
{
    public class FlightPatternsProvider
    {
        public static object[] GetFlightPassengers()
        {
            return new object[]{
                new FirstClassPassenger{AirMiles=1_419},
                new FirstClassPassenger{AirMiles=16_562},
                new BusinessClassPassenger(),
                new CoachClassPassenger{CarryOnKG=25.7},
                new CoachClassPassenger{CarryOnKG=0}
            };
        }
    }
}