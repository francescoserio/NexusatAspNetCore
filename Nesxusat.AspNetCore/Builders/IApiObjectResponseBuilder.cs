﻿using Nesxusat.AspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nesxusat.AspNetCore.Builders
{
    public interface IApiObjectResponseBuilder<T>: IApiResponseBuilderBase
    {
        IApiObjectResponseBuilder<T> SetHttpCode(int code);
        IApiObjectResponseBuilder<T> SetStatusCodeSuccess(string code);
        IApiObjectResponseBuilder<T> SetStatusCodeFailed(string code);
        IApiObjectResponseBuilder<T> SetException(Exception exception);
        IApiObjectResponseBuilder<T> SetData(T data);
        IApiObjectResponse<T> Build();
    }
}