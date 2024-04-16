namespace Certyfikacja_podstawy
{
    public abstract class FootballerBase : IFootballer
    {
        public delegate void ScoreAddedDelegate(object sender, EventArgs args);

        public abstract event ScoreAddedDelegate ScoreAdded;
        public FootballerBase(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
       
        public string Name { get;}
        public string Surname { get;}
        public int Age { get;}

        public abstract void AddScore(float score);
        
        public void AddScore(int score)
        {
           float IntAsFloat = (float)score;
           this.AddScore(IntAsFloat);
        }

        public void AddScore(string score)
        {
            if (float.TryParse(score, out float result))
            {
                this.AddScore((float)result);
            }
            else
            {
                throw new Exception("String nie jest floatem");
            }
        }

        public void AddScore(char score)
        {
            float CharAsFloat = (float)score;
            this.AddScore(CharAsFloat);
        }

        public abstract Statistics GetStatistics();
    }
}
