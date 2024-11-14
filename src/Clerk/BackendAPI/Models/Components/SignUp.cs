//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI.Models.Components
{
    using Clerk.BackendAPI.Models.Components;
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// Success
    /// </summary>
    public class SignUp
    {

        [JsonProperty("object")]
        public SignUpObject Object { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("status")]
        public SignUpStatus Status { get; set; } = default!;

        [JsonProperty("required_fields")]
        public List<string>? RequiredFields { get; set; }

        [JsonProperty("optional_fields")]
        public List<string>? OptionalFields { get; set; }

        [JsonProperty("missing_fields")]
        public List<string>? MissingFields { get; set; }

        [JsonProperty("unverified_fields")]
        public List<string>? UnverifiedFields { get; set; }

        [JsonProperty("verifications")]
        public Verifications? Verifications { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; } = null;

        [JsonProperty("email_address")]
        public string? EmailAddress { get; set; } = null;

        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; } = null;

        [JsonProperty("web3_wallet")]
        public string? Web3Wallet { get; set; } = null;

        [JsonProperty("password_enabled")]
        public bool PasswordEnabled { get; set; } = default!;

        [JsonProperty("first_name")]
        public string? FirstName { get; set; } = null;

        [JsonProperty("last_name")]
        public string? LastName { get; set; } = null;

        [JsonProperty("unsafe_metadata")]
        public Dictionary<string, object>? UnsafeMetadata { get; set; }

        [JsonProperty("public_metadata")]
        public Dictionary<string, object>? PublicMetadata { get; set; }

        [JsonProperty("custom_action")]
        public bool CustomAction { get; set; } = default!;

        [JsonProperty("external_id")]
        public string? ExternalId { get; set; } = null;

        [JsonProperty("created_session_id")]
        public string? CreatedSessionId { get; set; } = null;

        [JsonProperty("created_user_id")]
        public string? CreatedUserId { get; set; } = null;

        [JsonProperty("abandon_at")]
        public long AbandonAt { get; set; } = default!;

        [JsonProperty("external_account")]
        public ExternalAccount? ExternalAccount { get; set; }
    }
}