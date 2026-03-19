namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Where");
            Console.WriteLine("2. OrderBy");
            Console.WriteLine("3. Select");
            Console.WriteLine("4. Skip");
            Console.WriteLine("5. TakeWhile");
            Console.WriteLine("6. FirstOrDefault");
            Console.WriteLine("7. Average, Max, Count");
            Console.WriteLine("8. Any");

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

                case 4:
                    Skip();
                    break;

                case 5:
                    TakeWhile();
                    break;

                case 6:
                    FirstOrDefault();
                    break;

                case 7:
                    Statistics();
                    break;

                    case 8:
                        Any();
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
        //jättab vahele asjad seni kaua kui on nõue täidetud
        public static void Skip()
        {
            var ordeby = ProductData.Products
                .OrderBy(x => x.Price);
            var skip = ProductData.Products.Skip(4);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Name);
            }
        }
        //põhimõtteliselt sama kui skip
        public static void TakeWhile()
        {

            var takewhile = ProductData.Products
                .TakeWhile(x => x.Price < 90);

            foreach (var item in takewhile)
            {
                Console.WriteLine(item.Price);
            }
        }
        public static void FirstOrDefault()
        {
        }
        //Saab näha keskmist, kõige kallimat ja loendab
        static void Statistics()
        {
            var average = ProductData.Products.Average(x => x.Price);

            Console.WriteLine("Keskmine hind on " + average);

            var max = ProductData.Products.Max(x => x.Price);

            Console.WriteLine("Kõige kallim hind on " + max);

            //var count = ProductData.Products.Count(Category = "Söök");

            //Console.WriteLine("Söögi kategooriasse kuulub " + count);
        }

        public static void Any()
        {

            var any = ProductData.Products.Any(x => x.Price > 500);

            Console.WriteLine("Üle 500 euro maksab " + any);
        }
    }
}









