/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.2.9
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
    /// BoxScoreTeamsRushing
    /// </summary>
    [DataContract]
    public partial class BoxScoreTeamsRushing :  IEquatable<BoxScoreTeamsRushing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxScoreTeamsRushing" /> class.
        /// </summary>
        /// <param name="team">team.</param>
        /// <param name="powerSuccess">powerSuccess.</param>
        /// <param name="stuffRate">stuffRate.</param>
        /// <param name="lineYards">lineYards.</param>
        /// <param name="lineYardsAverage">lineYardsAverage.</param>
        /// <param name="secondLevelYards">secondLevelYards.</param>
        /// <param name="secondLevelYardsAverage">secondLevelYardsAverage.</param>
        /// <param name="openFieldYards">openFieldYards.</param>
        /// <param name="openFieldYardsAverage">openFieldYardsAverage.</param>
        public BoxScoreTeamsRushing(string team = default(string), decimal? powerSuccess = default(decimal?), decimal? stuffRate = default(decimal?), decimal? lineYards = default(decimal?), decimal? lineYardsAverage = default(decimal?), int? secondLevelYards = default(int?), decimal? secondLevelYardsAverage = default(decimal?), int? openFieldYards = default(int?), decimal? openFieldYardsAverage = default(decimal?))
        {
            this.Team = team;
            this.PowerSuccess = powerSuccess;
            this.StuffRate = stuffRate;
            this.LineYards = lineYards;
            this.LineYardsAverage = lineYardsAverage;
            this.SecondLevelYards = secondLevelYards;
            this.SecondLevelYardsAverage = secondLevelYardsAverage;
            this.OpenFieldYards = openFieldYards;
            this.OpenFieldYardsAverage = openFieldYardsAverage;
        }
        
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets PowerSuccess
        /// </summary>
        [DataMember(Name="powerSuccess", EmitDefaultValue=false)]
        public decimal? PowerSuccess { get; set; }

        /// <summary>
        /// Gets or Sets StuffRate
        /// </summary>
        [DataMember(Name="stuffRate", EmitDefaultValue=false)]
        public decimal? StuffRate { get; set; }

        /// <summary>
        /// Gets or Sets LineYards
        /// </summary>
        [DataMember(Name="lineYards", EmitDefaultValue=false)]
        public decimal? LineYards { get; set; }

        /// <summary>
        /// Gets or Sets LineYardsAverage
        /// </summary>
        [DataMember(Name="lineYardsAverage", EmitDefaultValue=false)]
        public decimal? LineYardsAverage { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYards
        /// </summary>
        [DataMember(Name="secondLevelYards", EmitDefaultValue=false)]
        public int? SecondLevelYards { get; set; }

        /// <summary>
        /// Gets or Sets SecondLevelYardsAverage
        /// </summary>
        [DataMember(Name="secondLevelYardsAverage", EmitDefaultValue=false)]
        public decimal? SecondLevelYardsAverage { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYards
        /// </summary>
        [DataMember(Name="openFieldYards", EmitDefaultValue=false)]
        public int? OpenFieldYards { get; set; }

        /// <summary>
        /// Gets or Sets OpenFieldYardsAverage
        /// </summary>
        [DataMember(Name="openFieldYardsAverage", EmitDefaultValue=false)]
        public decimal? OpenFieldYardsAverage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxScoreTeamsRushing {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  PowerSuccess: ").Append(PowerSuccess).Append("\n");
            sb.Append("  StuffRate: ").Append(StuffRate).Append("\n");
            sb.Append("  LineYards: ").Append(LineYards).Append("\n");
            sb.Append("  LineYardsAverage: ").Append(LineYardsAverage).Append("\n");
            sb.Append("  SecondLevelYards: ").Append(SecondLevelYards).Append("\n");
            sb.Append("  SecondLevelYardsAverage: ").Append(SecondLevelYardsAverage).Append("\n");
            sb.Append("  OpenFieldYards: ").Append(OpenFieldYards).Append("\n");
            sb.Append("  OpenFieldYardsAverage: ").Append(OpenFieldYardsAverage).Append("\n");
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
            return this.Equals(input as BoxScoreTeamsRushing);
        }

        /// <summary>
        /// Returns true if BoxScoreTeamsRushing instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxScoreTeamsRushing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxScoreTeamsRushing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.PowerSuccess == input.PowerSuccess ||
                    (this.PowerSuccess != null &&
                    this.PowerSuccess.Equals(input.PowerSuccess))
                ) && 
                (
                    this.StuffRate == input.StuffRate ||
                    (this.StuffRate != null &&
                    this.StuffRate.Equals(input.StuffRate))
                ) && 
                (
                    this.LineYards == input.LineYards ||
                    (this.LineYards != null &&
                    this.LineYards.Equals(input.LineYards))
                ) && 
                (
                    this.LineYardsAverage == input.LineYardsAverage ||
                    (this.LineYardsAverage != null &&
                    this.LineYardsAverage.Equals(input.LineYardsAverage))
                ) && 
                (
                    this.SecondLevelYards == input.SecondLevelYards ||
                    (this.SecondLevelYards != null &&
                    this.SecondLevelYards.Equals(input.SecondLevelYards))
                ) && 
                (
                    this.SecondLevelYardsAverage == input.SecondLevelYardsAverage ||
                    (this.SecondLevelYardsAverage != null &&
                    this.SecondLevelYardsAverage.Equals(input.SecondLevelYardsAverage))
                ) && 
                (
                    this.OpenFieldYards == input.OpenFieldYards ||
                    (this.OpenFieldYards != null &&
                    this.OpenFieldYards.Equals(input.OpenFieldYards))
                ) && 
                (
                    this.OpenFieldYardsAverage == input.OpenFieldYardsAverage ||
                    (this.OpenFieldYardsAverage != null &&
                    this.OpenFieldYardsAverage.Equals(input.OpenFieldYardsAverage))
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
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.PowerSuccess != null)
                    hashCode = hashCode * 59 + this.PowerSuccess.GetHashCode();
                if (this.StuffRate != null)
                    hashCode = hashCode * 59 + this.StuffRate.GetHashCode();
                if (this.LineYards != null)
                    hashCode = hashCode * 59 + this.LineYards.GetHashCode();
                if (this.LineYardsAverage != null)
                    hashCode = hashCode * 59 + this.LineYardsAverage.GetHashCode();
                if (this.SecondLevelYards != null)
                    hashCode = hashCode * 59 + this.SecondLevelYards.GetHashCode();
                if (this.SecondLevelYardsAverage != null)
                    hashCode = hashCode * 59 + this.SecondLevelYardsAverage.GetHashCode();
                if (this.OpenFieldYards != null)
                    hashCode = hashCode * 59 + this.OpenFieldYards.GetHashCode();
                if (this.OpenFieldYardsAverage != null)
                    hashCode = hashCode * 59 + this.OpenFieldYardsAverage.GetHashCode();
                return hashCode;
            }
        }
    }

}
