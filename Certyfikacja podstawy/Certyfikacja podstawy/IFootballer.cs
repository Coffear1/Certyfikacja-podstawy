namespace Certyfikacja_podstawy
{
    public interface IFootballer 
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Nationality { get; set; }
        void AddScore(float score);
        void AddScore(int score);
        void AddScore(string score);
        void AddScore(char score);
        Statistics GetStatistics();
    }
}
