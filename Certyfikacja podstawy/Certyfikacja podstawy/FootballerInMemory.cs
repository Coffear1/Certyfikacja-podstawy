namespace Certyfikacja_podstawy
{
    public class FootballerInMemory : FootballerBase
    {
        public override event ScoreAddedDelegate ScoreAdded;

        private List<float> scores = new List<float>();

        public FootballerInMemory(string name, string surname, string nationality)
           : base(name, surname, nationality)
        {
        }

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.scores.Add(score);
            }
            else
            {
                throw new Exception("Nie można dodać tej liczby goli. Proszę używać cyfr i liczb z zakresu 0-100");
            }
            if (score >= 3 && score <= 100 && ScoreAdded != null)
            {
                ScoreAdded(this, new EventArgs());
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var score in this.scores)
            {
                statistics.AddScore(score);
            }
            return statistics;
        }
    }
}
