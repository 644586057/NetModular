﻿using Microsoft.AspNetCore.Http;

namespace NetModular.Lib.Utils.Mvc.Extensions
{
    public static class HttpRequestExtensions
    {
        /// <summary>
        /// 获取根地址
        /// </summary>
        /// <param name="request"></param>
        /// <param name="path">附加路径</param>
        /// <returns></returns>
        public static string GetHost(this HttpRequest request, string path = null)
        {
            return request.Scheme + "://" + request.Host.Value + (request.PathBase.Value ?? string.Empty) + (path ?? string.Empty);
        }
    }
}
