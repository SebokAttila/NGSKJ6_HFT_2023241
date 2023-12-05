using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using NGSKJ6_HFT_2023241_Models;

namespace NGSKJ6_HFT_2023241_Client
{
    class NonCrudService
    {
        private RestService restService;

        public NonCrudService(RestService restService)
        {
            this.restService = restService;
        }
        public void ListByVintage()
        {
            Console.WriteLine("Vintage:");
            string vintage = Console.ReadLine();
            var items = restService.Get<Wine>($"Stats/ListByVintage?vintage={vintage}");
            foreach ( var item in items )
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public void BarrelsByMaterial()
        {
            Console.WriteLine("Material:");
            string material = Console.ReadLine();
            var barrels = restService.Get<Barrell>($"Stats/ListBarrelsByMaterial?material={material}");
            foreach (var item in barrels)
            {
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public void BiggestBatch()
        {
            Console.WriteLine("Winery:");
            string winery = Console.ReadLine();
            var biggest = restService.Get<Wine>($"Stats/BiggestBatch?name={winery}");
            Console.WriteLine(biggest);
            Console.ReadLine();
        }
        public void WinesByWinery()
        {
            Console.WriteLine("Winery");
            string winery = Console.ReadLine();
            var wines = restService.Get<Wine>($"Stats/WinesByWinery?winery={winery}");
            foreach (var item in wines)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public void BiggestBarrelInWinery()
        {
            Console.WriteLine("Winery");
            string winery = Console.ReadLine();
            var barrel = restService.Get<Barrell>($"Stats/BiggestBarrelInWinery?winery={winery}");
            Console.WriteLine(barrel);
            Console.ReadLine();
        }
    }
}
