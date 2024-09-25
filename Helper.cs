using Order.Context;
using Order.Models;
using Order.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public static class Helper
    {

        public static readonly User724Context user724Context = new User724Context();

        public static List<Product> Zakaz = new List<Product>();
        public static int vhod = 0;
        public static Product CurrentProduct = new Product();
        public static User currUser = new User();
        public static Zakaz zakaz = new Zakaz();
        public static ZakazProduct zakazProduct = new ZakazProduct();

        public static List<int> idsZakaz = new List<int>();
    }
}
