
public class Fraction
{
    public int _up;
    public int _down;

    public Fraction()
    {
        _up = 1;
        _down = 1;
    }

    public Fraction(int wholeNum)
    {
        _up = wholeNum;
        _down = 1;
    }

    public Fraction(int up, int down)
    {
        _up = up;
        _down = down;
    }

    public string fractionText()
    {
        string text = $"{_up}/{_down}";
        return text;
    }

    public double numDecimal()
    {
        return (double) _up / (double) _down;
        
    }







}