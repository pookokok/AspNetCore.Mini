﻿using System;
using System.Collections.Specialized;
using System.IO;

namespace AspNetCore.Mini.Core
{
    /// <summary>
    /// HttpContext与Server之间的抽象层之HttpRequestFeature
    /// </summary>
    public interface IHttpRequestFeature
    {
        Uri Url { get; }

        NameValueCollection Headers { get; }

        Stream Body { get; }
    }

    /// <summary>
    /// HttpContext与Server之间的抽象层之IHttpResponseFeature
    /// </summary>
    public interface IHttpResponseFeature
    {
        int StatusCode { get; set; }

        NameValueCollection Headers { get; }

        Stream Body { get; }
    }
}
