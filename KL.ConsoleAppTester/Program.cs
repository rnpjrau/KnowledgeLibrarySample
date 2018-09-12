using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KL.Domain;
using KL.Persistence;

namespace KL.ConsoleAppTester
{
  class Program
  {
    static void Main(string[] args)
    {
      KnowledgeLibraryDetail record = new KnowledgeLibraryDetail();

      record.Name = "Test";
      record.Description = "Some test";
      record.URL = "www.google.com";
      record.DevelopmentTypeId = Guid.Parse("9A51EA72-5A40-4B75-B377-A83E5F797497");

      BaseRepository<KnowledgeLibraryDetail> repo = new BaseRepository<KnowledgeLibraryDetail>();

      try
      {
        repo.Save(record);
      }
      catch (Exception ex)
      {
        throw ex;
      }
      
    }
  }
}
