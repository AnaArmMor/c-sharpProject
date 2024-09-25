namespace MiCalculadora_Test
{
    [TestClass]
    public class Calculadora_Test
    {
        [TestMethod]
        public void Restar_Enteros_Test()
        {
            // Arrange: inicializar las variables
            int sumando1 = 5;
            int sumando2 = 3;
            int resultadoCorrecto = 2;

            // Act: Ejecutamos el método a testear
            int resultado = MiCalculadora.Clases.Calculadora.Restar(sumando1, sumando2);

            // Assert: Comprobamos resultado
            Assert.AreEqual(resultadoCorrecto, resultado);
        }

        [TestMethod]
        public void Restar_Doubles_Test()
        {
            // Arrange: inicializar las variables
            double sumando1 = 3.0;
            double sumando2 = 1.2;
            double resultadoCorrecto = 1.8;

            // Act: Ejecutamos el método a testear
            double resultado = MiCalculadora.Clases.Calculadora.Restar(sumando1, sumando2);

            // Assert: Comprobamos resultado
            Assert.AreEqual(resultadoCorrecto, resultado);
        }
    }
}

