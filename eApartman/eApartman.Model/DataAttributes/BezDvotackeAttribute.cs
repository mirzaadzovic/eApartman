using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eApartman.Model.DataAttributes
{
    public class BezDvotackeAttribute : DataTypeAttribute
    {
        public BezDvotackeAttribute() : base(new DataType())
        {
        }
        public override bool IsValid(object value)
        {
            string text = value.ToString();
            return !text.Contains(":");
        }
    }
}
