using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11DesignPattern_Observer
{

    /// <summary>
    /// 具体的订阅博客类
    /// </summary>
    public class JiYFBlog :Blog
    {
        public JiYFBlog(string name,string blogTitile, string blogInfo)
            : base(name,blogTitile,blogInfo)
        {
            
        }
    }
}
