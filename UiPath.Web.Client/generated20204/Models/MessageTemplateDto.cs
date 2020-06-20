// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Used to store various predefined application message templates like
    /// custom login layout.
    /// </summary>
    public partial class MessageTemplateDto
    {
        /// <summary>
        /// Initializes a new instance of the MessageTemplateDto class.
        /// </summary>
        public MessageTemplateDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MessageTemplateDto class.
        /// </summary>
        /// <param name="name">The name of a specific template (e.g.
        /// Templates.LoginLayout).</param>
        /// <param name="value">The value assigned to a specific
        /// template.</param>
        public MessageTemplateDto(string name, string value = default(string), string id = default(string))
        {
            Name = name;
            Value = value;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of a specific template (e.g.
        /// Templates.LoginLayout).
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value assigned to a specific template.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
