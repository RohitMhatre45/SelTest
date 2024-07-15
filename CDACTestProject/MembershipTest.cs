using CDACMaths;

namespace CDACTestProject
{
    [TestClass]
    public class MembershipTest
    {
        [TestMethod]
        public void TestMemberExistance()
        {
            string expectedValue = "ravi";
            string actualValue = "sachin";
            Assert.AreEqual(expectedValue,actualValue);
        }


        [TestMethod]
        public void TestAddition()
        {
            //test data
            int num1 = 67;
            int num2 = 3;
            int expectedValue = 70;

            MathEngine mathEngine = new MathEngine();
            int actualValue = mathEngine.Add(num1, num2);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

//TDD: Test Driven Development