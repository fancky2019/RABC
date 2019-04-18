using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RABC.Common
{
    public static class AutoMapperConfig
    {
        public static IMapper IMapper;
        static AutoMapperConfig()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMissingTypeMaps = true);
            IMapper = config.CreateMapper();
        }


    }
}
