using DiawiApi.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DiawiApi
{
    public interface IApi
    {
        /// <summary>
        /// Requests to this endpoint should be performed as POST with content-Type as "multipart/form-data" and the following parameters:
        /// </summary>
        /// <param name="token">your API access token</param>
        /// <param name="file">the .ipa/.apk/.zip(.app) file</param>
        /// <param name="find_by_udid">allow your testers to find the app on Diawi's mobile web app using their UDID (iOS only)</param>
        /// <param name="wall_of_apps">allow Diawi to display the app's icon on the wall of apps</param>
        /// <param name="password">protect your app with a password: it will be required to access the installation page</param>
        /// <param name="comment">additional information to your users on this build: the comment will be displayed on the installation page</param>
        /// <param name="callback_url">the URL Diawi should call with the result</param>
        /// <param name="callback_emails">the email addresses Diawi will send the result to (up to 5 separated by commas for starter/premium/enterprise accounts, 1 for free accounts)</param>
        /// <param name="installation_notifications">receive notifications each time someone installs the app (only starter/premium/enterprise accounts)</param>
        /// <returns>Response will be a JSON object containing a key "job" with the identifier of the upload processing job that will be performed on our side.</returns>
        /*Task<object> Upload(string token, File file, 
            bool find_by_udid = false,
            bool wall_of_apps = false,
            string password =null,
            string comment = null,
            string callback_url = null,
            string[] callback_emails = null,
            bool installation_notifications = false);*/

        [Multipart]
        [Post("/")]
        Task<JobKeyResponse> Upload(string token, [AliasAs("file")] StreamPart file);

        [Get("/status?token={token}&job={job}")]
        /// <summary>
        /// If you opt for polling the status to get the Diawi URL of your upload, requests to this endpoint should be performed as GET with the following parameters:
        /// </summary>
        /// <param name="token">your API access token</param>
        /// <param name="jobKey">the u  pload job hash from the upload response</param>
        /// <returns>Error/Processing/Ready response</returns>
        Task<Response> GetStatus(string token, string job);
    }
}
