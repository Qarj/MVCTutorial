using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1.ViewModels.SPA
{
    public class FileUploadViewModel
    {
        public HttpPostedFileBase fileUpload { get; set; }
    }

}
