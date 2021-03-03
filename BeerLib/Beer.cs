using System;

namespace BeerLibrary
{
    public class Beer
    {
        private int _id;
        private string _name;
        private int _price;
        private double _abv;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException();
                }
                _name = value;
            }
        }
        public int Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _price = value;
            }
        }
        public double Abv
        {
            get { return _abv; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _abv = value;
            }
        }

        public Beer(string name, int price, double abv)
        {
            if (name.Length < 4)
            {
                throw new ArgumentException();
            }
            _name = name;
            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            _price = price;
            if (abv < 0 || abv > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            _abv = abv;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
