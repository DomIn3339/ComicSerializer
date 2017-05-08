using ComicVineLibrary;
using ComicVineLibrary.Models;
using System.Linq;

namespace ComicSerializer_Test
{
    public class apiTools
    {
        ComicVineService service = new ComicVineService();

        public apiTools()
        {

        }
        public apiTools(string key)
        {
            service.ComicVineKey = key;
        }

        public void setApiKey(string key)
        {
            service.ComicVineKey = key;
        }

        public ComicVineVolume getVolumeByName(string volume_name)
        {
            try
            {
                return service.SearchVolume(volume_name).ElementAt(0);
            }
            catch { }

            return null;
        }

        public ComicVineIssue getIssueByName(string volume_name, int number)
        {
            try
            {
                return service.SearchIssue(volume_name, number)[0];
            }
            catch { }

            return null;
        }
    }
}