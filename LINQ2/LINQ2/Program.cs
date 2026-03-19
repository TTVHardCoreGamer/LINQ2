namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Where");
            Console.WriteLine("2. OrderBy");
            Console.WriteLine("3. Select");

            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Where();
                    break;

                case 2:
                    OrderBy();
                    break;

                case 3:
                    Select();
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
            var where = ProductData.Products.Where(x => x.Price > 60);

            foreach (var item in where)
            {
                Console.WriteLine(item.Price);
            }
        }
        //orderby järjestab tähestikulises järjekorras ära praegu linnad
        //ja siis nimed selle järgi et kus elavad ja kui elavad samas
        //linnas siis see kelle nimi hakkab ennem tähega tähestikus on ees
        public static void OrderBy()
        {
            var orderby = ClientData.Clients
                .OrderBy(x => x.City)
                .ThenBy(x => x.Name);

            foreach (var item in orderby)
            {
                Console.WriteLine(item.City + " " + item.Name);
            }
        }
        //Select valib välja käsi järgi koodist asjad
        public static void Select()
        {
            var select = ProductData.Products
                        .Select(x => new
                        {
                            Category = x.Category,
                        });
            foreach (var item in select)
            {
                Console.WriteLine(item.Category);
            }
        }
    }
}



