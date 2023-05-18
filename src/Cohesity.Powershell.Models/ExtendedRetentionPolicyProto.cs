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
    /// Message that specifies additional retention policies to apply to backup snapshots.
    /// </summary>
    [DataContract]
    public partial class ExtendedRetentionPolicyProto :  IEquatable<ExtendedRetentionPolicyProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedRetentionPolicyProto" /> class.
        /// </summary>
        /// <param name="backupType">The backup type to which this extended retention applies to. If this is not set, the extended retention will be applicable to all non-log backup types.  Currently, the only value that can be set here is kFull (Magneto will return an error if it is set to anything else)..</param>
        /// <param name="copyPartiallySuccessfulRun">If this is false, then only snapshots from the first completely successful run in the given time granularity will be considered eligible for this extended retention policy. If this is true, then snapshots from the first partially successful run will also be considered eligible..</param>
        /// <param name="granularityBucket">granularityBucket.</param>
        /// <param name="id">This id uniquely identifies this entry in the ProtectionPolicyProto.  If this message is from global policy, this id is generated by Helios. Otherwise, it is generated by Iris. Magneto treats this as an opaque identifier..</param>
        /// <param name="retentionPolicy">retentionPolicy.</param>
        public ExtendedRetentionPolicyProto(int? backupType = default(int?), bool? copyPartiallySuccessfulRun = default(bool?), GranularityBucket granularityBucket = default(GranularityBucket), string id = default(string), RetentionPolicyProto retentionPolicy = default(RetentionPolicyProto))
        {
            this.BackupType = backupType;
            this.CopyPartiallySuccessfulRun = copyPartiallySuccessfulRun;
            this.Id = id;
            this.BackupType = backupType;
            this.CopyPartiallySuccessfulRun = copyPartiallySuccessfulRun;
            this.GranularityBucket = granularityBucket;
            this.Id = id;
            this.RetentionPolicy = retentionPolicy;
        }
        
        /// <summary>
        /// The backup type to which this extended retention applies to. If this is not set, the extended retention will be applicable to all non-log backup types.  Currently, the only value that can be set here is kFull (Magneto will return an error if it is set to anything else).
        /// </summary>
        /// <value>The backup type to which this extended retention applies to. If this is not set, the extended retention will be applicable to all non-log backup types.  Currently, the only value that can be set here is kFull (Magneto will return an error if it is set to anything else).</value>
        [DataMember(Name="backupType", EmitDefaultValue=true)]
        public int? BackupType { get; set; }

        /// <summary>
        /// If this is false, then only snapshots from the first completely successful run in the given time granularity will be considered eligible for this extended retention policy. If this is true, then snapshots from the first partially successful run will also be considered eligible.
        /// </summary>
        /// <value>If this is false, then only snapshots from the first completely successful run in the given time granularity will be considered eligible for this extended retention policy. If this is true, then snapshots from the first partially successful run will also be considered eligible.</value>
        [DataMember(Name="copyPartiallySuccessfulRun", EmitDefaultValue=true)]
        public bool? CopyPartiallySuccessfulRun { get; set; }

        /// <summary>
        /// Gets or Sets GranularityBucket
        /// </summary>
        [DataMember(Name="granularityBucket", EmitDefaultValue=false)]
        public GranularityBucket GranularityBucket { get; set; }

        /// <summary>
        /// This id uniquely identifies this entry in the ProtectionPolicyProto.  If this message is from global policy, this id is generated by Helios. Otherwise, it is generated by Iris. Magneto treats this as an opaque identifier.
        /// </summary>
        /// <value>This id uniquely identifies this entry in the ProtectionPolicyProto.  If this message is from global policy, this id is generated by Helios. Otherwise, it is generated by Iris. Magneto treats this as an opaque identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets RetentionPolicy
        /// </summary>
        [DataMember(Name="retentionPolicy", EmitDefaultValue=false)]
        public RetentionPolicyProto RetentionPolicy { get; set; }

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
            return this.Equals(input as ExtendedRetentionPolicyProto);
        }

        /// <summary>
        /// Returns true if ExtendedRetentionPolicyProto instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtendedRetentionPolicyProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtendedRetentionPolicyProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupType == input.BackupType ||
                    (this.BackupType != null &&
                    this.BackupType.Equals(input.BackupType))
                ) && 
                (
                    this.CopyPartiallySuccessfulRun == input.CopyPartiallySuccessfulRun ||
                    (this.CopyPartiallySuccessfulRun != null &&
                    this.CopyPartiallySuccessfulRun.Equals(input.CopyPartiallySuccessfulRun))
                ) && 
                (
                    this.GranularityBucket == input.GranularityBucket ||
                    (this.GranularityBucket != null &&
                    this.GranularityBucket.Equals(input.GranularityBucket))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RetentionPolicy == input.RetentionPolicy ||
                    (this.RetentionPolicy != null &&
                    this.RetentionPolicy.Equals(input.RetentionPolicy))
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
                if (this.BackupType != null)
                    hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.CopyPartiallySuccessfulRun != null)
                    hashCode = hashCode * 59 + this.CopyPartiallySuccessfulRun.GetHashCode();
                if (this.GranularityBucket != null)
                    hashCode = hashCode * 59 + this.GranularityBucket.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RetentionPolicy != null)
                    hashCode = hashCode * 59 + this.RetentionPolicy.GetHashCode();
                return hashCode;
            }
        }

    }

}

