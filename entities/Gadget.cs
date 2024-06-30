using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandCShap.entities
{
    internal class Gadget
    {
        private string gid;
        private string model;
        private string brand;
        private float price;
        private int amount;

        public Gadget(string gid, string model, string brand, float price, int amount)
        {
            this.gid = gid;
            this.model = model;
            this.brand = brand;
            this.price = price;
            this.amount = amount;
        }

        public string Gid
        {
            get => gid;
            set => gid = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Model
        {
            get => model;
            set => model = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Brand
        {
            get => brand;
            set => brand = value ?? throw new ArgumentNullException(nameof(value));
        }

        public float Price
        {
            get => price;
            set => price = value;
        }

        public int Amount
        {
            get => amount;
            set => amount = value;
        }

        public override string ToString()
        {
            return $"GagGet = [{Gid} , {Brand} , {Model} , {Price} , {Amount}]";
        }
    }
}
