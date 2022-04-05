using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace api.DAL.dtos
{
    public class PhotoForCreationDto
    {
       public string url { get; set; } 
       public IFormFile file { get; set; }
       public string description { get; set; }
       public DateTime dateAdded { get; set; }

       public string publicId { get; set; }

       public PhotoForCreationDto()
       {
           dateAdded = DateTime.Now;
       }
    }
}