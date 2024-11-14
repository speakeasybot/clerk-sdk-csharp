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
    using Clerk.BackendAPI.Models.Operations;
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class ResponseBody
    {

        [JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// External account ID
        /// </summary>
        [JsonProperty("external_account_id")]
        public string? ExternalAccountId { get; set; }

        /// <summary>
        /// The unique ID of the user in the external provider&apos;s system
        /// </summary>
        [JsonProperty("provider_user_id")]
        public string? ProviderUserId { get; set; }

        /// <summary>
        /// The access token
        /// </summary>
        [JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// The ID of the provider
        /// </summary>
        [JsonProperty("provider")]
        public string? Provider { get; set; }

        [JsonProperty("public_metadata")]
        public GetOAuthAccessTokenPublicMetadata? PublicMetadata { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; } = null;

        /// <summary>
        /// The list of scopes that the token is valid for.<br/>
        /// 
        /// <remarks>
        /// Only present for OAuth 2.0 tokens.
        /// </remarks>
        /// </summary>
        [JsonProperty("scopes")]
        public List<string>? Scopes { get; set; }

        /// <summary>
        /// The token secret. Only present for OAuth 1.0 tokens.
        /// </summary>
        [JsonProperty("token_secret")]
        public string? TokenSecret { get; set; }
    }
}