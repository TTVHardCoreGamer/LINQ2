namespace LINQ2
{
    public class ClientData
    {

        public static readonly List<Client> Clients = new List<Client>
        {
            new Client
            {
                Id = 1,
                Name = "Mia",
                City = "Tallinn"
            },
             new Client
            {
                Id = 2,
                Name = "Joosep",
                City = "Tartu"
            },
              new Client
            {
                Id = 3,
                Name = "Janar",
                City = "Pärnu"
            },
               new Client
            {
                Id = 4,
                Name = "Mari",
                City = "Kuresaare"
            },
                new Client
            {
                Id = 5,
                Name = "Oliver",
                City = "Tallinn"
            }
        };
    }
}
