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
    /// BoxScorePlayers
    /// </summary>
    [DataContract]
    public partial class BoxScorePlayers :  IEquatable<BoxScorePlayers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxScorePlayers" /> class.
        /// </summary>
        /// <param name="usage">usage.</param>
        /// <param name="ppa">ppa.</param>
        public BoxScorePlayers(List<BoxScorePlayersUsage> usage = default(List<BoxScorePlayersUsage>), List<BoxScorePlayersPpa> ppa = default(List<BoxScorePlayersPpa>))
        {
            this.Usage = usage;
            this.Ppa = ppa;
        }
        
        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        public List<BoxScorePlayersUsage> Usage { get; set; }

        /// <summary>
        /// Gets or Sets Ppa
        /// </summary>
        [DataMember(Name="ppa", EmitDefaultValue=false)]
        public List<BoxScorePlayersPpa> Ppa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxScorePlayers {\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  Ppa: ").Append(Ppa).Append("\n");
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
            return this.Equals(input as BoxScorePlayers);
        }

        /// <summary>
        /// Returns true if BoxScorePlayers instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxScorePlayers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxScorePlayers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Usage == input.Usage ||
                    this.Usage != null &&
                    this.Usage.SequenceEqual(input.Usage)
                ) && 
                (
                    this.Ppa == input.Ppa ||
                    this.Ppa != null &&
                    this.Ppa.SequenceEqual(input.Ppa)
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
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.Ppa != null)
                    hashCode = hashCode * 59 + this.Ppa.GetHashCode();
                return hashCode;
            }
        }
    }

}
