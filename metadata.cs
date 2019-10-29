using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace CAT.Models
{
    public class metadata
    {
        public partial class Metadata_emoji
        {
            [DisplayName("表情名稱")]
            [StringLength(10, ErrorMessage = "產品類別最多10個字")]
            public string emoji_title { get; set; }
            [DisplayName("表情圖案")]
            public string emoji_pic { get; set; }

        }
        public  class Metadata_restaurant
        {
            [DisplayName("餐廳編號")]
            [Key]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(7, ErrorMessage = "餐廳編號最多7碼")]
            [RegularExpression("[A-Z][0-9]{6}", ErrorMessage = "格式有誤")]
            public string restaurant_id { get; set; }
            [DisplayName("名稱")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(30, ErrorMessage = "名稱最多30個字")]
            public string restaurant_title { get; set; }
            [DisplayName("電話")]
            [StringLength(20, ErrorMessage = "電話最多20碼")]
            public string restaurant_tel { get; set; }
            [DisplayName("簡介")]
            [Column(TypeName = "ntext")]
            [Required]
            public string restaurant_intro { get; set; }
            [DisplayName("經度")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(25, ErrorMessage = "經度最多25碼")]
            public string latitude { get; set; }
            [DisplayName("緯度")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(25, ErrorMessage = "緯度最多25碼")]
            public string longitude { get; set; }
            [DisplayName("城市")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(10, ErrorMessage = "字數最多10個字")]

            public string city { get; set; }
            [DisplayName("行政區")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(5, ErrorMessage = "最多5碼")]
            public string district { get; set; }
            [DisplayName("街道地址")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(60, ErrorMessage = "街道地址最多60個字")]
            public string address_detail { get; set; }
            [DisplayName("營業時間")]
            [StringLength(80, ErrorMessage = "營業時間最多80個字")]
            public string open_time { get; set; }
            [DisplayName("頁面狀態")]
            [Required(ErrorMessage = "不可空白")]
            public bool page_status { get; set; }
        }
        public class Metadata_spot
        {
            [DisplayName("景點編號")]
            [Required(ErrorMessage = "不可空白")]
            [Key]
            [StringLength(7, ErrorMessage = "餐廳編號最多7碼")]
            [RegularExpression("[A-Z][0-9]{6}", ErrorMessage = "格式有誤")]
            public string spot_id { get; set; }
            [DisplayName("名稱")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(30, ErrorMessage = "名稱最多30個字")]
            public string spot_title { get; set; }
            [DisplayName("電話")]
            [StringLength(20, ErrorMessage = "電話最多20碼")]
            public string spot_tel { get; set; }
            [DisplayName("簡介")]
            [Column(TypeName = "ntext")]
            [Required]

            public string spot_intro { get; set; }
            [DisplayName("經度")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(25, ErrorMessage = "經度最多25碼")]
            public string longitude { get; set; }
            [DisplayName("緯度")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(25, ErrorMessage = "緯度最多25碼")]
            public string latitude { get; set; }
            [DisplayName("備註")]
            
            public string addition_note { get; set; }
            [DisplayName("城市")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(10, ErrorMessage = "字數最多10個字")]
            public string city { get; set; }
            [DisplayName("行政區")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(5, ErrorMessage = "最多5碼")]
            public string district { get; set; }
            [DisplayName("街道地址")]
            [Required(ErrorMessage = "不可空白")]
            [StringLength(60, ErrorMessage = "街道地址最多60個字")]
            public string address_detail { get; set; }
            
            [DisplayName("營業時間")]
            [StringLength(80, ErrorMessage = "營業時間最多80個字")]

            public string open_time { get; set; }
            [DisplayName("門票資訊")]
            
            [StringLength(80, ErrorMessage = "門票資訊最多30個字")]
            public string ticket_info { get; set; }
            [DisplayName("更新時間")]
            
            public Nullable<System.DateTime> update_date { get; set; }
            [DisplayName("頁面狀態")]
            [Required(ErrorMessage = "不可空白")]
            public bool page_status { get; set; }
            
           
        }
    }
}