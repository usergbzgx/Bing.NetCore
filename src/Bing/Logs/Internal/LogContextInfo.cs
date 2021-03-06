﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Bing.Logs.Internal
{
    /// <summary>
    /// 日志上下文信息
    /// </summary>
    public class LogContextInfo
    {
        #region 属性
        /// <summary>
        /// 跟踪号
        /// </summary>
        public string TraceId { get; set; }

        /// <summary>
        /// 计时器
        /// </summary>
        public Stopwatch Stopwatch { get; set; }

        /// <summary>
        /// IP
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 主机
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 浏览器
        /// </summary>
        public string Browser { get; set; }

        /// <summary>
        /// 请求地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Order { get; set; }
        #endregion       
    }
}
