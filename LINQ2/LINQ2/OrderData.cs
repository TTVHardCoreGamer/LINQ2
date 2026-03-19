namespace LINQ2
{
    public class OrderData
    {
        public static readonly List<Order> Orders = new List<Order>
        {
                new Order()
            {
                Id = 1,
                ClientId = 5,
                ProductId = 6,
                Amount = 1,

            },


                new Order()
            {
                Id = 2,
                ClientId = 7,
                ProductId = 3,
                Amount = 20,

            },

                new Order()
            {
                Id = 3,
                ClientId = 9,
                ProductId = 5,
                Amount = 1,

            },

                new Order()
            {
                Id = 4,
                ClientId = 10,
                ProductId = 2,
                Amount = 10,

            },

                new Order()
            {
                Id = 5,
                ClientId = 2,
                ProductId = 7,
                Amount = 2,

            },

                new Order()
            {
                Id = 6,
                ClientId = 1,
                ProductId = 8,
                Amount = 500,

            },

                new Order()
            {
                Id = 7,
                ClientId = 3,
                ProductId = 6,
                Amount = 1500,

            },

                new Order()
            {
                Id = 8,
                ClientId = 9,
                ProductId = 4,
                Amount = 7,

            },

                new Order()
            {
                Id = 9,
                ClientId = 5,
                ProductId = 1,
                Amount = 10,

            },

                new Order()
            {
                Id = 10,
                ClientId = 4,
                ProductId = 5,
                Amount = 2,

            },
        };
    }
}