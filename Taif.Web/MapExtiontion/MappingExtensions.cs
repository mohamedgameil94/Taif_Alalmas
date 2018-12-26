using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Taif.Data.Entities.Product;
using Taif.Web.Models;

namespace Taif.Web.MapExtiontion
{
    public static class MappingExtensions
    {
        private static TDestination Map<TDestination>(this object source)
        {
            return AutoMapperConfiguration.Mapper.Map<TDestination>(source);
        }

        private static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>()
                .IgnoreAllNonExisting();
            });
            var mapper = config.CreateMapper();
            return AutoMapperConfiguration.Mapper.Map(source, destination);
        }

        public static IMappingExpression<TSource, TDestination> IgnoreAllNonExisting<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
        {
            var flags = BindingFlags.Public | BindingFlags.Instance;
            var sourceType = typeof(TSource);
            var destinationProperties = typeof(TDestination).GetProperties(flags);

            foreach (var property in destinationProperties)
            {
                if (sourceType.GetProperty(property.Name, flags) == null)
                {
                    expression.ForMember(property.Name, opt => opt.Ignore());
                }
            }
            return expression;
        }

        #region Add Mapping 
        //Product 

        public static Product ToEntity(this ProductModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductModel, Product>()
                .IgnoreAllNonExisting();
            });
            var mapper = config.CreateMapper();
            var entity = mapper.Map<ProductModel, Product>(model);
            return entity;
        }

        public static ProductModel ToModel(this Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductModel>()
                .IgnoreAllNonExisting();
            });
            var mapper = config.CreateMapper();
            var model = mapper.Map<Product, ProductModel>(entity);
            return model;
        }





        #endregion

    }
}