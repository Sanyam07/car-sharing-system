﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.Routing;
using System.Web.UI;

namespace car_sharing_system.App_Start
{
    public class CustomRouteHandler : IRouteHandler
    {
        public CustomRouteHandler(string virtualPath)
        {
            this.VirtualPath = virtualPath;
        }

        public string VirtualPath { get; private set; }

        public IHttpHandler GetHttpHandler(RequestContext
              requestContext)
        {
            var page = BuildManager.CreateInstanceFromVirtualPath
                 (VirtualPath, typeof(Page)) as IHttpHandler;
            return page;
        }
    }
}