// IConnectable.cs
public interface IConnectable
{
    bool Connect();
}
public interface IRechargeable
{
    void Charge(int minutes);
}
public interface IDisplayable
    {
    string Display();
}