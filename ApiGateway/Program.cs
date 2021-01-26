using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Jimu.Client.ApplicationWebClient.Instance.Run(null, (env, app) =>
            //ASP.NET Core 使用app.UseStaticFiles配置静态文件中间件，达到类似IIS中虚拟目录的效果，可访问位于 Web 根目录之外的文件
            app.UseStaticFiles());


        }

    
    }
}
