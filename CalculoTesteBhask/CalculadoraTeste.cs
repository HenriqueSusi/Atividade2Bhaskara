namespace CalculoTesteBhask
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Test1()
        {
            double a = 4;
            double b = 2;
            double c = -6;

            var raizes = At2_Bhaskara.Calculadora.CalcularRaiz(a, b, c);

            Assert.Equal(raizes, At2_Bhaskara.Calculadora.CalcularRaiz(a, b, c));
        }
    }
}