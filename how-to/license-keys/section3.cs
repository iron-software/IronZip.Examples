using IronZip;
namespace ironzip.LicenseKeys
{
    public class Section3
    {
        public void Run()
        {
            // Check if a given license key string is valid
            bool valid = IronZip.License.IsValidLicense("IRONZIP.MYLICENSE.KEY.1EF01");
        }
    }
}