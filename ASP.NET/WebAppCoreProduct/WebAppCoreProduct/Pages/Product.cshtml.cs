using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Dynamic;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
        public class ProductModel : PageModel
        {
            public string? MessageRezult { get; private set; }
            public Models.Product Product { get; set; }

            public void OnPost(string name, decimal? price)
            {
                Product = new Models.Product();
                if (price == null || price < 0 || string.IsNullOrEmpty(name))
                    {
                        MessageRezult = "�������� ������������ ������. ��������� ����";
                        return;
                    }

            var result = price * (decimal?)0.18;
            MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� {result}";
            Product.Price = price;
            Product.Name = name;
        }
        public void OnGet()
        {
            MessageRezult = "��� ������ ����� ���������� ������";
        }
        public void OnPostDiscont(string name, decimal? price, double discont)
        {
            Product = new Models.Product();
            var result = price * (decimal?)discont / 100;

            MessageRezult = $"��� ������ {name} � ����� {price} � ������� {discont} ��������� {result}";
            Product.Price = price;
            Product.Name = name;
        }
    }
}
