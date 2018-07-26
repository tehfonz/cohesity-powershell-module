﻿using System.Management.Automation;

namespace Cohesity.ProtectionJobs
{
    /// <summary>
    /// <para type="synopsis">
    /// Delete a Protection Job.
    /// </para>
    /// <para type="description">
    /// Returns Success if the Protection Job is deleted.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>C:PS&gt;</para>
    ///   <code>
    ///   Remove-CohesityProtectionJob -ID 1234
    ///   </code>
    ///   <para>
    ///   Deletes a Protection Job with the ID of 1234 and all Snapshots generated by the Protection Job.
    ///   </para>
    /// </example>
    /// <example>
    ///   <para>C:PS&gt;</para>
    ///   <code>
    ///   Remove-CohesityProtectionJob -ID 1234 -DeleteSnapshots false
    ///   </code>
    ///   <para>
    ///   Deletes a Protection Job with the ID of 1234 only, Snapshots generated by the Protection Job will not be deleted.
    ///   </para>
    /// </example>
    [Cmdlet("Remove", "CohesityProtectionJob")]
    public class DeleteProtectionJob : PSCmdlet
    {
        private Session Session
        {
            get
            {
                var result = SessionState.PSVariable.GetValue("Session") as Session;
                if (result == null)
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        #region Params

        /// <summary>
        /// <para type="description">
        /// Specifies a unique id of the Protection Job.
        /// </para>
        /// </summary>
        [Parameter(Position = 1, Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies if Snapshots generated by the Protection Job should also be deleted when the Job is deleted.
        /// Default value is true.
        /// </para>
        /// </summary>
        [Parameter(Position = 2, Mandatory = false)]
        public bool DeleteSnapshots { get; set; } = true;

        #endregion

        #region Processing

        /// <summary>
        /// Preprocess
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();

            if (Id <= 0)
            {
                throw new ParameterBindingException($"Parameter {nameof(Id)} must be greater than zero.");
            }
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            // POST /public/protectionJobState/{id}
            var content = new {
                DeleteSnapshots
            };

            var preparedUrl = $"{Session.NetworkClient.BaseUri.AbsoluteUri}/public/protectionJobs/{Id.ToString()}";
            Session.NetworkClient.Delete(preparedUrl, content);
            WriteObject("Protection Job has been deleted.");
        }

        #endregion
    }
}
