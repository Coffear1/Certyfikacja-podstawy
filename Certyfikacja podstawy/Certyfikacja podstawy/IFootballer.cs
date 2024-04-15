namespace Certyfikacja_podstawy
{
    public interface IFootballer 
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        void AddScore(float score);
        void AddScore(int score);
        void AddScore(string score);
        void AddScore(char score);
        Statistics GetStatistics();
    }
}
