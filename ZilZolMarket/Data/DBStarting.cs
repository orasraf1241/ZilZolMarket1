using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZilZolMarket.Models;

namespace ZilZolMarket.Data
{
    public static class DBStarting
    {
        public static void StartingDataBase(ZilZolMarketContext context)
        {
            var branches = new Branch[]
               {
                    new Branch{Name="Netivot",Lat=31.24,Long=34.344,City="Netivot",Address="Netivot Zit 41",Telephone="0533330857",IsSaturday=true},
                    new Branch{Name="Tel Aviv Branch",Lat=32.08,Long=34.77,City="Tel Aviv",Address="Yehuda Halevii 93",Telephone="0533330857",IsSaturday=false},
               };
            var users = new User[]
            {
                new User{  UserName ="Admin" ,firstName="or" , LastName ="asraf ", Email="or@gmail.com", Password ="Admin", Phone ="0533330857", UserType =UserType.Customer },
                new User{ UserName = "Customer", firstName="admin" , LastName ="asraf ", Email="o1r@gmail.com", Password ="Customer", Phone ="0533330857" , UserType =UserType.Admin }
              };

            var product = new Product[]
            {
                new Pc{ ProductType = "Pc" , Company = "Asus" ,Name = "KMG5", img = "/img/Products/AsusKMG5.jpg" ,Size =13 ,Cpu = "i7" , Ram =16 ,Laptop =true , GraphicsCard = "nvidia rtx 207",Price =600  },
                new Pc{ ProductType = "Pc" , Company = "Lenovo" ,Name = "V14", img = "/img/Products/LenovoV14.jpg" ,Size =15.6 ,Cpu = "i5" , Ram =8 ,Laptop =true , GraphicsCard = "1080ti", Price=1200 },
                new Phone{ ProductType = "Phone" , Company = "Apple" ,Name = "Iphone 12", img = "/img/Products/LenovoV14.jpg" , Size =10 , Quantity = 20, Price=1000 },
                new Phone{ ProductType = "Phone" , Company = "Apple" ,Name = "Iphone 12 Pro", img = "/img/Products/iPhone-12-mini.jpg" , Size =10 , Quantity = 20, Price=1100 },
                new Phone{ ProductType = "Phone", Company = "Apple" ,Name = "Iphone 10 Pro", img = "/img/Products/AppleIphone12pro.jpg" , Size =10 , Quantity = 20, Price=110 },
                new Screen{ ProductType = "Screens" , Company = "LG" ,Name = "Screen", img = "/img/Products/AppleTV4K64GB.jpg" , Size =12 , Quantity = 22, Price=110 , Resolution ="2480/1024"},
                new Screen{ ProductType = "Screens" , Company = "Apple" ,Name = "Apple Tv", img = "/img/Products/AppleTV4K64GB.jpg" , Size =12 , Quantity = 22, Price=110 , Resolution = "1280/1024"}
            };

            if (!context.Branch.Any())
            {
                foreach (Branch c in branches)
                {
                    context.Branch.Add(c);
                }
                context.SaveChanges();
            }

            if (!context.Product.Any())
            {
                foreach (Product p in product)
                {
                    context.Product.Add(p);
                }
                context.SaveChanges();
            }

            if (!context.User.Any() )
            {
                foreach (User u in users)
                {
                    context.User.Add(u);
                }
                context.SaveChanges();
            }
        }
    
    }

}
