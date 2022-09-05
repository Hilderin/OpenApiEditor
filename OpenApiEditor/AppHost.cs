using OpenApiEditor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiEditor
{
    public static class AppHost
    {
        /// <summary>
        /// ApiProvider pour accéder aux données
        /// </summary>
        public static ApiRepository ApiRepository { get; } = new ApiRepository();
    }
}
