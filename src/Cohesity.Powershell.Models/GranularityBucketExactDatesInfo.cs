// Copyright 2019 Cohesity Inc.

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cohesity.Model
{
    /// <summary>
    /// GranularityBucketExactDatesInfo
    /// </summary>
    [DataContract]
    public partial class GranularityBucketExactDatesInfo :  IEquatable<GranularityBucketExactDatesInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GranularityBucketExactDatesInfo" /> class.
        /// </summary>
        /// <param name="datesVec">datesVec.</param>
        public GranularityBucketExactDatesInfo(List<DateTime> datesVec = default(List<DateTime>))
        {
            this.DatesVec = datesVec;
            this.DatesVec = datesVec;
        }
        
        /// <summary>
        /// Gets or Sets DatesVec
        /// </summary>
        [DataMember(Name="datesVec", EmitDefaultValue=true)]
        public List<DateTime> DatesVec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
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
            return this.Equals(input as GranularityBucketExactDatesInfo);
        }

        /// <summary>
        /// Returns true if GranularityBucketExactDatesInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GranularityBucketExactDatesInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GranularityBucketExactDatesInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatesVec == input.DatesVec ||
                    this.DatesVec != null &&
                    input.DatesVec != null &&
                    this.DatesVec.SequenceEqual(input.DatesVec)
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
                if (this.DatesVec != null)
                    hashCode = hashCode * 59 + this.DatesVec.GetHashCode();
                return hashCode;
            }
        }

    }

}

