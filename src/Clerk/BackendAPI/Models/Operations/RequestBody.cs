//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI.Models.Operations
{
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class RequestBody
    {

        /// <summary>
        /// The email address of the new member that is going to be invited to the organization
        /// </summary>
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; } = default!;

        /// <summary>
        /// The ID of the user that invites the new member to the organization.<br/>
        /// 
        /// <remarks>
        /// Must be an administrator in the organization.
        /// </remarks>
        /// </summary>
        [JsonProperty("inviter_user_id")]
        public string? InviterUserId { get; set; } = null;

        /// <summary>
        /// The role of the new member in the organization.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Metadata saved on the organization invitation, read-only from the Frontend API and fully accessible (read/write) from the Backend API.
        /// </summary>
        [JsonProperty("public_metadata")]
        public Dictionary<string, object>? PublicMetadata { get; set; }

        /// <summary>
        /// Metadata saved on the organization invitation, fully accessible (read/write) from the Backend API but not visible from the Frontend API.
        /// </summary>
        [JsonProperty("private_metadata")]
        public Dictionary<string, object>? PrivateMetadata { get; set; }

        /// <summary>
        /// Optional URL that the invitee will be redirected to once they accept the invitation by clicking the join link in the invitation email.
        /// </summary>
        [JsonProperty("redirect_url")]
        public string? RedirectUrl { get; set; }
    }
}