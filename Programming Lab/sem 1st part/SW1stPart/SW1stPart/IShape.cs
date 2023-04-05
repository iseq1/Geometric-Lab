namespace SW1stPart
{
    public interface IShape 
    {
        double square();

        double length();

        bool cross(IShape i);
    }
}