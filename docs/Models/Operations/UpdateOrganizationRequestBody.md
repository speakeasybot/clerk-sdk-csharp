# UpdateOrganizationRequestBody


## Fields

| Field                                                                                                                           | Type                                                                                                                            | Required                                                                                                                        | Description                                                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- |
| `PublicMetadata`                                                                                                                | [UpdateOrganizationPublicMetadata](../../Models/Operations/UpdateOrganizationPublicMetadata.md)                                 | :heavy_minus_sign:                                                                                                              | Metadata saved on the organization, that is visible to both your frontend and backend.                                          |
| `PrivateMetadata`                                                                                                               | [UpdateOrganizationPrivateMetadata](../../Models/Operations/UpdateOrganizationPrivateMetadata.md)                               | :heavy_minus_sign:                                                                                                              | Metadata saved on the organization that is only visible to your backend.                                                        |
| `Name`                                                                                                                          | *string*                                                                                                                        | :heavy_minus_sign:                                                                                                              | The new name of the organization.<br/>May not contain URLs or HTML.                                                             |
| `Slug`                                                                                                                          | *string*                                                                                                                        | :heavy_minus_sign:                                                                                                              | The new slug of the organization, which needs to be unique in the instance                                                      |
| `MaxAllowedMemberships`                                                                                                         | *long*                                                                                                                          | :heavy_minus_sign:                                                                                                              | The maximum number of memberships allowed for this organization                                                                 |
| `AdminDeleteEnabled`                                                                                                            | *bool*                                                                                                                          | :heavy_minus_sign:                                                                                                              | If true, an admin can delete this organization with the Frontend API.                                                           |
| `CreatedAt`                                                                                                                     | *string*                                                                                                                        | :heavy_minus_sign:                                                                                                              | A custom date/time denoting _when_ the organization was created, specified in RFC3339 format (e.g. `2012-10-20T07:15:20.902Z`). |