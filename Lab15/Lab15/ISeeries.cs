interface ISeries
{
    void setStart(int startValue);
    int getNext();
    void reset();
}
class ArithProgression : ISeries
{
    public int StartValue;
    public int CurrentValue;
    public int StepValue;
    public ArithProgression(int startValue, int stepValue)
    {
        StartValue = startValue;
        CurrentValue = startValue;
        StepValue = stepValue;
    }
    public int getNext()
    {
        return CurrentValue += StepValue;
    }
    public void reset()
    {
        CurrentValue = StartValue;
    }
    public void setStart(int startValue)
    {
        StartValue = startValue;
    }
}
class GeomProgression : ISeries
{
    public int StartValue;
    public int CurrentValue;
    public int DenomValue;
    public GeomProgression(int startValue, int denomValue)
    {
        StartValue = startValue;
        CurrentValue = startValue;
        DenomValue = denomValue;
    }
    public int getNext()
    {
        return CurrentValue *= DenomValue;
    }
    public void reset()
    {
        CurrentValue = StartValue;
    }
    public void setStart(int startValue)
    {
        StartValue = startValue;
    }
}