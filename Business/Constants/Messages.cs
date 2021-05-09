﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi..";
        public static string ProductNameInvalid = "Ürün ismi geçersiz..";
        public static string MaintenanceTime = "Sistem Bakımda...";
        public static string ProductListed = "Ürün Listelendi..";
        public static string ProductCountOfCategoryError ="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExist="Bu isimde zaten başka bir ürün var.";
        public  static string CategoryLimitExceded ="Kategori limiti aşıldı.";
    }
}
