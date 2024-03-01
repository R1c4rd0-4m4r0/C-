namespace atividadeCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void FazLinha()
            {
                for(int i = 1; i < 71; i++)
                {
                    Console.Write("-");
                }
            }

            Produtos produto1 = new Produtos("7891025101604", "leite", 3.0f, 15.00,"1");
            Produtos produto2 = new Produtos("7891000105016", "Barra de cereal", 3.40f, "28.00 lt");
            Produtos produto3 = new Produtos("7891000120101", "Creme de leite", 3.70f, "23.00 cx");
            Produtos produto4 = new Produtos("7891000100103", "leite condensado", 4.50f, "18.00 und");
            Produtos produto5 = new Produtos("7891999000538", "Iogurte", 1.98f, "32.00 gf");
            Produtos produto6 = new Produtos("7896051126041", "leite fermentado", 2.12f, "12.00 cx");
            Produtos produto7 = new Produtos("7897236904805", "Água", 1.50f, "48.00 cp 1");
            Produtos produto8 = new Produtos("7622300830083", "Biscito recheado", 1.80f, "35.00 pct");
            Produtos produto9 = new Produtos("7891150036567", "Caldo de galinha", 1.90f, "16.00 cx");
            Produtos produto10 = new Produtos("4005900036728", "Desodorante", 11.10f, "25.00 und");
            Produtos produto11 = new Produtos("7896185989819", "Vitamina C", 35.20f, "26.00 und");
            Produtos produto12 = new Produtos("7898113811452", "Lanche", 9.50f, "37.00 und");

            FazLinha();
            Console.WriteLine();
            Console.WriteLine("{0,-5} {1,-14} {2,-7} {3,-16} {4,-4} {5,-8} {6} {7} {8}", "|", "Código", "|", "Descrição", "|", "Preço", "|", "Quant.Estoque|");

            FazLinha();



        }
    }
}