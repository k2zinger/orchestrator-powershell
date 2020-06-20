// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ODataPath
    {
        /// <summary>
        /// Initializes a new instance of the ODataPath class.
        /// </summary>
        public ODataPath()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataPath class.
        /// </summary>
        public ODataPath(IEdmType edmType = default(IEdmType), IEdmNavigationSource navigationSource = default(IEdmNavigationSource), IList<ODataPathSegment> segments = default(IList<ODataPathSegment>), string pathTemplate = default(string))
        {
            EdmType = edmType;
            NavigationSource = navigationSource;
            Segments = segments;
            PathTemplate = pathTemplate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EdmType")]
        public IEdmType EdmType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NavigationSource")]
        public IEdmNavigationSource NavigationSource { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Segments")]
        public IList<ODataPathSegment> Segments { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PathTemplate")]
        public string PathTemplate { get; private set; }

    }
}
