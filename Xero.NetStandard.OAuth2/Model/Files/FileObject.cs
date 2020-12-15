/* 
 * Xero Files API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.6.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Files
{
    /// <summary>
    /// FileObject
    /// </summary>
    [DataContract]
    public partial class FileObject :  IEquatable<FileObject>, IValidatableObject
    {
        
        /// <summary>
        /// File Name
        /// </summary>
        /// <value>File Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// MimeType of the file (image/png, image/jpeg, application/pdf, etc..)
        /// </summary>
        /// <value>MimeType of the file (image/png, image/jpeg, application/pdf, etc..)</value>
        [DataMember(Name="MimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Numeric value in bytes
        /// </summary>
        /// <value>Numeric value in bytes</value>
        [DataMember(Name="Size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Created date in UTC
        /// </summary>
        /// <value>Created date in UTC</value>
        [DataMember(Name="CreatedDateUtc", EmitDefaultValue=false)]
        public string CreatedDateUtc { get; set; }

        /// <summary>
        /// Updated date in UTC
        /// </summary>
        /// <value>Updated date in UTC</value>
        [DataMember(Name="UpdatedDateUtc", EmitDefaultValue=false)]
        public string UpdatedDateUtc { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// File object&#39;s UUID
        /// </summary>
        /// <value>File object&#39;s UUID</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Folder relation object&#39;s UUID
        /// </summary>
        /// <value>Folder relation object&#39;s UUID</value>
        [DataMember(Name="FolderId", EmitDefaultValue=false)]
        public Guid? FolderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileObject {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  CreatedDateUtc: ").Append(CreatedDateUtc).Append("\n");
            sb.Append("  UpdatedDateUtc: ").Append(UpdatedDateUtc).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileObject);
        }

        /// <summary>
        /// Returns true if FileObject instances are equal
        /// </summary>
        /// <param name="input">Instance of FileObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.CreatedDateUtc == input.CreatedDateUtc ||
                    (this.CreatedDateUtc != null &&
                    this.CreatedDateUtc.Equals(input.CreatedDateUtc))
                ) && 
                (
                    this.UpdatedDateUtc == input.UpdatedDateUtc ||
                    (this.UpdatedDateUtc != null &&
                    this.UpdatedDateUtc.Equals(input.UpdatedDateUtc))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.FolderId == input.FolderId ||
                    (this.FolderId != null &&
                    this.FolderId.Equals(input.FolderId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.CreatedDateUtc != null)
                    hashCode = hashCode * 59 + this.CreatedDateUtc.GetHashCode();
                if (this.UpdatedDateUtc != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUtc.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.FolderId != null)
                    hashCode = hashCode * 59 + this.FolderId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
