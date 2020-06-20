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

    public partial class PageResultDtoFolderDto
    {
        /// <summary>
        /// Initializes a new instance of the PageResultDtoFolderDto class.
        /// </summary>
        public PageResultDtoFolderDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PageResultDtoFolderDto class.
        /// </summary>
        public PageResultDtoFolderDto(IList<FolderDto> pageItems = default(IList<FolderDto>), int? count = default(int?))
        {
            PageItems = pageItems;
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PageItems")]
        public IList<FolderDto> PageItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Count")]
        public int? Count { get; set; }

    }
}
