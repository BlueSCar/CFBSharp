/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.1.1
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
    /// Player
    /// </summary>
    [DataContract]
    public partial class Player :  IEquatable<Player>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="team">team.</param>
        /// <param name="height">height.</param>
        /// <param name="weight">weight.</param>
        /// <param name="jersey">jersey.</param>
        /// <param name="year">year.</param>
        /// <param name="position">position.</param>
        /// <param name="homeCity">homeCity.</param>
        /// <param name="homeState">homeState.</param>
        /// <param name="homeCountry">homeCountry.</param>
        /// <param name="homeLatitude">homeLatitude.</param>
        /// <param name="homeLongitude">homeLongitude.</param>
        /// <param name="homeCountyFips">homeCountyFips.</param>
        /// <param name="recruitIds">recruitIds.</param>
        public Player(int? id = default(int?), string firstName = default(string), string lastName = default(string), string team = default(string), int? height = default(int?), int? weight = default(int?), int? jersey = default(int?), int? year = default(int?), string position = default(string), string homeCity = default(string), string homeState = default(string), string homeCountry = default(string), decimal? homeLatitude = default(decimal?), decimal? homeLongitude = default(decimal?), string homeCountyFips = default(string), List<int?> recruitIds = default(List<int?>))
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Team = team;
            this.Height = height;
            this.Weight = weight;
            this.Jersey = jersey;
            this.Year = year;
            this.Position = position;
            this.HomeCity = homeCity;
            this.HomeState = homeState;
            this.HomeCountry = homeCountry;
            this.HomeLatitude = homeLatitude;
            this.HomeLongitude = homeLongitude;
            this.HomeCountyFips = homeCountyFips;
            this.RecruitIds = recruitIds;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or Sets Jersey
        /// </summary>
        [DataMember(Name="jersey", EmitDefaultValue=false)]
        public int? Jersey { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets HomeCity
        /// </summary>
        [DataMember(Name="home_city", EmitDefaultValue=false)]
        public string HomeCity { get; set; }

        /// <summary>
        /// Gets or Sets HomeState
        /// </summary>
        [DataMember(Name="home_state", EmitDefaultValue=false)]
        public string HomeState { get; set; }

        /// <summary>
        /// Gets or Sets HomeCountry
        /// </summary>
        [DataMember(Name="home_country", EmitDefaultValue=false)]
        public string HomeCountry { get; set; }

        /// <summary>
        /// Gets or Sets HomeLatitude
        /// </summary>
        [DataMember(Name="home_latitude", EmitDefaultValue=false)]
        public decimal? HomeLatitude { get; set; }

        /// <summary>
        /// Gets or Sets HomeLongitude
        /// </summary>
        [DataMember(Name="home_longitude", EmitDefaultValue=false)]
        public decimal? HomeLongitude { get; set; }

        /// <summary>
        /// Gets or Sets HomeCountyFips
        /// </summary>
        [DataMember(Name="home_county_fips", EmitDefaultValue=false)]
        public string HomeCountyFips { get; set; }

        /// <summary>
        /// Gets or Sets RecruitIds
        /// </summary>
        [DataMember(Name="recruit_ids", EmitDefaultValue=false)]
        public List<int?> RecruitIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Player {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Jersey: ").Append(Jersey).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  HomeCity: ").Append(HomeCity).Append("\n");
            sb.Append("  HomeState: ").Append(HomeState).Append("\n");
            sb.Append("  HomeCountry: ").Append(HomeCountry).Append("\n");
            sb.Append("  HomeLatitude: ").Append(HomeLatitude).Append("\n");
            sb.Append("  HomeLongitude: ").Append(HomeLongitude).Append("\n");
            sb.Append("  HomeCountyFips: ").Append(HomeCountyFips).Append("\n");
            sb.Append("  RecruitIds: ").Append(RecruitIds).Append("\n");
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
            return this.Equals(input as Player);
        }

        /// <summary>
        /// Returns true if Player instances are equal
        /// </summary>
        /// <param name="input">Instance of Player to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Player input)
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
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.Jersey == input.Jersey ||
                    (this.Jersey != null &&
                    this.Jersey.Equals(input.Jersey))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.HomeCity == input.HomeCity ||
                    (this.HomeCity != null &&
                    this.HomeCity.Equals(input.HomeCity))
                ) && 
                (
                    this.HomeState == input.HomeState ||
                    (this.HomeState != null &&
                    this.HomeState.Equals(input.HomeState))
                ) && 
                (
                    this.HomeCountry == input.HomeCountry ||
                    (this.HomeCountry != null &&
                    this.HomeCountry.Equals(input.HomeCountry))
                ) && 
                (
                    this.HomeLatitude == input.HomeLatitude ||
                    (this.HomeLatitude != null &&
                    this.HomeLatitude.Equals(input.HomeLatitude))
                ) && 
                (
                    this.HomeLongitude == input.HomeLongitude ||
                    (this.HomeLongitude != null &&
                    this.HomeLongitude.Equals(input.HomeLongitude))
                ) && 
                (
                    this.HomeCountyFips == input.HomeCountyFips ||
                    (this.HomeCountyFips != null &&
                    this.HomeCountyFips.Equals(input.HomeCountyFips))
                ) && 
                (
                    this.RecruitIds == input.RecruitIds ||
                    this.RecruitIds != null &&
                    this.RecruitIds.SequenceEqual(input.RecruitIds)
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Jersey != null)
                    hashCode = hashCode * 59 + this.Jersey.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.HomeCity != null)
                    hashCode = hashCode * 59 + this.HomeCity.GetHashCode();
                if (this.HomeState != null)
                    hashCode = hashCode * 59 + this.HomeState.GetHashCode();
                if (this.HomeCountry != null)
                    hashCode = hashCode * 59 + this.HomeCountry.GetHashCode();
                if (this.HomeLatitude != null)
                    hashCode = hashCode * 59 + this.HomeLatitude.GetHashCode();
                if (this.HomeLongitude != null)
                    hashCode = hashCode * 59 + this.HomeLongitude.GetHashCode();
                if (this.HomeCountyFips != null)
                    hashCode = hashCode * 59 + this.HomeCountyFips.GetHashCode();
                if (this.RecruitIds != null)
                    hashCode = hashCode * 59 + this.RecruitIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
