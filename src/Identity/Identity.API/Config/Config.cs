
using IdentityServer4.Models;

namespace Identity.API.Config
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIndentityResource(){
            return new IdentityResource[]{
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        public static IEnumerable<ApiResource> GetApis(){
            return new []{
                new ApiResource{
                    Name= "exam_api",
                    DisplayName= "Exam API"
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScope(){
            return new List<ApiScope>{
                new ApiScope("full_access")
            };
        }

        
    }
}