using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Core
{
    public interface ICart
    {
        /// <summary>
        /// 添加订单到购物车
        /// </summary>
        /// <param name="productInfo"></param>
        void AddProductList(object productInfo);
        void RemoveProductList
    }
}
