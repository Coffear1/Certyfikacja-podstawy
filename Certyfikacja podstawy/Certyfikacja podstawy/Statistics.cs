
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
                switch(this.Sum) 
                {
                    case var Sum when Sum >= 10:
                        return 'A';
                    case var Sum when Sum >= 8:
                        return 'B';
                    case var Sum when Sum >= 6:
                        return 'C';
                    case var Sum when Sum >= 4:
                        return 'D';
                    case var Sum when Sum >= 2:
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
