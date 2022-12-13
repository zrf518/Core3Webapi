using CeCheng.SmartScenicSpot.Commoms;
using Newtonsoft.Json;
using System;

namespace CeCheng.SmartScenicSpot.Webapi
{
    /// <summary>
    /// 
    /// </summary>
    public class JsonSerlazerDoubleDecimalNod0Converter : JsonConverter
    {
        //private Type dblArrayType = typeof(double[]);
        //private Type decArrayType = typeof(decimal[]);

        private Type dblArrayType = typeof(double);
        private Type decArrayType = typeof(decimal);
        /// <summary>
        /// 可以转换的类型
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            if (objectType == dblArrayType || objectType == decArrayType)
                return true;
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return existingValue;
        }
        private void dumpNumArray<T>(JsonWriter writer, T array)
        {
            //foreach (T n in array)
            //{
            var s = array.ToString();
            //此處可考慮改用string.format("{0:#0.####}")[小數後方#數目依最大小數位數決定]
            //感謝網友vencin提供建議
            if (s.EndsWith(".0"))
            {
                var ss = s.Substring(0, s.Length - 2).Replace("[","").Replace("]","");
                writer.WriteRawValue(ss);//WriteValue(ss);//
            }
            else if (s.Contains("."))
            {
                var sss = s.TrimEnd('0').TrimEnd('.');
                writer.WriteRawValue(sss);
            }
            else
            {
                writer.WriteRawValue(s);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            //writer.WriteStartArray();
            //Type t = value.GetType();
            //if (t == dblArrayType)
            //    dumpNumArray<double>(writer, (double[])value);
            //else if (t == decArrayType)
            //    dumpNumArray<decimal>(writer, (decimal[])value);
            //else
            //    throw new NotImplementedException();
            //writer.WriteEndArray();

            writer.WriteStartArray();
            Type t = value.GetType();
            if (t == dblArrayType)
                dumpNumArray<double>(writer, (double)value);
            else if (t == decArrayType)
                dumpNumArray<decimal>(writer, (decimal)value);
            else { }
            writer.WriteEndArray();
        }
    }
}
