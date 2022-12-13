using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Webapi.Controller //CeCheng.SmartScenicSpot.Commoms
{
    public static class CeChengModelStateExtention
    {
        public static string GetModelStateErrorMessage(this ModelStateDictionary ModelState)
        {
            var sb = new StringBuilder();
            try
            {
                if (!ModelState.IsValid && ModelState.ErrorCount > 0)
                {
                 
                    foreach (var item in ModelState.Values)
                    {
                        foreach (var f in item.Errors)
                            sb.Append($"{f.ErrorMessage},");
                    }
                    return sb.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                return sb.ToString();
            }
        }
    }
}
