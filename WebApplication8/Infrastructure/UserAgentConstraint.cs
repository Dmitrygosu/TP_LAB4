using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Web;

namespace WebApplication8.Infrastructure
{
    public class UserAgentConstraint : IRouteConstraint
    {
        private string requiredUserAgent;
        public UserAgentConstraint(string agentParam)
        {
            requiredUserAgent = agentParam;
        }
        public bool Match(HttpContextBase httpContext, Route route, string parameterName,
        RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.UserAgent != null &&
            httpContext.Request.UserAgent.Contains(requiredUserAgent);
        }
    }
}
