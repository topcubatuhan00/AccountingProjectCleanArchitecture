using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Domain.Roles;

public sealed class RoleList
{
    public static List<AppRole> GetStaticRoles()
    {
        List<AppRole> roles = new List<AppRole>()
        {
            #region UCAF
            new AppRole(
            title: UCAF,
            code: UCAFCreateCode,
            name: UCAFCreateName
            ),

            new AppRole(
            title: UCAF,
            code: UCAFUpdateCode,
            name: UCAFUpdateName
            ),

            new AppRole(
            title: UCAF,
            code: UCAFDeleteCode,
            name: UCAFDeleteName
            ),

            new AppRole(
            title: UCAF,
            code: UCAFReadCode,
            name: UCAFReadName
            ),
            #endregion
        };

        return roles;
    }

    #region RoleCodeAndNames
    public static string UCAFCreateCode = "UCAF.Create";
    public static string UCAFCreateName = "Hesap planı kayıt.";

    public static string UCAFUpdateCode = "UCAF.Update";
    public static string UCAFUpdateName = "Hesap planı güncelle.";

    public static string UCAFDeleteCode = "UCAF.Delete";
    public static string UCAFDeleteName = "Hesap planı sil.";

    public static string UCAFReadCode = "UCAF.Read";
    public static string UCAFReadName = "Hesap planı oku.";
    #endregion

    #region RoleTitleNames
    public static string UCAF = "Hesap Planı";
    #endregion
}
