using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;

namespace GreerAutomation.Controllers
{
    public class TwilioController : Controller
    {
        // GET: Twilio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RingPhone(string phone)
        {

            Response.Write("sdbhdsfhdsbfh");
            // Find your Account Sid and Auth Token at twilio.com/user/account 

            Put AccountSid and AuthToken values in 

            string AccountSid = "";
            string AuthToken = "";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            // Build the parameters 
            var options = new CallOptions();
            //options.To = "8154120866";
            options.To = phone;
            options.From = "+17086757020";
            options.Url = "http://greerautomation.com/Twilio/CallOptions";
           // options.Url = "~/CallOptions";

            options.Method = "GET";
            options.FallbackMethod = "GET";
            options.StatusCallbackMethod = "GET";
            options.Record = true;

            var call = twilio.InitiateOutboundCall(options);
            Console.WriteLine(call.Sid);
            System.Threading.Thread.Sleep(20000);

            return null;

        }

        public ActionResult CallOptions()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<Response>");
            sb.Append("<Gather timeout = \"90\" finishOnKey = \"*\">");
            sb.Append("<Say voice=\"alice\">");
            sb.Append("<Pause length='4' />");
            sb.Append("Please enter your pin number and then press star.");
            sb.Append("Please hold for tech support. do not hang up.");
            sb.Append("</Say>");
            sb.Append("</Gather>");
            sb.Append("</Response>");

            return this.Content(sb.ToString(), "text/xml");
        }

    }
}