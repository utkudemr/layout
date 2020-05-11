﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcern.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key,object data,int duration);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);//Get ile başlayan bütün cachleri sil gibi...
    }
}
