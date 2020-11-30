/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.3.3
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = CFBSharp.Client.SwaggerDateConverter;

namespace CFBSharp.Model
{
    /// <summary>
    /// BoxScoreTeamsOverall
    /// </summary>
    [DataContract]
    public partial class BoxScoreTeamsOverall :  IEquatable<BoxScoreTeamsOverall>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxScoreTeamsOverall" /> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="quarter1">quarter1.</param>
        /// <param name="quarter2">quarter2.</param>
        /// <param name="quarter3">quarter3.</param>
        /// <param name="quarter4">quarter4.</param>
        public BoxScoreTeamsOverall(decimal? total = default(decimal?), decimal? quarter1 = default(decimal?), decimal? quarter2 = default(decimal?), decimal? quarter3 = default(decimal?), decimal? quarter4 = default(decimal?))
        {
            this.Total = total;
            this.Quarter1 = quarter1;
            this.Quarter2 = quarter2;
            this.Quarter3 = quarter3;
            this.Quarter4 = quarter4;
        }
        
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Gets or Sets Quarter1
        /// </summary>
        [DataMember(Name="quarter1", EmitDefaultValue=false)]
        public decimal? Quarter1 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter2
        /// </summary>
        [DataMember(Name="quarter2", EmitDefaultValue=false)]
        public decimal? Quarter2 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter3
        /// </summary>
        [DataMember(Name="quarter3", EmitDefaultValue=false)]
        public decimal? Quarter3 { get; set; }

        /// <summary>
        /// Gets or Sets Quarter4
        /// </summary>
        [DataMember(Name="quarter4", EmitDefaultValue=false)]
        public decimal? Quarter4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxScoreTeamsOverall {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Quarter1: ").Append(Quarter1).Append("\n");
            sb.Append("  Quarter2: ").Append(Quarter2).Append("\n");
            sb.Append("  Quarter3: ").Append(Quarter3).Append("\n");
            sb.Append("  Quarter4: ").Append(Quarter4).Append("\n");
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
            return this.Equals(input as BoxScoreTeamsOverall);
        }

        /// <summary>
        /// Returns true if BoxScoreTeamsOverall instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxScoreTeamsOverall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxScoreTeamsOverall input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Quarter1 == input.Quarter1 ||
                    (this.Quarter1 != null &&
                    this.Quarter1.Equals(input.Quarter1))
                ) && 
                (
                    this.Quarter2 == input.Quarter2 ||
                    (this.Quarter2 != null &&
                    this.Quarter2.Equals(input.Quarter2))
                ) && 
                (
                    this.Quarter3 == input.Quarter3 ||
                    (this.Quarter3 != null &&
                    this.Quarter3.Equals(input.Quarter3))
                ) && 
                (
                    this.Quarter4 == input.Quarter4 ||
                    (this.Quarter4 != null &&
                    this.Quarter4.Equals(input.Quarter4))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Quarter1 != null)
                    hashCode = hashCode * 59 + this.Quarter1.GetHashCode();
                if (this.Quarter2 != null)
                    hashCode = hashCode * 59 + this.Quarter2.GetHashCode();
                if (this.Quarter3 != null)
                    hashCode = hashCode * 59 + this.Quarter3.GetHashCode();
                if (this.Quarter4 != null)
                    hashCode = hashCode * 59 + this.Quarter4.GetHashCode();
                return hashCode;
            }
        }
    }

}
