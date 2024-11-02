namespace UML_PATTERNS_KT.Builder;

public class PassengerTrainBuilder : TrainBuilder
{
    public override void SetHeadWagon(int size)
    {
        Train.SetHeadWagon(new HeadWagon(size));
    }

    public override void SetCafeWagon(int size)
    {
        Train.SetCafeWagon(new CafeWagon(size));
    }

    public override void AddAdditionalWagon(int size)
    {
        Train.AddPassengerWagon(new PassengerWagon(size));
    }
}