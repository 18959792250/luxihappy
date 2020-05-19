using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11DesignPattern_Observer
{
    /// <summary>
    /// 订阅博客抽象类
    /// </summary>
    public abstract class Blog
    {
        /// <summary>
        /// 保存订阅者列表
        /// </summary>
        private List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// 博主名
        /// </summary>
        public string BlogName { get; set; }

        /// <summary>
        /// 博客标题
        /// </summary>
        public string BlogTitle { get; set; } 

        /// <summary>
        /// 博客信息
        /// </summary>
        public string BlogInfo { get; set; }

        /// <summary>
        /// 博客构造函数
        /// </summary>
        /// <param name="blogTitle">博客标题</param>
        /// <param name="blogInfo">博客信息</param>
        public Blog(string name,string blogTitle,string blogInfo)
        {
            this.BlogName = name;
            this.BlogTitle = blogTitle;
            this.BlogInfo = blogInfo;
        }

        /// <summary>
        /// 添加一个订阅者
        /// </summary>
        /// <param name="observer">具体的订阅者对象</param>
        public void AddObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                return;
            }
            observers.Add(observer);
        }

        /// <summary>
        /// 删除一个订阅者
        /// </summary>
        /// <param name="observer">具体的订阅者对象</param>
        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        /// <summary>
        /// 发布博客通知
        /// </summary>
        public void PublishBlog()
        {
            //遍历通知每一个订阅者
            foreach (IObserver ob in observers)
            {
                if (ob != null)
                {
                    ob.Receive(this);
                }
            }
        }

    }
}
