using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfarBackEndChallenge.Application.Utils.Swagger
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = true)]
    public class SwaggerParameterExampleAttribute : Attribute
    {
        /// <summary>
        /// Initializes a parameter with name and value.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public SwaggerParameterExampleAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// initializes a parameter where the value itself is also the name.
        /// </summary>
        /// <param name="value"></param>
        public SwaggerParameterExampleAttribute(string value)
        {
            Name = value;
            Value = value;
        }

        /// <summary>
        /// name of parameter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// value of parameter
        /// </summary>
        public string Value { get; set; }
    }
}