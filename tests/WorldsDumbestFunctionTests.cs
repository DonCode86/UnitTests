using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.tests
{
    public static class WorldsDumbestFunctionTests
    {
        public static void WorldsDumbestFunctions_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - go get your variables, whatever you need, you classes, go get your methods
                int num = 0;
                WorldsDumbestFuncionts worldsDumbest = new WorldsDumbestFuncionts();

                //Act - Execute function
                string result = worldsDumbest.ReturnsPikachuIfZero(num);

                //Assert - Whatever ever is returned is it what you want..
                if (result == "PIKACHUUUUU")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction.ReturnsPikachuIfZero.ReturnString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction.ReturnsPikachuIfZero.ReturnString");
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex);
            }
        }
    }
}
