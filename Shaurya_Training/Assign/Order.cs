using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    class Order1
    {
        int order;
        string order_date;
        Custmoer cust;
        Item item;

        public Order1(int order, string order_date, Custmoer cust, Item item)
        {
            this.Order = order;
            this.Order_date = order_date;
            this.Cust = cust;
            this.Item = item;
        }

        public int Order { get => order; set => order = value; }
        public string Order_date { get => order_date; set => order_date = value; }
        internal Custmoer Cust { get => cust; set => cust = value; }
        internal Item Item { get => item; set => item = value; }
        public void display()
        {
            Console.WriteLine($"Order={this.order}\nOrder date={this.order_date}\n{cust}\n{item}");
        }
    }
    class Custmoer
    {
        int cust_id;
        string cust_name;
        Address addr;

        public Custmoer(int cust_id, string cust_name, Address addr)
        {
            this.Cust_id = cust_id;
            this.Cust_name = cust_name;
            this.Addr = addr;
        }

        public int Cust_id { get => cust_id; set => cust_id = value; }
        public string Cust_name { get => cust_name; set => cust_name = value; }
        internal Address Addr { get => addr; set => addr = value; }
        public override string ToString()
        {
            return $"Cusmoer Id={cust_id}\ncustomer name={cust_name}\n address={addr}";
        }

    }
    class Item
    {
        int item_id;
        string item_name;
        int price;
        public Item(int item_id,string item_name,int price)
        {
            this.item_id = item_id;
            this.item_name = item_name;
            this.price = price;
        }
        public int Item_id { get => item_id; set => item_id = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public int Price { get => price; set => price = value; }

        public override string ToString()
        {
            return $"Item Id={this.item_id}\nItem name={item_name}\nPrice={price}";
        }
    }
    class Address
    {
        string addr1;
        string city;
        int pincode;

        public Address(string addr1, string city, int pincode)
        {
            this.Addr1 = addr1;
            this.City = city;
            this.Pincode = pincode;
        }

        public string Addr1 { get => addr1; set => addr1 = value; }
        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }

        public override string ToString()
        {
            return $" Address={addr1}\n city={city}\n pincode{pincode}";
        }
    }
    class Od
    {
        static void Main(string[] args)
        {
            Item i = new Item(1, "pen", 50);
            Order1 o1 = new Order1(10, "25/5/2022", new Custmoer(1, "suraj",new Address("pimpri","pune",411018)),i);
            o1.display();
        }
    }
}
