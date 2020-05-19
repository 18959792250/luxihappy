using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11DesignPattern_Observer
{
    /// <summary>
    /// 具体的订阅者类
    /// </summary>
    public class Observer :IObserver
    {
        /// <summary>
        /// 订阅者名字
        /// </summary>
        private string m_Name;
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        /// <summary>
        /// 订阅者构造函数
        /// </summary>
        /// <param name="name">订阅者名字</param>
        public Observer(string name)
        {
            this.m_Name = name;
        }

        /// <summary>
        /// 订阅者接受函数
        /// </summary>
        /// <param name="blog"></param>
        public void Receive(Blog blog)
        {
            Console.WriteLine("订阅者:\"{0}\"观察到了:{1}发布的一篇博客,标题为:{2},内容为:{3}",Name,blog.BlogName,blog.BlogTitle,blog.BlogInfo);
        }
    }
}
