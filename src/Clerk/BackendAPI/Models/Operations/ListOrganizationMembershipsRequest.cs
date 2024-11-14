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
    
    public class ListOrganizationMembershipsRequest
    {

        /// <summary>
        /// The organization ID.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=organization_id")]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// Applies a limit to the number of results returned.<br/>
        /// 
        /// <remarks>
        /// Can be used for paginating the results together with `offset`.
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public long? Limit { get; set; } = 10;

        /// <summary>
        /// Skip the first `offset` results when paginating.<br/>
        /// 
        /// <remarks>
        /// Needs to be an integer greater or equal to zero.<br/>
        /// To be used in conjunction with `limit`.
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=offset")]
        public long? Offset { get; set; } = 0;

        /// <summary>
        /// Sorts organizations memberships by phone_number, email_address, created_at, first_name, last_name or username.<br/>
        /// 
        /// <remarks>
        /// By prepending one of those values with + or -,<br/>
        /// we can choose to sort in ascending (ASC) or descending (DESC) order.&quot;
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=order_by")]
        public string? OrderBy { get; set; }
    }
}