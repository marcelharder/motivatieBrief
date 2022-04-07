using System.IO;
using System.Threading.Tasks;
using api.DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Cardiohelp.Controllers
{
    [ApiController]
    [Authorize]
    public class pdfController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        private IBrief _br;
        private IComposeBrief _cpbr;
        public pdfController(IWebHostEnvironment env, IBrief br, IComposeBrief cpbr)
        {
            _env = env;
            _br = br;
            _cpbr = cpbr;

        }
        [AllowAnonymous]
        [Route("api/getPDF/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            _br.deletePDF(id);
            await _cpbr.composeAsync(id); //get the final report and composes a pdf, which is stored in assets/pdf/73764743.pdf

            var id_string = id.ToString();
            return File(this.GetStream(id_string), "application/pdf", id_string + ".pdf");

        }

        private Stream GetStream(string id_string)
        {

            var pathToFile = _env.ContentRootPath + "/assets/pdf/";
            var file_name = pathToFile + id_string + ".pdf";
            var stream = new FileStream(file_name, FileMode.Open, FileAccess.Read);
            stream.Position = 0;
            return stream;

        }
    }
}