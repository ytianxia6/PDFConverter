using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Install
{


    class ProductList
    {
        public Product[] Products { get; } =
        {
            new Product() { Key='1', Name="zwcad", CadVer = ProductVer, Desc=$"中望CAD {ProductVer}(x86)", Language="zh-CN", IsX64=false, FileName=@"Win32\PDFConverter.zrx" },
            new Product() { Key='2', Name="zwcada", CadVer = ProductVer, Desc=$"中望CAD 建筑版{ProductVer}(x86)", Language="zh-CN", IsX64=false, FileName=@"Win32\PDFConverter.zrx" },
            new Product() { Key='3', Name="zwcadm", CadVer = ProductVer, Desc=$"中望CAD 机械版{ProductVer}(x86)", Language="zh-CN", IsX64=false, FileName=@"Win32\PDFConverter.zrx" },
            new Product() { Key='4', Name="zwcad", CadVer = ProductVer, Desc=$"中望CAD {ProductVer}(x64)", Language="zh-CN", IsX64=true, FileName=@"x64\PDFConverter.zrx" },
            new Product() { Key='5', Name="zwcada", CadVer = ProductVer, Desc=$"中望CAD 建筑版{ProductVer}(x64)", Language="zh-CN", IsX64=true, FileName=@"x64\PDFConverter.zrx" },
            new Product() { Key='6', Name="zwcadm", CadVer = ProductVer, Desc=$"中望CAD 机械版{ProductVer}(x64)", Language="zh-CN", IsX64=true, FileName=@"x64\PDFConverter.zrx" },

        };

        public Product[] ValidProducts
        {
            get
            {
                return Products.Where(prod => prod.Exist).ToArray();
            }
        }

#if ZRX2017
          public static ref readonly string ProductVer => ref $@"2017";
#else
        public static string ProductVer => $@"2018";
#endif
    }
}
