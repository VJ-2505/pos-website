﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biz1PosApi.Models
{
    public interface ILoggerService
    {
        void Queue(UPOrderPayload payload);
    }
}
