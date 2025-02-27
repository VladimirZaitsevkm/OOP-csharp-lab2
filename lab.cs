using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labcsharp2OOP
{
  internal class lab
  {

    class Document {

      public string DocumentName;
      public string AuthorName;
      public string KeyWords;
      public string Theme;
      public string Path;

      }

    class MSWord : Document
    {

      public int NumberOfPages;

    }

    class PDF : Document
    {

      public bool isPasswordProtected;

    }

    class MSExcel : Document
    {

      public int UsedCellRange;

    }

    static void Main(string[] args)
    {
    }
  }
}
