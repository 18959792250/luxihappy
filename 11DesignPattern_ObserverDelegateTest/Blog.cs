using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11DesignPattern_ObserverDelegateTest
{
    /// <summary>
    /// 委托充当订阅者接口类
    /// </summary>
    /// <param name="sender"></param>
    public delegate void NotifyEventHandler(object sender);

    /// <summary>
    /// 订阅博客基类
    /// </summary>
    public class Blog
    {
        public NotifyEventHandler NotifyEvent;
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
        public Blog(string name, string blogTitle, string blogInfo)
        {
            this.BlogName = name;
            this.BlogTitle = blogTitle;
            this.BlogInfo = blogInfo;
        }

        /// <summary>
        /// 绑定订阅事件
        /// </summary>
        /// <param name="ob">订阅者</param>
        public void AddObserver(NotifyEventHandler observer)
        {
            NotifyEvent += observer;
        }

        /// <summary>
        /// 取消绑定订阅
        /// </summary>
        /// <param name="observer"></param>
        public void RemoteObserver(NotifyEventHandler observer)
        {
            NotifyEvent -= observer;
        }

        /// <summary>
        /// 发布博客通知
        /// </summary>
        public void PublishBlog()
        {
            if(NotifyEvent != null)
            {
                NotifyEvent(this);
            }
        }
    }
}
