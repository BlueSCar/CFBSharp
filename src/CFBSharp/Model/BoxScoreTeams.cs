/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.2.16
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
    /// BoxScoreTeams
    /// </summary>
    [DataContract]
    public partial class BoxScoreTeams :  IEquatable<BoxScoreTeams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxScoreTeams" /> class.
        /// </summary>
        /// <param name="ppa">ppa.</param>
        /// <param name="successRates">successRates.</param>
        /// <param name="explosiveness">explosiveness.</param>
        /// <param name="rushing">rushing.</param>
        /// <param name="havoc">havoc.</param>
        /// <param name="scoringOpportunities">scoringOpportunities.</param>
        /// <param name="fieldPosition">fieldPosition.</param>
        public BoxScoreTeams(List<BoxScoreTeamsPpa> ppa = default(List<BoxScoreTeamsPpa>), List<BoxScoreTeamsSuccessRates> successRates = default(List<BoxScoreTeamsSuccessRates>), List<BoxScoreTeamsExplosiveness> explosiveness = default(List<BoxScoreTeamsExplosiveness>), List<BoxScoreTeamsRushing> rushing = default(List<BoxScoreTeamsRushing>), List<BoxScoreTeamsHavoc> havoc = default(List<BoxScoreTeamsHavoc>), List<BoxScoreTeamsScoringOpportunities> scoringOpportunities = default(List<BoxScoreTeamsScoringOpportunities>), List<BoxScoreTeamsFieldPosition> fieldPosition = default(List<BoxScoreTeamsFieldPosition>))
        {
            this.Ppa = ppa;
            this.SuccessRates = successRates;
            this.Explosiveness = explosiveness;
            this.Rushing = rushing;
            this.Havoc = havoc;
            this.ScoringOpportunities = scoringOpportunities;
            this.FieldPosition = fieldPosition;
        }
        
        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [DataMember(Name="ppa", EmitDefaultValue=false)]
        public List<BoxScoreTeamsPpa> Ppa { get; set; }

        /// <summary>
        /// Gets or Sets SuccessRates
        /// </summary>
        [DataMember(Name="successRates", EmitDefaultValue=false)]
        public List<BoxScoreTeamsSuccessRates> SuccessRates { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [DataMember(Name="explosiveness", EmitDefaultValue=false)]
        public List<BoxScoreTeamsExplosiveness> Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [DataMember(Name="rushing", EmitDefaultValue=false)]
        public List<BoxScoreTeamsRushing> Rushing { get; set; }

        /// <summary>
        /// Gets or Sets Havoc
        /// </summary>
        [DataMember(Name="havoc", EmitDefaultValue=false)]
        public List<BoxScoreTeamsHavoc> Havoc { get; set; }

        /// <summary>
        /// Gets or Sets ScoringOpportunities
        /// </summary>
        [DataMember(Name="scoringOpportunities", EmitDefaultValue=false)]
        public List<BoxScoreTeamsScoringOpportunities> ScoringOpportunities { get; set; }

        /// <summary>
        /// Gets or Sets FieldPosition
        /// </summary>
        [DataMember(Name="fieldPosition", EmitDefaultValue=false)]
        public List<BoxScoreTeamsFieldPosition> FieldPosition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxScoreTeams {\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
            sb.Append("  SuccessRates: ").Append(SuccessRates).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  Havoc: ").Append(Havoc).Append("\n");
            sb.Append("  ScoringOpportunities: ").Append(ScoringOpportunities).Append("\n");
            sb.Append("  FieldPosition: ").Append(FieldPosition).Append("\n");
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
            return this.Equals(input as BoxScoreTeams);
        }

        /// <summary>
        /// Returns true if BoxScoreTeams instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxScoreTeams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxScoreTeams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ppa == input.Ppa ||
                    this.Ppa != null &&
                    this.Ppa.SequenceEqual(input.Ppa)
                ) && 
                (
                    this.SuccessRates == input.SuccessRates ||
                    this.SuccessRates != null &&
                    this.SuccessRates.SequenceEqual(input.SuccessRates)
                ) && 
                (
                    this.Explosiveness == input.Explosiveness ||
                    this.Explosiveness != null &&
                    this.Explosiveness.SequenceEqual(input.Explosiveness)
                ) && 
                (
                    this.Rushing == input.Rushing ||
                    this.Rushing != null &&
                    this.Rushing.SequenceEqual(input.Rushing)
                ) && 
                (
                    this.Havoc == input.Havoc ||
                    this.Havoc != null &&
                    this.Havoc.SequenceEqual(input.Havoc)
                ) && 
                (
                    this.ScoringOpportunities == input.ScoringOpportunities ||
                    this.ScoringOpportunities != null &&
                    this.ScoringOpportunities.SequenceEqual(input.ScoringOpportunities)
                ) && 
                (
                    this.FieldPosition == input.FieldPosition ||
                    this.FieldPosition != null &&
                    this.FieldPosition.SequenceEqual(input.FieldPosition)
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
                if (this.Ppa != null)
                    hashCode = hashCode * 59 + this.Ppa.GetHashCode();
                if (this.SuccessRates != null)
                    hashCode = hashCode * 59 + this.SuccessRates.GetHashCode();
                if (this.Explosiveness != null)
                    hashCode = hashCode * 59 + this.Explosiveness.GetHashCode();
                if (this.Rushing != null)
                    hashCode = hashCode * 59 + this.Rushing.GetHashCode();
                if (this.Havoc != null)
                    hashCode = hashCode * 59 + this.Havoc.GetHashCode();
                if (this.ScoringOpportunities != null)
                    hashCode = hashCode * 59 + this.ScoringOpportunities.GetHashCode();
                if (this.FieldPosition != null)
                    hashCode = hashCode * 59 + this.FieldPosition.GetHashCode();
                return hashCode;
            }
        }
    }

}
