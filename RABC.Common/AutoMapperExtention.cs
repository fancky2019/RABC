using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RABC.Common
{
    public static class AutoMapperExtention
    {
        public static TResult MapTo<TResult>(this object source)
        {
            return AutoMapperConfig.IMapper.Map<TResult>(source);
        }

        public static List<TResult> MapTo<TResult>(this IEnumerable source)
        {
            return AutoMapperConfig.IMapper.Map<List<TResult>>(source);
        }

        public static TResult MapTo<TSource, TResult>(this TSource source)
        {
            return AutoMapperConfig.IMapper.Map<TSource, TResult>(source);
        }

        public static IEnumerable<TResult> MapTo<TSource, TResult>(this IEnumerable<TSource> source)
        {
            return AutoMapperConfig.IMapper.Map<IEnumerable<TResult>>(source);
        }

        public static List<TResult> MapTo<TSource, TResult>(this List<TSource> source)
        {
            return AutoMapperConfig.IMapper.Map<List<TResult>>(source);
        }
    }
}
