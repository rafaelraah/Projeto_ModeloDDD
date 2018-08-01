using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {

        public static void RegisterMappings()
        {
          //  var dtv = new DomainToViewModelMappingProfile();//.Configurar();
          //  var vtd = new ViewModelToDomainMappingProfile();//.Configurar();

         //   dtv.Configurar();
         //   vtd.Configurar();

            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }

    }
}