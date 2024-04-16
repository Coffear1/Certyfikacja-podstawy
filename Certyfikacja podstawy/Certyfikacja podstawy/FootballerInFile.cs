namespace Certyfikacja_podstawy
{
    public class FootballerInFile : FootballerBase
    {
        public override event ScoreAddedDelegate ScoreAdded;

        private const string fileName = "liczba goli w sezonie.txt";

        public FootballerInFile(string name, string surname, int Age)
            : base(name, surname, Age)
        {

        }

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(score);
                }
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
            var scoreFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(scoreFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var numberOfGoals = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        numberOfGoals.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return numberOfGoals;
        }

        private Statistics CountStatistics(List<float> numberOfGoals)
        {
            var statistics = new Statistics();
            foreach (var numberOfGoal in numberOfGoals)
            {
                statistics.AddScore(numberOfGoal);
            }
            return statistics;
        }
    }
}
