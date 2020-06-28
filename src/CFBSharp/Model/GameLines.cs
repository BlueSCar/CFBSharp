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
    /// GameLines
    /// </summary>
    [DataContract]
    public partial class GameLines :  IEquatable<GameLines>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameLines" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="season">season.</param>
        /// <param name="week">week.</param>
        /// <param name="seasonType">seasonType.</param>
        /// <param name="homeTeam">homeTeam.</param>
        /// <param name="homeConference">homeConference.</param>
        /// <param name="homeScore">homeScore.</param>
        /// <param name="awayTeam">awayTeam.</param>
        /// <param name="awayConference">awayConference.</param>
        /// <param name="awayScore">awayScore.</param>
        /// <param name="lines">lines.</param>
        public GameLines(int? id = default(int?), int? season = default(int?), int? week = default(int?), string seasonType = default(string), string homeTeam = default(string), string homeConference = default(string), int? homeScore = default(int?), string awayTeam = default(string), string awayConference = default(string), int? awayScore = default(int?), List<GameLinesLines> lines = default(List<GameLinesLines>))
        {
            this.Id = id;
            this.Season = season;
            this.Week = week;
            this.SeasonType = seasonType;
            this.HomeTeam = homeTeam;
            this.HomeConference = homeConference;
            this.HomeScore = homeScore;
            this.AwayTeam = awayTeam;
            this.AwayConference = awayConference;
            this.AwayScore = awayScore;
            this.Lines = lines;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public int? Week { get; set; }

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [DataMember(Name="seasonType", EmitDefaultValue=false)]
        public string SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name="homeTeam", EmitDefaultValue=false)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets HomeConference
        /// </summary>
        [DataMember(Name="homeConference", EmitDefaultValue=false)]
        public string HomeConference { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [DataMember(Name="homeScore", EmitDefaultValue=false)]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name="awayTeam", EmitDefaultValue=false)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayConference
        /// </summary>
        [DataMember(Name="awayConference", EmitDefaultValue=false)]
        public string AwayConference { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [DataMember(Name="awayScore", EmitDefaultValue=false)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="lines", EmitDefaultValue=false)]
        public List<GameLinesLines> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameLines {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  HomeConference: ").Append(HomeConference).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  AwayConference: ").Append(AwayConference).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
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
            return this.Equals(input as GameLines);
        }

        /// <summary>
        /// Returns true if GameLines instances are equal
        /// </summary>
        /// <param name="input">Instance of GameLines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameLines input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
                (
                    this.Week == input.Week ||
                    (this.Week != null &&
                    this.Week.Equals(input.Week))
                ) && 
                (
                    this.SeasonType == input.SeasonType ||
                    (this.SeasonType != null &&
                    this.SeasonType.Equals(input.SeasonType))
                ) && 
                (
                    this.HomeTeam == input.HomeTeam ||
                    (this.HomeTeam != null &&
                    this.HomeTeam.Equals(input.HomeTeam))
                ) && 
                (
                    this.HomeConference == input.HomeConference ||
                    (this.HomeConference != null &&
                    this.HomeConference.Equals(input.HomeConference))
                ) && 
                (
                    this.HomeScore == input.HomeScore ||
                    (this.HomeScore != null &&
                    this.HomeScore.Equals(input.HomeScore))
                ) && 
                (
                    this.AwayTeam == input.AwayTeam ||
                    (this.AwayTeam != null &&
                    this.AwayTeam.Equals(input.AwayTeam))
                ) && 
                (
                    this.AwayConference == input.AwayConference ||
                    (this.AwayConference != null &&
                    this.AwayConference.Equals(input.AwayConference))
                ) && 
                (
                    this.AwayScore == input.AwayScore ||
                    (this.AwayScore != null &&
                    this.AwayScore.Equals(input.AwayScore))
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
                if (this.SeasonType != null)
                    hashCode = hashCode * 59 + this.SeasonType.GetHashCode();
                if (this.HomeTeam != null)
                    hashCode = hashCode * 59 + this.HomeTeam.GetHashCode();
                if (this.HomeConference != null)
                    hashCode = hashCode * 59 + this.HomeConference.GetHashCode();
                if (this.HomeScore != null)
                    hashCode = hashCode * 59 + this.HomeScore.GetHashCode();
                if (this.AwayTeam != null)
                    hashCode = hashCode * 59 + this.AwayTeam.GetHashCode();
                if (this.AwayConference != null)
                    hashCode = hashCode * 59 + this.AwayConference.GetHashCode();
                if (this.AwayScore != null)
                    hashCode = hashCode * 59 + this.AwayScore.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                return hashCode;
            }
        }
    }

}
