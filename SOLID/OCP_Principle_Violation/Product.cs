using System;

namespace OCP_Principle_Violation
{
    public class Product
    {
        public int ProductId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        private decimal _cost = 0;
        public decimal Cost
        {
            get => _cost;

            private set
            {
                if (value > 0)
                    _cost = value;
            }
        }

        public double ProfitMargin()
        {
            try
            {
                var netProfit = Sale - Cost;
                var profitMargin = (netProfit / Sale) * 100;
                return Convert.ToDouble(profitMargin);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Error");
            }
        }

        private decimal _sale = 1;
        public decimal Sale
        {
            get => _sale;

            private set
            {
                if (value > 0)
                    _sale = value;
            }
        }
        public int Inventory { get; private set; }
        public bool Active { get; private set; }

        public Product(int id, string name, string description,
            decimal cost, decimal sale, int inventory, bool active)
        {
            ProductId = id;
            Name = name;
            Description = description;
            Cost = cost;
            Sale = sale;
            Inventory = inventory;
            Active = active;
        }     
    }
}
