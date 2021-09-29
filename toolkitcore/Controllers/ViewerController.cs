﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolkitCore.Models;
using Verse;
using static ToolkitCore.Models.Services;

namespace ToolkitCore.Controllers
{
    public static class ViewerController
    {
        public static Viewer GetViewer(Service service, string username)
        {
            if (ViewerList.Instance.All == null)
            {
                ViewerList.Instance.All = new List<Viewer>();
                return null;
            }

            return ViewerList.Instance.All.Find((v) => v.Service == service && v.Username == username);
        }

        public static bool ViewerExists(Service service, string username)
        {
            return GetViewer(service, username) != null;
        }

        public static Viewer CreateViewer(Service service, string username, int userId)
        {
            return new Viewer()
            {
                Service = service,
                Username = username,
                UserId = userId
            };
        }

        public static bool ViewerExistsByID(Service service, int ID)
        {
            return GetViewerByID(service, ID) != null;
        }

        public static Viewer GetViewerByID(Service service, int ID)
        {
            if (ViewerList.Instance.All == null)
            {
                ViewerList.Instance.All = new List<Viewer>();
                return null;
            }

            return ViewerList.Instance.All.Find((v) => v.Service == service && v.UserId == ID);
        }
    }
}
