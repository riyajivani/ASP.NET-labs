using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CacheDemo
{
    public partial class Default : System.Web.UI.Page
    {
        private Cache cache;
        protected void Page_Load(object sender, EventArgs e)
        {
            cache = HttpRuntime.Cache;
        }

        // File-based cache dependency
        protected void btnFileDependency_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;

            if (!string.IsNullOrEmpty(filePath))
            {
                if (cache["FileCache"] == null)
                {
                    CacheDependency fileDep = new CacheDependency(filePath);
                    cache.Insert("FileCache", "File-based cache data", fileDep);
                    lblMessage.Text = "File-based cache added!";
                }
                else
                {
                    lblMessage.Text = "File-based cache already exists!";
                }
            }
            else
            {
                lblMessage.Text = "Please enter a file path.";
            }
        }

        // Key-based cache dependency
        protected void btnKeyDependency_Click(object sender, EventArgs e)
        {
            if (cache["KeyCache"] == null)
            {
                cache.Insert("DependentKey", "This is the dependent key");
                CacheDependency keyDep = new CacheDependency(null, new string[] { "DependentKey" });
                cache.Insert("KeyCache", "Key-based cache data", keyDep);
                lblMessage.Text = "Key-based cache added!";
            }
            else
            {
                lblMessage.Text = "Key-based cache already exists!";
            }
        }

        // Time-based cache dependency
        protected void btnTimeDependency_Click(object sender, EventArgs e)
        {
            int seconds;
            if (int.TryParse(txtTimeSeconds.Text, out seconds))
            {
                if (cache["TimeCache"] == null)
                {
                    cache.Insert("TimeCache", "Time-based cache data", null, DateTime.Now.AddSeconds(seconds), Cache.NoSlidingExpiration);
                    lblMessage.Text = $"Time-based cache added for {seconds} seconds!";
                }
                else
                {
                    lblMessage.Text = "Time-based cache already exists!";
                }
            }
            else
            {
                lblMessage.Text = "Please enter a valid number of seconds.";
            }
        }

        // Clear all cache
        protected void btnClearCache_Click(object sender, EventArgs e)
        {
            cache.Remove("FileCache");
            cache.Remove("KeyCache");
            cache.Remove("TimeCache");
            cache.Remove("DependentKey");
            lblMessage.Text = "All caches cleared!";
        }
    }
}