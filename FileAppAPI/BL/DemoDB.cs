using FileAppAPI.Entities;
using System.Linq;
namespace FileAppAPI
{
    public class DemoDB
    {
        FileModel[] files = new FileModel[10];
        public FileModel[] GetAllFiles()
        {
            //return all files.....
            return this.files;
        }

        public bool DeleteFile(int id)
        {
            var file = this.files.First(x => x.id == id);
            //delete it from DB and reload list.......
            return true;
        }

        public void AddNewFile(FileModel f)
        {
            //buisness to insert a newb file....
        }
    }
}
