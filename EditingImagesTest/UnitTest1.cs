using Editing_Images;
using Editing_Images.entity;

namespace EditingImagesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateTotalTime_Test()
        {
            int imagesAmount = 1000;

            Person[] crew = new Person[]
            {
            new Person(1.0 / 2.0),
            new Person(1.0 / 3.0),
            new Person(1.0 / 4.0)
            };

            double expectedTime = 923.076923076923;

            double actualTime = CalculateTotalTime(imagesAmount, crew);

            Assert.AreEqual(expectedTime, actualTime, 0.0001);
        }

        private double CalculateTotalTime(int imagesAmount, Person[] crew)
        {
            double totalRate = 0;

            foreach (Person person in crew)
            {
                totalRate += person.Rate;
            }

            double totalTime = imagesAmount / totalRate;

            return totalTime;
        }
    }
}
