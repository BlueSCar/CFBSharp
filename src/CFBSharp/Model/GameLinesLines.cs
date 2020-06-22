/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.0.1
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
    /// GameLinesLines
    /// </summary>
    [DataContract]
    public partial class GameLinesLines :  IEquatable<GameLinesLines>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameLinesLines" /> class.
        /// </summary>
        /// <param name="provider">provider.</param>
        /// <param name="spread">spread.</param>
        /// <param name="formattedSpread">formattedSpread.</param>
        /// <param name="overUnder">overUnder.</param>
        public GameLinesLines(string provider = default(string), decimal? spread = default(decimal?), string formattedSpread = default(string), decimal? overUnder = default(decimal?))
        {
            this.Provider = provider;
            this.Spread = spread;
            this.FormattedSpread = formattedSpread;
            this.OverUnder = overUnder;
        }
        
        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or Sets Spread
        /// </summary>
        [DataMember(Name="spread", EmitDefaultValue=false)]
        public decimal? Spread { get; set; }

        /// <summary>
        /// Gets or Sets FormattedSpread
        /// </summary>
        [DataMember(Name="formattedSpread", EmitDefaultValue=false)]
        public string FormattedSpread { get; set; }

        /// <summary>
        /// Gets or Sets OverUnder
        /// </summary>
        [DataMember(Name="overUnder", EmitDefaultValue=false)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameLinesLines {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Spread: ").Append(Spread).Append("\n");
            sb.Append("  FormattedSpread: ").Append(FormattedSpread).Append("\n");
            sb.Append("  OverUnder: ").Append(OverUnder).Append("\n");
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
            return this.Equals(input as GameLinesLines);
        }

        /// <summary>
        /// Returns true if GameLinesLines instances are equal
        /// </summary>
        /// <param name="input">Instance of GameLinesLines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameLinesLines input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Spread == input.Spread ||
                    (this.Spread != null &&
                    this.Spread.Equals(input.Spread))
                ) && 
                (
                    this.FormattedSpread == input.FormattedSpread ||
                    (this.FormattedSpread != null &&
                    this.FormattedSpread.Equals(input.FormattedSpread))
                ) && 
                (
                    this.OverUnder == input.OverUnder ||
                    (this.OverUnder != null &&
                    this.OverUnder.Equals(input.OverUnder))
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
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Spread != null)
                    hashCode = hashCode * 59 + this.Spread.GetHashCode();
                if (this.FormattedSpread != null)
                    hashCode = hashCode * 59 + this.FormattedSpread.GetHashCode();
                if (this.OverUnder != null)
                    hashCode = hashCode * 59 + this.OverUnder.GetHashCode();
                return hashCode;
            }
        }
    }

}
