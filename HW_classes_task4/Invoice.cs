using System;

namespace HW_classes_task4
{
    public class Invoice
    {
        private readonly int _account;
        private readonly string _customer;
        private string _article;
        private uint _quantity;
        private double _pricePerUnit;

        public Invoice(int account, string customer, string article, uint quantity, double pricePerUnit)
        {
            _account = account;
            _customer = customer;
            _article = article;
            _quantity = quantity;
            _pricePerUnit = pricePerUnit;
        }

        public string Article
        {
            get { return _article; }
            set { _article = value; }
        }

        public uint Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public double PricePerUnit
        {
            get { return _pricePerUnit; }
            set { _pricePerUnit = value; }
        }

        public double GetAccountPriceWithoutVAT()
        {
            return _quantity * _pricePerUnit;
        }

        public double GetAccountPriceWithVAT()
        {
            double VAT = 0.17;
            return (1 + VAT) * _quantity * _pricePerUnit;
        }
    }
}
