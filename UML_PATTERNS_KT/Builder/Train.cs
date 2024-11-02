namespace UML_PATTERNS_KT.Builder;

public class Train
{
    public HeadWagon? HeadWagon { get; private set; }
    public CafeWagon? CafeWagon { get; private set; }
    public List<PassengerWagon>? PassengerWagons { get; private set; } = [];

    public void SetHeadWagon(HeadWagon headWagon) => HeadWagon = headWagon;
    public void SetCafeWagon(CafeWagon cafeWagon) => CafeWagon = cafeWagon;
    public void AddPassengerWagon(PassengerWagon passengerWagon) => PassengerWagons?.Add(passengerWagon);
}