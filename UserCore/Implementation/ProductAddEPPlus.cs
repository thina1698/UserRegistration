using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure;
using UserInfrastructure.Table;
using Microsoft.AspNetCore.Http;
using UserCore.Interface;

namespace UserCore.Implementation
{
    public class ProductAddEPPlus : IProductAddEPPlus
    {
        private readonly UserDBcontext _userDBcontext;

        public ProductAddEPPlus(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }

        public async Task<(bool isSuccess, string message)> AddProductsFromExcel(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return (false, "No file uploaded.");

            try
            {
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    using (var package = new ExcelPackage(stream))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int rowCount = worksheet.Dimension.Rows;

                        List<Products> productList = new List<Products>();

                        for (int row = 2; row <= rowCount; row++)
                        {
                            var product = new Products
                            {
                                ProductName = worksheet.Cells[row, 1].Text,
                                ProductPrice = decimal.Parse(worksheet.Cells[row, 2].Text)
                            };
                            productList.Add(product);
                        }

                        _userDBcontext.Products.AddRange(productList);
                        await _userDBcontext.SaveChangesAsync();

                        return (true, "Products uploaded successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Internal server error: {ex.Message}");
            }
        }
    }
}
