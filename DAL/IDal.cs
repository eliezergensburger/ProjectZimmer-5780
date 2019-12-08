using BE;

namespace DAL
{
    public interface IDal
    {
        bool AddHost(Host host);
        bool RemoveHost(Host host);
    }
}