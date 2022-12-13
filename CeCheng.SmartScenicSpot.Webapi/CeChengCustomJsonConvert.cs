using Newtonsoft.Json.Serialization;
using CeCheng.SmartScenicSpot.Commoms;
using Newtonsoft.Json;
using System;
using Org.BouncyCastle.Utilities;
using AutoMapper.Internal;

namespace CeCheng.SmartScenicSpot.Webapi
{
    /// <summary>
    /// 
    /// </summary>
    public class CeChengCustomJsonConvert: DefaultContractResolver
    {
        /// <summary>
        /// 重新自定义大小写
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToCamelCase(true);
        }

        //protected override JsonConverter ResolveContractConverter(Type objectType)
        //{
        //    if (objectType == typeof(decimal) || objectType == typeof(Integers)) { 
        //     //objectType.SetMemberValue()
        //    }
        //    return base.ResolveContractConverter(objectType);
        //}

    }



}
