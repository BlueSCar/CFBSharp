/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.3.1
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
    /// AdvancedSeasonStatOffenseStandardDowns
    /// </summary>
    [DataContract]
    public partial class AdvancedSeasonStatOffenseStandardDowns :  IEquatable<AdvancedSeasonStatOffenseStandardDowns>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSeasonStatOffenseStandardDowns" /> class.
        /// </summary>
        /// <param name="rate">rate.</param>
        /// <param name="ppa">ppa.</param>
        /// <param name="successRate">successRate.</param>
        /// <param name="explosiveness">explosiveness.</param>
        public AdvancedSeasonStatOffenseStandardDowns(decimal? rate = default(decimal?), decimal? ppa = default(decimal?), decimal? successRate = default(decimal?), decimal? explosiveness = default(decimal?))
        {
            this.Rate = rate;
            this.Ppa = ppa;
            this.SuccessRate = successRate;
            this.Explosiveness = explosiveness;
        }
        
        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public decimal? Rate { get; set; }

        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [DataMember(Name="ppa", EmitDefaultValue=false)]
        public decimal? Ppa { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRate
        /// </summary>
        [DataMember(Name="successRate", EmitDefaultValue=false)]
        public decimal? SuccessRate { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [DataMember(Name="explosiveness", EmitDefaultValue=false)]
        public decimal? Explosiveness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedSeasonStatOffenseStandardDowns {\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
            sb.Append("  SuccessRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
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
            return this.Equals(input as AdvancedSeasonStatOffenseStandardDowns);
        }

        /// <summary>
        /// Returns true if AdvancedSeasonStatOffenseStandardDowns instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedSeasonStatOffenseStandardDowns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedSeasonStatOffenseStandardDowns input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.Ppa == input.Ppa ||
                    (this.Ppa != null &&
                    this.Ppa.Equals(input.Ppa))
                ) && 
                (
                    this.SuccessRate == input.SuccessRate ||
                    (this.SuccessRate != null &&
                    this.SuccessRate.Equals(input.SuccessRate))
                ) && 
                (
                    this.Explosiveness == input.Explosiveness ||
                    (this.Explosiveness != null &&
                    this.Explosiveness.Equals(input.Explosiveness))
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
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.Ppa != null)
                    hashCode = hashCode * 59 + this.Ppa.GetHashCode();
                if (this.SuccessRate != null)
                    hashCode = hashCode * 59 + this.SuccessRate.GetHashCode();
                if (this.Explosiveness != null)
                    hashCode = hashCode * 59 + this.Explosiveness.GetHashCode();
                return hashCode;
            }
        }
    }

}
