using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labcsharp2OOP
{
  internal class lab
  {

    class Document
    {

      public string DocumentName;
      public string AuthorName;
      public string KeyWords;
      public string Theme;
      public string Path;

      public virtual string getDocumentInfo()
      {

        return $"Document Name: {DocumentName} \n" +
               $"Author Name: {AuthorName} \n" +
               $"Key Words: {KeyWords} \n" +
               $"Theme: {Theme} \n" +
               $"Path: {Path} \n";
      }

      class MSWord : Document
      {

        public int NumberOfPages;

        public override string getDocumentInfo()
        {

          return base.getDocumentInfo() + $"Pages: {NumberOfPages} \n";

        }



      }

      class PDF : Document
      {

        public bool isPasswordProtected;

      }

      class MSExcel : Document
      {

        public int UsedCellRange;

      }

      class TXT : Document
      {

        public int LineCount;

      }

      class HTML : Document
      {

        public int NumberOfTags;

      }

      static void Main(string[] args)
      {
      }
    }
  }
}