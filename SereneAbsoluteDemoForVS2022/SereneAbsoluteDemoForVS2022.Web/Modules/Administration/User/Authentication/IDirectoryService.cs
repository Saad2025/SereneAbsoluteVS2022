
namespace SereneAbsoluteDemoForVS2022.Administration
{
    public interface IDirectoryService
    {
        DirectoryEntry Validate(string username, string password);
    }
}