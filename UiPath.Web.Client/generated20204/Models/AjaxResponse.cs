// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AjaxResponse
    {
        /// <summary>
        /// Initializes a new instance of the AjaxResponse class.
        /// </summary>
        public AjaxResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AjaxResponse class.
        /// </summary>
        public AjaxResponse(object result = default(object), string targetUrl = default(string), bool? success = default(bool?), ErrorInfo error = default(ErrorInfo), bool? unAuthorizedRequest = default(bool?), bool? __abp = default(bool?))
        {
            Result = result;
            TargetUrl = targetUrl;
            Success = success;
            Error = error;
            UnAuthorizedRequest = unAuthorizedRequest;
            this.__abp = __abp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public object Result { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetUrl")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorInfo Error { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unAuthorizedRequest")]
        public bool? UnAuthorizedRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "__abp")]
        public bool? __abp { get; private set; }

    }
}
