using OnlineMuhasebeServer.Domain.Abstractions;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMuhasebeServer.Domain.AppEntities;

public sealed class MainRoleAndUserRelationship : Entity
{
    public MainRoleAndUserRelationship()
    {
        
    }

    public MainRoleAndUserRelationship(string userId, string mainRoleId, string companyId, string Id):base(Id)
    {
        UserId = userId;
        MainRoleId = mainRoleId;
        CompanyId = companyId;
    }



    [ForeignKey("AppUser")]
    public string UserId { get; set; }
    public AppUser AppUser { get; set; }

    [ForeignKey("MainRole")]
    public string MainRoleId { get; set; }
    public MainRole MainRole { get; set; }

    [ForeignKey("Company")]
    public string CompanyId { get; set; }
    public Company Company { get; set; }
}
