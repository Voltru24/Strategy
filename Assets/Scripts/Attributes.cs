using System;

[Serializable]
public class Attributes 
{
    private int _force;
    private int _agility;
    private int _defence;
    private int _intellect;

    public int GetAttribut(Attribut attribut)
    {
        switch (attribut)
        {
            case Attribut.Force:
                return _force;
            case Attribut.Agility:
                return _agility;
            case Attribut.Defence:
                return _defence;
            case Attribut.Intellect:
                return _intellect;
            default:
                return -1;
        }
    }
}

public enum Attribut
{
    Force,
    Agility,
    Defence,
    Intellect
}
