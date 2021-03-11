using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Product ile ilgili operasyonları yapacağımız yer.
    public interface IProductDal:IEntityRepository<Product>
    {
        //ürünün detaylarını getir
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code Refactoring >> kodun iyileştirilmesi