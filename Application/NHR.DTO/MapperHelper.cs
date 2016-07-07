using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NHR.DTO;
using NHR.Entity;
namespace NHR.DTO
{
    public static class MapperHelper
    {

        /// <summary>
        ///  单个对象映射
        /// </summary>
        public static T MapTo<T>(this DTO.BaseDTO obj)
        {

            Mapper.Initialize(cfg => cfg.CreateMap(obj.GetType(), typeof(T)));
            return Mapper.Map<T>(obj);
        }
        /// <summary>
        /// 数据库实体的扩展  映射功能
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T MapTo<T>(this Entity.EntityBase obj)
        {       
         
            Mapper.Initialize(cfg =>  cfg.CreateMap(obj.GetType(), typeof(T)));
            return Mapper.Map<T>(obj);
        }
       
        /// <summary>
        /// 集合列表类型映射
        /// </summary>
        public static List<TDestination> MapToList<TSource, TDestination>(this IEnumerable<TSource> source)
            where TSource:class            
        {         
            Mapper.Initialize(cfg => cfg.CreateMap(typeof(TSource), typeof(TDestination)));
            return Mapper.Map<List<TDestination>>(source);
        }     


    }
}
