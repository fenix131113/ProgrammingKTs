namespace UML_PATTERNS_KT.Builder;

public class BuilderUse
{
    public void Run()
    {
        var director = new BaseTrainDirector();
        var train = director.GetResult();
        if (train.HeadWagon != null)
            Console.WriteLine(train.HeadWagon.Size);
        if (train.CafeWagon != null)
            Console.WriteLine(train.CafeWagon.Size);
        if (train.PassengerWagons != null)
            Console.WriteLine(train.PassengerWagons.Count);
    }
}