using System;

namespace KL.Domain
{
  //[Serializable()]
  public class DevelopmentType
  {
    public virtual Guid Id { get; set; }
    public virtual string Name { get; set; }    
  }
}
