namespace TU_Challenge
{
    public class Test1_MathBase
    {

        /// <summary>
        /// Test pas obligatoire mais essayez un peu quand même. N'hésitez pas à me demander de l'aide
        /// </summary>
        [Test]
        public void GenericSort()
        {
            var toSort = new List<int>() { 12, 0, -1, 123, 45, 90, -123 };

            var result = MyMathImplementation.GenericSort(toSort, MyMathImplementation.IsInOrder);

            for (int i = 0; i < result.Count - 1; i++)
            {
                Assert.IsTrue(result[i] < result[i + 1]);
            }
        }
    }
}