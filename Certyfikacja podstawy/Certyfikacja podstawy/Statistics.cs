
namespace Certyfikacja_podstawy
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average 
        {
            get
            { 
                return this.Sum/ this.Count;
            }
        }

        public char MatchRating
        {
            get 
            {
                switch(this.Average) 
                {
                    case var Average when Average >= 10:
                        return 'A';
                    case var Average when Average >= 8:
                        return 'B';
                    case var Average when Average >= 6:
                        return 'C';
                    case var Average when Average >= 4:
                        return 'D';
                    case var Average when Average >= 2:
                        return 'E';
                    default:
                        return 'F';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddScore(float score)
        {
            this.Count++;
            this.Sum += score;
            this.Min = Math.Min(this.Min, score);
            this.Max = Math.Max(this.Max, score);
        }
    }
}
