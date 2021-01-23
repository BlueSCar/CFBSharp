/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.3.5
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
    /// PlayStat
    /// </summary>
    [DataContract]
    public partial class PlayStat :  IEquatable<PlayStat>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayStat" /> class.
        /// </summary>
        /// <param name="gameId">gameId.</param>
        /// <param name="season">season.</param>
        /// <param name="week">week.</param>
        /// <param name="team">team.</param>
        /// <param name="conference">conference.</param>
        /// <param name="opponent">opponent.</param>
        /// <param name="teamScore">teamScore.</param>
        /// <param name="opponentScore">opponentScore.</param>
        /// <param name="driveId">driveId.</param>
        /// <param name="playId">playId.</param>
        /// <param name="period">period.</param>
        /// <param name="clock">clock.</param>
        /// <param name="yardsToGoal">yardsToGoal.</param>
        /// <param name="down">down.</param>
        /// <param name="distance">distance.</param>
        /// <param name="athleteId">athleteId.</param>
        /// <param name="athleteName">athleteName.</param>
        /// <param name="statType">statType.</param>
        /// <param name="stat">stat.</param>
        public PlayStat(int? gameId = default(int?), int? season = default(int?), int? week = default(int?), string team = default(string), string conference = default(string), string opponent = default(string), int? teamScore = default(int?), int? opponentScore = default(int?), int? driveId = default(int?), int? playId = default(int?), int? period = default(int?), DriveStartTime clock = default(DriveStartTime), int? yardsToGoal = default(int?), int? down = default(int?), int? distance = default(int?), int? athleteId = default(int?), string athleteName = default(string), string statType = default(string), int? stat = default(int?))
        {
            this.GameId = gameId;
            this.Season = season;
            this.Week = week;
            this.Team = team;
            this.Conference = conference;
            this.Opponent = opponent;
            this.TeamScore = teamScore;
            this.OpponentScore = opponentScore;
            this.DriveId = driveId;
            this.PlayId = playId;
            this.Period = period;
            this.Clock = clock;
            this.YardsToGoal = yardsToGoal;
            this.Down = down;
            this.Distance = distance;
            this.AthleteId = athleteId;
            this.AthleteName = athleteName;
            this.StatType = statType;
            this.Stat = stat;
        }
        
        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public int? GameId { get; set; }

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
        /// Gets or Sets Opponent
        /// </summary>
        [DataMember(Name="opponent", EmitDefaultValue=false)]
        public string Opponent { get; set; }

        /// <summary>
        /// Gets or Sets TeamScore
        /// </summary>
        [DataMember(Name="teamScore", EmitDefaultValue=false)]
        public int? TeamScore { get; set; }

        /// <summary>
        /// Gets or Sets OpponentScore
        /// </summary>
        [DataMember(Name="opponentScore", EmitDefaultValue=false)]
        public int? OpponentScore { get; set; }

        /// <summary>
        /// Gets or Sets DriveId
        /// </summary>
        [DataMember(Name="driveId", EmitDefaultValue=false)]
        public int? DriveId { get; set; }

        /// <summary>
        /// Gets or Sets PlayId
        /// </summary>
        [DataMember(Name="playId", EmitDefaultValue=false)]
        public int? PlayId { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }

        /// <summary>
        /// Gets or Sets Clock
        /// </summary>
        [DataMember(Name="clock", EmitDefaultValue=false)]
        public DriveStartTime Clock { get; set; }

        /// <summary>
        /// Gets or Sets YardsToGoal
        /// </summary>
        [DataMember(Name="yardsToGoal", EmitDefaultValue=false)]
        public int? YardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets Down
        /// </summary>
        [DataMember(Name="down", EmitDefaultValue=false)]
        public int? Down { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public int? Distance { get; set; }

        /// <summary>
        /// Gets or Sets AthleteId
        /// </summary>
        [DataMember(Name="athleteId", EmitDefaultValue=false)]
        public int? AthleteId { get; set; }

        /// <summary>
        /// Gets or Sets AthleteName
        /// </summary>
        [DataMember(Name="athleteName", EmitDefaultValue=false)]
        public string AthleteName { get; set; }

        /// <summary>
        /// Gets or Sets StatType
        /// </summary>
        [DataMember(Name="statType", EmitDefaultValue=false)]
        public string StatType { get; set; }

        /// <summary>
        /// Gets or Sets Stat
        /// </summary>
        [DataMember(Name="stat", EmitDefaultValue=false)]
        public int? Stat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayStat {\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  Opponent: ").Append(Opponent).Append("\n");
            sb.Append("  TeamScore: ").Append(TeamScore).Append("\n");
            sb.Append("  OpponentScore: ").Append(OpponentScore).Append("\n");
            sb.Append("  DriveId: ").Append(DriveId).Append("\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Clock: ").Append(Clock).Append("\n");
            sb.Append("  YardsToGoal: ").Append(YardsToGoal).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  AthleteId: ").Append(AthleteId).Append("\n");
            sb.Append("  AthleteName: ").Append(AthleteName).Append("\n");
            sb.Append("  StatType: ").Append(StatType).Append("\n");
            sb.Append("  Stat: ").Append(Stat).Append("\n");
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
            return this.Equals(input as PlayStat);
        }

        /// <summary>
        /// Returns true if PlayStat instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayStat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
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
                    this.Opponent == input.Opponent ||
                    (this.Opponent != null &&
                    this.Opponent.Equals(input.Opponent))
                ) && 
                (
                    this.TeamScore == input.TeamScore ||
                    (this.TeamScore != null &&
                    this.TeamScore.Equals(input.TeamScore))
                ) && 
                (
                    this.OpponentScore == input.OpponentScore ||
                    (this.OpponentScore != null &&
                    this.OpponentScore.Equals(input.OpponentScore))
                ) && 
                (
                    this.DriveId == input.DriveId ||
                    (this.DriveId != null &&
                    this.DriveId.Equals(input.DriveId))
                ) && 
                (
                    this.PlayId == input.PlayId ||
                    (this.PlayId != null &&
                    this.PlayId.Equals(input.PlayId))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Clock == input.Clock ||
                    (this.Clock != null &&
                    this.Clock.Equals(input.Clock))
                ) && 
                (
                    this.YardsToGoal == input.YardsToGoal ||
                    (this.YardsToGoal != null &&
                    this.YardsToGoal.Equals(input.YardsToGoal))
                ) && 
                (
                    this.Down == input.Down ||
                    (this.Down != null &&
                    this.Down.Equals(input.Down))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.AthleteId == input.AthleteId ||
                    (this.AthleteId != null &&
                    this.AthleteId.Equals(input.AthleteId))
                ) && 
                (
                    this.AthleteName == input.AthleteName ||
                    (this.AthleteName != null &&
                    this.AthleteName.Equals(input.AthleteName))
                ) && 
                (
                    this.StatType == input.StatType ||
                    (this.StatType != null &&
                    this.StatType.Equals(input.StatType))
                ) && 
                (
                    this.Stat == input.Stat ||
                    (this.Stat != null &&
                    this.Stat.Equals(input.Stat))
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
                if (this.GameId != null)
                    hashCode = hashCode * 59 + this.GameId.GetHashCode();
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.Opponent != null)
                    hashCode = hashCode * 59 + this.Opponent.GetHashCode();
                if (this.TeamScore != null)
                    hashCode = hashCode * 59 + this.TeamScore.GetHashCode();
                if (this.OpponentScore != null)
                    hashCode = hashCode * 59 + this.OpponentScore.GetHashCode();
                if (this.DriveId != null)
                    hashCode = hashCode * 59 + this.DriveId.GetHashCode();
                if (this.PlayId != null)
                    hashCode = hashCode * 59 + this.PlayId.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Clock != null)
                    hashCode = hashCode * 59 + this.Clock.GetHashCode();
                if (this.YardsToGoal != null)
                    hashCode = hashCode * 59 + this.YardsToGoal.GetHashCode();
                if (this.Down != null)
                    hashCode = hashCode * 59 + this.Down.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.AthleteId != null)
                    hashCode = hashCode * 59 + this.AthleteId.GetHashCode();
                if (this.AthleteName != null)
                    hashCode = hashCode * 59 + this.AthleteName.GetHashCode();
                if (this.StatType != null)
                    hashCode = hashCode * 59 + this.StatType.GetHashCode();
                if (this.Stat != null)
                    hashCode = hashCode * 59 + this.Stat.GetHashCode();
                return hashCode;
            }
        }
    }

}
