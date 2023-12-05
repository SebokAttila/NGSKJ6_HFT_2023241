using Microsoft.AspNetCore.Razor.TagHelpers;
using NGSKJ6_HFT_2023241_Client;
using System;

namespace NGSKJ6_HFT_2023241
{
    class Program
    {
        static RestService RestService;
        static void Main(string[] args)
        {
            RestService = new RestService("http://localhost:21149/", "Winery");
            CrudService crud = new CrudService(RestService);
            NonCrud
        }
    }
}
