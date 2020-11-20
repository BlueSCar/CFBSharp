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
    /// TeamRecord
    /// </summary>
    [DataContract]
    public partial class TeamRecord :  IEquatable<TeamRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRecord" /> class.
        /// </summary>
        /// <param name="year">year.</param>
        /// <param name="team">team.</param>
        /// <param name="conference">conference.</param>
        /// <param name="division">division.</param>
        /// <param name="total">total.</param>
        /// <param name="conferenceGames">conferenceGames.</param>
        /// <param name="homeGames">homeGames.</param>
        /// <param name="awayGames">awayGames.</param>
        public TeamRecord(int? year = default(int?), string team = default(string), string conference = default(string), string division = default(string), TeamRecordTotal total = default(TeamRecordTotal), TeamRecordTotal conferenceGames = default(TeamRecordTotal), TeamRecordTotal homeGames = default(TeamRecordTotal), TeamRecordTotal awayGames = default(TeamRecordTotal))
        {
            this.Year = year;
            this.Team = team;
            this.Conference = conference;
            this.Division = division;
            this.Total = total;
            this.ConferenceGames = conferenceGames;
            this.HomeGames = homeGames;
            this.AwayGames = awayGames;
        }
        
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name="conference", EmitDefaultValue=false)]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public string Division { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public TeamRecordTotal Total { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceGames
        /// </summary>
        [DataMember(Name="conferenceGames", EmitDefaultValue=false)]
        public TeamRecordTotal ConferenceGames { get; set; }

        /// <summary>
        /// Gets or Sets HomeGames
        /// </summary>
        [DataMember(Name="homeGames", EmitDefaultValue=false)]
        public TeamRecordTotal HomeGames { get; set; }

        /// <summary>
        /// Gets or Sets AwayGames
        /// </summary>
        [DataMember(Name="awayGames", EmitDefaultValue=false)]
        public TeamRecordTotal AwayGames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamRecord {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  ConferenceGames: ").Append(ConferenceGames).Append("\n");
            sb.Append("  HomeGames: ").Append(HomeGames).Append("\n");
            sb.Append("  AwayGames: ").Append(AwayGames).Append("\n");
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
            return this.Equals(input as TeamRecord);
        }

        /// <summary>
        /// Returns true if TeamRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Conference == input.Conference ||
                    (this.Conference != null &&
                    this.Conference.Equals(input.Conference))
                ) && 
                (
                    this.Division == input.Division ||
                    (this.Division != null &&
                    this.Division.Equals(input.Division))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.ConferenceGames == input.ConferenceGames ||
                    (this.ConferenceGames != null &&
                    this.ConferenceGames.Equals(input.ConferenceGames))
                ) && 
                (
                    this.HomeGames == input.HomeGames ||
                    (this.HomeGames != null &&
                    this.HomeGames.Equals(input.HomeGames))
                ) && 
                (
                    this.AwayGames == input.AwayGames ||
                    (this.AwayGames != null &&
                    this.AwayGames.Equals(input.AwayGames))
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
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.Division != null)
                    hashCode = hashCode * 59 + this.Division.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.ConferenceGames != null)
                    hashCode = hashCode * 59 + this.ConferenceGames.GetHashCode();
                if (this.HomeGames != null)
                    hashCode = hashCode * 59 + this.HomeGames.GetHashCode();
                if (this.AwayGames != null)
                    hashCode = hashCode * 59 + this.AwayGames.GetHashCode();
                return hashCode;
            }
        }
    }

}
