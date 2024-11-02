namespace UML_PATTERNS_KT.Builder;

public class BaseTrainDirector
{
    private TrainBuilder _trainBuilder = new PassengerTrainBuilder();

    public Train GetResult() => _trainBuilder.Train;

    public BaseTrainDirector()
    {
        _trainBuilder.SetHeadWagon(1);
        _trainBuilder.AddAdditionalWagon(5);
        _trainBuilder.AddAdditionalWagon(5);
        _trainBuilder.AddAdditionalWagon(5);
        _trainBuilder.SetCafeWagon(2);
        _trainBuilder.AddAdditionalWagon(5);
        _trainBuilder.AddAdditionalWagon(5);
        _trainBuilder.AddAdditionalWagon(5);
    }
}