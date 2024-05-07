using Certyfikacja_podstawy;

namespace Footballer.Tests
{
    public class FootballerTest
    {
        [Test]
        public void TestStatisticsForMinResult()
        {
            var footballer = new FootballerInMemory("Robert", "Lewandowski", "Polska");
            footballer.AddScore(4);
            footballer.AddScore(0);
            footballer.AddScore(2);
            footballer.AddScore(1);
            footballer.AddScore(3);

            var statistics = footballer.GetStatistics();

            Assert.AreEqual(0, statistics.Min);
        }

        [Test]
        public void TestStatisticsForMaxResult()
        {
            var footballer = new FootballerInMemory("Robert", "Lewandowski", "Polska");
            footballer.AddScore(4);
            footballer.AddScore(0);
            footballer.AddScore(2);
            footballer.AddScore(1);
            footballer.AddScore(3);

            var statistics = footballer.GetStatistics();

            Assert.AreEqual(4, statistics.Max);
        }

        [Test]
        public void TestStatisticsForAverageResult()
        {
            var footballer = new FootballerInMemory("Robert", "Lewandowski", "Polska");
            footballer.AddScore(4);
            footballer.AddScore(0);
            footballer.AddScore(2);
            footballer.AddScore(1);
            footballer.AddScore(3);

            var statistics = footballer.GetStatistics();

            Assert.AreEqual(2 , statistics.Average);
        }
        
        [Test]  
        public void TestStatisticsForSumResult()
        {
            var footballer = new FootballerInMemory("Robert", "Lewandowski", "Polska");
            footballer.AddScore(4);
            footballer.AddScore(0);
            footballer.AddScore(2);
            footballer.AddScore(1);
            footballer.AddScore(3);

            var statistics = footballer.GetStatistics();

            Assert.AreEqual(10, statistics.Sum);
        }

        [Test]
        public void TestStatisticsForMatchRatingResult()
        {
            var footballer = new FootballerInMemory("Robert", "Lewandowski", "Polska");
            footballer.AddScore(4);
            footballer.AddScore(0);
            footballer.AddScore(2);
            footballer.AddScore(1);
            footballer.AddScore(3);

            var statistics = footballer.GetStatistics();

            Assert.AreEqual('A', statistics.MatchRating);
        }
    }
}