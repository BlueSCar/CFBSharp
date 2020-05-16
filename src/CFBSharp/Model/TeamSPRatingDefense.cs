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
    /// TeamSPRatingDefense
    /// </summary>
    [DataContract]
    public partial class TeamSPRatingDefense :  IEquatable<TeamSPRatingDefense>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSPRatingDefense" /> class.
        /// </summary>
        /// <param name="rating">rating.</param>
        /// <param name="success">success.</param>
        /// <param name="explosiveness">explosiveness.</param>
        /// <param name="rushing">rushing.</param>
        /// <param name="pasing">pasing.</param>
        /// <param name="standardDowns">standardDowns.</param>
        /// <param name="passingDowns">passingDowns.</param>
        /// <param name="havoc">havoc.</param>
        public TeamSPRatingDefense(decimal? rating = default(decimal?), decimal? success = default(decimal?), decimal? explosiveness = default(decimal?), decimal? rushing = default(decimal?), decimal? pasing = default(decimal?), decimal? standardDowns = default(decimal?), decimal? passingDowns = default(decimal?), TeamSPRatingDefenseHavoc havoc = default(TeamSPRatingDefenseHavoc))
        {
            this.Rating = rating;
            this.Success = success;
            this.Explosiveness = explosiveness;
            this.Rushing = rushing;
            this.Pasing = pasing;
            this.StandardDowns = standardDowns;
            this.PassingDowns = passingDowns;
            this.Havoc = havoc;
        }
        
        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public decimal? Rating { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public decimal? Success { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [DataMember(Name="explosiveness", EmitDefaultValue=false)]
        public decimal? Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [DataMember(Name="rushing", EmitDefaultValue=false)]
        public decimal? Rushing { get; set; }

        /// <summary>
        /// Gets or Sets Pasing
        /// </summary>
        [DataMember(Name="pasing", EmitDefaultValue=false)]
        public decimal? Pasing { get; set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [DataMember(Name="standardDowns", EmitDefaultValue=false)]
        public decimal? StandardDowns { get; set; }

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [DataMember(Name="passingDowns", EmitDefaultValue=false)]
        public decimal? PassingDowns { get; set; }

        /// <summary>
        /// Gets or Sets Havoc
        /// </summary>
        [DataMember(Name="havoc", EmitDefaultValue=false)]
        public TeamSPRatingDefenseHavoc Havoc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamSPRatingDefense {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  Pasing: ").Append(Pasing).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
            sb.Append("  Havoc: ").Append(Havoc).Append("\n");
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
            return this.Equals(input as TeamSPRatingDefense);
        }

        /// <summary>
        /// Returns true if TeamSPRatingDefense instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamSPRatingDefense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamSPRatingDefense input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Explosiveness == input.Explosiveness ||
                    (this.Explosiveness != null &&
                    this.Explosiveness.Equals(input.Explosiveness))
                ) && 
                (
                    this.Rushing == input.Rushing ||
                    (this.Rushing != null &&
                    this.Rushing.Equals(input.Rushing))
                ) && 
                (
                    this.Pasing == input.Pasing ||
                    (this.Pasing != null &&
                    this.Pasing.Equals(input.Pasing))
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
                ) && 
                (
                    this.Havoc == input.Havoc ||
                    (this.Havoc != null &&
                    this.Havoc.Equals(input.Havoc))
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
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Explosiveness != null)
                    hashCode = hashCode * 59 + this.Explosiveness.GetHashCode();
                if (this.Rushing != null)
                    hashCode = hashCode * 59 + this.Rushing.GetHashCode();
                if (this.Pasing != null)
                    hashCode = hashCode * 59 + this.Pasing.GetHashCode();
                if (this.StandardDowns != null)
                    hashCode = hashCode * 59 + this.StandardDowns.GetHashCode();
                if (this.PassingDowns != null)
                    hashCode = hashCode * 59 + this.PassingDowns.GetHashCode();
                if (this.Havoc != null)
                    hashCode = hashCode * 59 + this.Havoc.GetHashCode();
                return hashCode;
            }
        }
    }

}
