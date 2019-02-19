1.set attribute above controllers or action for authorize
    public class AdminAuthorizeAttribute:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool _pass = false;
            if (httpContext.Session["Account"] != null) _pass = true;
            return _pass;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult("~/Config/Administrator/Login");
        }
    }
2.set how to get dbcontext
    public class ContextFactory
    {
        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns>数据上下文</returns>
        public static NineskyDbContext GetCurrentContext()
        {
            NineskyDbContext _nineskyDbContext = CallContext.GetData("NineskyDbContext") as NineskyDbContext;
            if (_nineskyDbContext == null)
            {
                _nineskyDbContext = new NineskyDbContext();
                CallContext.SetData("NineskyDbContext", _nineskyDbContext);
            }
            return _nineskyDbContext;
        }
    }
