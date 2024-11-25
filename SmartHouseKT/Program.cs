namespace SmartHouseKT;

class Program
{
    static void Main()
    {
        var smartHouse = new SmartHouse();
        
        smartHouse.SetUpHome(SmartHouse.CommandType.PARTY);
        smartHouse.SetUpHome(SmartHouse.CommandType.GOOD_MORNING);
        smartHouse.SetUpHome(SmartHouse.CommandType.COLLEGE);
        smartHouse.SetUpHome(SmartHouse.CommandType.AWAY);
        smartHouse.SetUpHome(SmartHouse.CommandType.HOME_ALONE);
    }
}
