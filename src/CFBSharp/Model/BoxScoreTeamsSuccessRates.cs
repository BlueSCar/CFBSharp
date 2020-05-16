/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 1.25.1
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
    /// BoxScoreTeamsSuccessRates
    /// </summary>
    [DataContract]
    public partial class BoxScoreTeamsSuccessRates :  IEquatable<BoxScoreTeamsSuccessRates>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxScoreTeamsSuccessRates" /> class.
        /// </summary>
        /// <param name="team">team.</param>
        /// <param name="overall">overall.</param>
        /// <param name="standardDowns">standardDowns.</param>
        /// <param name="passingDowns">passingDowns.</param>
        public BoxScoreTeamsSuccessRates(string team = default(string), BoxScoreTeamsOverall overall = default(BoxScoreTeamsOverall), BoxScoreTeamsOverall standardDowns = default(BoxScoreTeamsOverall), BoxScoreTeamsOverall passingDowns = default(BoxScoreTeamsOverall))
        {
            this.Team = team;
            this.Overall = overall;
            this.StandardDowns = standardDowns;
            this.PassingDowns = passingDowns;
        }
        
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name="overall", EmitDefaultValue=false)]
        public BoxScoreTeamsOverall Overall { get; set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [DataMember(Name="standardDowns", EmitDefaultValue=false)]
        public BoxScoreTeamsOverall StandardDowns { get; set; }

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [DataMember(Name="passingDowns", EmitDefaultValue=false)]
        public BoxScoreTeamsOverall PassingDowns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxScoreTeamsSuccessRates {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
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
            return this.Equals(input as BoxScoreTeamsSuccessRates);
        }

        /// <summary>
        /// Returns true if BoxScoreTeamsSuccessRates instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxScoreTeamsSuccessRates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxScoreTeamsSuccessRates input)
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
                    this.Overall == input.Overall ||
                    (this.Overall != null &&
                    this.Overall.Equals(input.Overall))
                ) && 
                (
                    this.StandardDowns == input.StandardDowns ||
                    (this.StandardDowns != null &&
                    this.StandardDowns.Equals(input.StandardDowns))
                ) && 
                (
                    this.PassingDowns == input.PassingDowns ||
                    (this.PassingDowns != null &&
                    this.PassingDowns.Equals(input.PassingDowns))
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
                if (this.Overall != null)
                    hashCode = hashCode * 59 + this.Overall.GetHashCode();
                if (this.StandardDowns != null)
                    hashCode = hashCode * 59 + this.StandardDowns.GetHashCode();
                if (this.PassingDowns != null)
                    hashCode = hashCode * 59 + this.PassingDowns.GetHashCode();
                return hashCode;
            }
        }
    }

}
