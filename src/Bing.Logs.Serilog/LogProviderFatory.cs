﻿using Bing.Logs.Abstractions;

namespace Bing.Logs.Serilog
{
    /// <summary>
    /// Serilog日志提供程序工厂
    /// </summary>
    public class LogProviderFatory:ILogProviderFactory
    {
        /// <summary>
        /// 创建日志提供程序
        /// </summary>
        /// <param name="logName">日志名称</param>
        /// <param name="format">日志格式化器</param>
        /// <returns></returns>
        public ILogProvider Create(string logName, ILogFormat format = null)
        {
            return new SerilogProvider(logName,format);
        }
    }
}
