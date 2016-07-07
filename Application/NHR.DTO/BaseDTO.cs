using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace NHR.DTO
{
    public class BaseDTO
    {
        /// <summary>
        /// 映射
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        //public virtual TResult MapTo<TResult>()
        //{
        //    Mapper.Initialize(cfg => cfg.CreateMap<T,TResult>());
        //    return Mapper.Map<T,TResult>(this);
        //}
    }
}
