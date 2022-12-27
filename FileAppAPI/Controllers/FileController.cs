using FileAppAPI.BL;
using FileAppAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FileAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : Controller
    {
        private readonly IFile fileService;
        public FileController(IFile fileSrv)
        {
            this.fileService = fileSrv;
        }

        // POST: FileController/Create
        [ValidateAntiForgeryToken]
        [HttpPost(Name = "Create")]
        public ActionResult Create(FileModel f)
        {
            try
            {
                fileService.AddNewFile(f);
                return View();
            }
            catch
            {
                return View();
            }
        }


        // POST: FileController/Delete/5

        [ValidateAntiForgeryToken]
        [HttpDelete(Name = "Delete")] 
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
