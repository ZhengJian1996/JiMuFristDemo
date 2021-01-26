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
            //ASP.NET Core ʹ��app.UseStaticFiles���þ�̬�ļ��м�����ﵽ����IIS������Ŀ¼��Ч�����ɷ���λ�� Web ��Ŀ¼֮����ļ�
            app.UseStaticFiles());


        }

    
    }
}
