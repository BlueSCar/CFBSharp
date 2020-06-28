/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.1.0
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
    /// AdvancedSeasonStatOffenseFieldPosition
    /// </summary>
    [DataContract]
    public partial class AdvancedSeasonStatOffenseFieldPosition :  IEquatable<AdvancedSeasonStatOffenseFieldPosition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSeasonStatOffenseFieldPosition" /> class.
        /// </summary>
        /// <param name="averageStart">averageStart.</param>
        /// <param name="averagePredictedPoints">averagePredictedPoints.</param>
        public AdvancedSeasonStatOffenseFieldPosition(decimal? averageStart = default(decimal?), decimal? averagePredictedPoints = default(decimal?))
        {
            this.AverageStart = averageStart;
            this.AveragePredictedPoints = averagePredictedPoints;
        }
        
        /// <summary>
        /// Gets or Sets AverageStart
        /// </summary>
        [DataMember(Name="averageStart", EmitDefaultValue=false)]
        public decimal? AverageStart { get; set; }

        /// <summary>
        /// Gets or Sets AveragePredictedPoints
        /// </summary>
        [DataMember(Name="averagePredictedPoints", EmitDefaultValue=false)]
        public decimal? AveragePredictedPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedSeasonStatOffenseFieldPosition {\n");
            sb.Append("  AverageStart: ").Append(AverageStart).Append("\n");
            sb.Append("  AveragePredictedPoints: ").Append(AveragePredictedPoints).Append("\n");
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
            return this.Equals(input as AdvancedSeasonStatOffenseFieldPosition);
        }

        /// <summary>
        /// Returns true if AdvancedSeasonStatOffenseFieldPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedSeasonStatOffenseFieldPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedSeasonStatOffenseFieldPosition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AverageStart == input.AverageStart ||
                    (this.AverageStart != null &&
                    this.AverageStart.Equals(input.AverageStart))
                ) && 
                (
                    this.AveragePredictedPoints == input.AveragePredictedPoints ||
                    (this.AveragePredictedPoints != null &&
                    this.AveragePredictedPoints.Equals(input.AveragePredictedPoints))
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
                if (this.AverageStart != null)
                    hashCode = hashCode * 59 + this.AverageStart.GetHashCode();
                if (this.AveragePredictedPoints != null)
                    hashCode = hashCode * 59 + this.AveragePredictedPoints.GetHashCode();
                return hashCode;
            }
        }
    }

}
