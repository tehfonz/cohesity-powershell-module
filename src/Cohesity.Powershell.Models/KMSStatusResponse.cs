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
    /// KMSStatusResponse
    /// </summary>
    [DataContract]
    public partial class KMSStatusResponse :  IEquatable<KMSStatusResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KMSStatusResponse" /> class.
        /// </summary>
        /// <param name="status">Specifies the status of the kms server. If true, indicates KMS sever is reachable..</param>
        public KMSStatusResponse(bool? status = default(bool?))
        {
            this.Status = status;
            this.Status = status;
        }
        
        /// <summary>
        /// Specifies the status of the kms server. If true, indicates KMS sever is reachable.
        /// </summary>
        /// <value>Specifies the status of the kms server. If true, indicates KMS sever is reachable.</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public bool? Status { get; set; }

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
            return this.Equals(input as KMSStatusResponse);
        }

        /// <summary>
        /// Returns true if KMSStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KMSStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KMSStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }

}

