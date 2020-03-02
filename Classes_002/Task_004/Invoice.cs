using System;

namespace Task_004
{
    public class Invoice
    {
        private readonly int _account;
        private readonly string _customer;
        private readonly string _provider;
        
        public string Article { get; set; }
        public int Quantity { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }

        public void CostCalculation(Product product, bool haveNds)
        {
            var cost = Quantity * (float)product;
            
            if (haveNds)
            {
                cost = cost * 0.2f + cost;
            }

            Console.WriteLine(cost);
        }
        

        public override string ToString()
        {
            return $"{_account} {_customer} {_provider} {Article} {Quantity}";
        }
    }
}