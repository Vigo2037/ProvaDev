namespace ProvaDev
{
    public class VerificaBhaskara
    {



        public double VerificaBhaskara(Teste t)
        {
            if (delta > 0)
            {
                Console.WriteLine("Retorna maior valor das raízes. x1:" + x1 + "X2:" + x2);
            }
            else if (delta == 0)
            {
                Console.WriteLine("Raizes iguais, retorne o valor zero. x1:" + x1 + "X2:" + x2);
            }
            else
            {
                Console.WriteLine("Retorna menor que zero!");
            }
        }
    }
}