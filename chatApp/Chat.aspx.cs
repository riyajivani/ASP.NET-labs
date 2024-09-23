using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chatApp
{
    public partial class Chat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayMessages();
            }
        }

        private void DisplayMessages()
        {
            if (Application["Messages"] != null)
            {
                var messages = (List<string>)Application["Messages"];
                chatArea.InnerHtml = string.Join("<br />", messages);
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string message = txtMessage.Text.Trim();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(message))
            {
                string formattedMessage = $"{username}: {message}";

                Application.Lock();
                if (Application["Messages"] == null)
                {
                    Application["Messages"] = new List<string>();
                }
                var messages = (List<string>)Application["Messages"];
                messages.Add(formattedMessage);
                Application["Messages"] = messages; 
                Application.UnLock();

                txtMessage.Text = string.Empty;

                DisplayMessages();
            }
           }
    }
}