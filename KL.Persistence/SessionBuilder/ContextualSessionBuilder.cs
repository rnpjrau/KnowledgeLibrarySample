using System;
using System.Collections.Generic;
using System.Web;
using NHibernate;
using NHibernate.Context;

namespace KL.Persistence
{
  //2.
  public class ContextualSessionBuilder<T> : SessionBuilderBase<T>
  {
    public override ISession CurrentSession
    {
      get
      {
        //if (!ManagedWebSessionContext.HasBind(HttpContext.Current, GetSessionFactory()))
        //{
        //  ManagedWebSessionContext.Bind(HttpContext.Current, GetSessionFactory().OpenSession());
        //}

        //if current web context has no session factory bound to it, open one and then bind it to the session
        if (!WebSessionContext.HasBind(GetSessionFactory()))        
          WebSessionContext.Bind(GetSessionFactory().OpenSession());
        
        return GetSessionFactory().GetCurrentSession();
      }
    }
  }
}
