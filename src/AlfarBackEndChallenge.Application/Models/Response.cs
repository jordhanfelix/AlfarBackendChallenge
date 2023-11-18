using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

using AlfarBackEndChallenge.Application.Utils;

namespace AlfarBackEndChallenge.Application.Models
{
    /// <summary>
    /// api responses template class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Response<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Response{T}"/> class for a successful response.
        /// </summary>
        /// <param name="data">The data in the response.</param>
        public Response(T data)
        {
            Succeeded = true;
            Title = ApplicationMessages.SUCCESS_MESSAGE;
            Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response{T}"/> class.
        /// </summary>
        /// <param name="data">The data in the response.</param>
        /// <param name="succeeded">Indicates whether the operation succeeded.</param>
        /// <param name="title">The title or message associated with the response.</param>
        public Response(T data, bool succeeded, string title)
        {
            Succeeded = succeeded;
            Title = title;
            Data = data;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Response{T}"/> class with no data.
        /// </summary>
        public Response()
        {
        }

        /// <summary>
        /// Gets or sets the data in the response.
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the operation succeeded.
        /// </summary>
        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }
        
        /// <summary>
        /// Gets or sets the title or message associated with the response.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}