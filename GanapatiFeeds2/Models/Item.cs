﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GanapatiFeeds2.Models
{
    [Bind(Exclude = "ItemId")]
    public class Item
    {
        [ScaffoldColumn(false)]
        public int ItemId { get; set; }

        [DisplayName("Category")]
        public int CategoryId { get; set; }

        [DisplayName("Producer")]
        public int ProducerId { get; set; }

        [Required(ErrorMessage ="An Item title is required")]
        [StringLength(160)]
        public string Title { get; set; }

        [Required(ErrorMessage ="Price is required")]
        public decimal Price { get; set; }

        [DisplayName("Item Art Url")]
        public string ItemArtUrl { get; set; }
        public virtual Category Category { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}