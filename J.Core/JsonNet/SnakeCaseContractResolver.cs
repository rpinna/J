using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace Cofamilies.J.Core.JsonNet
{
  public class SnakeCaseContractResolver : DefaultContractResolver
  {
    #region GetSnakeCase(string input)
    private string GetSnakeCase(string input)
    {
      if (string.IsNullOrEmpty(input))
        return input;

      var buffer = "";

      for (var i = 0; i < input.Length; i++)
      {
        var isLast = (i == input.Length - 1);
        var isSecondFromLast = (i == input.Length - 2);

        var curr = input[i];
        var next = !isLast ? input[i + 1] : '\0';
        var afterNext = !isSecondFromLast && !isLast ? input[i + 2] : '\0';

        buffer += char.ToLower(curr);

        if (!char.IsDigit(curr) && char.IsUpper(next))
        {
          if (char.IsUpper(curr))
          {
            if (!isLast && !isSecondFromLast && !char.IsUpper(afterNext))
              buffer += "_";
          }
          else
            buffer += "_";
        }

        if (!char.IsDigit(curr) && char.IsDigit(next))
          buffer += "_";
        if (char.IsDigit(curr) && !char.IsDigit(next) && !isLast)
          buffer += "_";
      }

      return buffer;
    } 
    #endregion

    #region ResolvePropertyName(string propertyName)
    protected override string ResolvePropertyName(string propertyName)
    {
      return GetSnakeCase(propertyName);
    }
    #endregion
  }
}
