namespace At2_Bhaskara
{
    public class Calculadora
    {
        public static double [] CalcularRaiz(double a, double b, double c)
        {

            double DeltaRes = (b * b) - 4 * (a * c);



            if (DeltaRes < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Impossivel Resolver"
                    );

            }

            double raiz1 = ((b * -1) + Math.Sqrt(DeltaRes)) / 2 * a;
            double raiz2 = ((b * -1) - Math.Sqrt(DeltaRes)) / 2 * a;

            return new double[] { raiz1, raiz2 };
        } 

    }
}