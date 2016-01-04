using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Web.Model
{

    /// <summary>
    /// 购物车中商品明细信息
    /// </summary>
    [Serializable]
    public class Cart_Details : IModel
    {

        /// <summary>
        /// 商品ID
        /// </summary>
        public int PID { get; set; }

        /// <summary>
        /// 商品SkuID
        /// </summary>
        public int SkuID { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        public string UserCode { get; set; }


        /// <summary>
        /// 店铺ID[自营为0]
        /// </summary>
        public int StorecID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// SessionID
        /// </summary>
        public string SID { get; set; }
        /// <summary>
        /// 购物车相关商品的价格
        /// </summary>
        public Cart_ProductPrice Price { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
    }

    [Serializable]
    public class Cart_ProductPrice : IModel
    {
        /// <summary>
        /// 原价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 最终支付价格
        /// </summary>
        public decimal PayPrice { get; set; }
        /// <summary>
        /// 价格描述
        /// </summary>
        public string Remark { get; set; }

    }
}
