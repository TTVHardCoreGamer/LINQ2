namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Where");
            Console.WriteLine("2. OrderBy");

            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Where();
                    break;

                case 2:
                    OrderBy();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }
        //where paneb konsooli asjad mis vastavad mingile tingimusele ehk siis
        //, et näiteks kus on hind 60 siis leiab need ja paneb konsooli
        public static void Where()
        {
            var where = ProductList.Products.Where(x => x.Price > 60);

            foreach (var item in where)
            {
                Console.WriteLine(item.Price);
            }
        }
        public static void OrderBy()
        {
            var orderby = ClientsList.Clients
                .OrderBy(x => x.City)
                .ThenBy(x => x.Name);

            foreach (var item in orderby)
            {
                Console.WriteLine(item.City + " " + item.Name);
            }
        }
    }
}




