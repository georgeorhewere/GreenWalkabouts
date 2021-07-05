﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Walkabouts.Services.Interfaces
{
    public interface IBaseUpdateService
    {
        // command
        void Add<T>(T model) where T : class;
        void Update<T>(T model) where T : class;
        void Delete<T>(T model) where T : class;
    }
}