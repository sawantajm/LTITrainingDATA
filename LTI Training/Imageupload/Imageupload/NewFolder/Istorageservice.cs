using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uploadImage.NewFolder
{
    public interface Istorageservice
    {

        void Upload(IFormFile formfile);
    }
}
