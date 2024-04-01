using System.Runtime.CompilerServices;

namespace AsyncOutputTest
{
    [TestClass]
    public class ProgramStructureTests
    {
        [TestMethod]
        public void TestProgramStructure()
        {
            // Get the program type
            var programType = typeof(AsyncOutput);

            // Get the Main method
            var mainMethod = programType.GetMethod("Main");

            // Get the ReadFile method
            var readFileMethod = programType.GetMethod("ReadFile");

            // Assert that Main method is async and returns Task
            Assert.IsTrue(mainMethod.ReturnType == typeof(Task));
            Assert.IsTrue(mainMethod.GetCustomAttributes(typeof(AsyncStateMachineAttribute), false).Length > 0);

            // Assert that ReadFile method is async and returns Task<string>
            Assert.IsTrue(readFileMethod.ReturnType == typeof(Task<string>));
            Assert.IsTrue(readFileMethod.GetCustomAttributes(typeof(AsyncStateMachineAttribute), false).Length > 0);
        }
    }
}