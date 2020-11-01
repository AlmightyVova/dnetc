using System;

namespace hw2es
{
    public class Invoice
    {
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;

        private string _article = new Guid().ToString();
        private int _quantity = 17;
        
        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public double CalculatePriceWithVAT(double price)
        {
            price *= _quantity;
            price += price * 0.20;
            return price;
        }
        public double CalculatePriceWithoutVAT(double price)
        {
            price *= _quantity;
            return price;
        }
    }
}