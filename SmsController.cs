using Microsoft.AspNetCore.Mvc;
using Twilio.AspNet.Common;
using Twilio.AspNet.Core;
using Twilio.TwiML;

namespace twilio_csharp
{
    [Route("[controller]")]
    public class SmsController : TwilioController
    {
        [HttpGet]
        public TwiMLResult Index(SmsRequest incomingMessage)
        {
            var messagingResponse = new MessagingResponse();
            messagingResponse.Message("The Knative copy cat says: " + incomingMessage.Body);
            return TwiML(messagingResponse);
        }
    }
}
