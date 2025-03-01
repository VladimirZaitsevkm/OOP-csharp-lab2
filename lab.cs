using System;
using System.Collections.Generic;

namespace Labcsharp2OOP
{
  public class Document
  {
    public string DocumentName;
    public string AuthorName;
    public List<string> KeyWords = new List<string>();
    public string Theme;  
    public string Path;

    public virtual string GetDocumentInfo()
    {
      return $"Document Name: {DocumentName} \n" +
             $"Author Name: {AuthorName} \n" +
             $"Key Words: {string.Join(", ", KeyWords)} \n" +
             $"Theme: {Theme} \n" +
             $"Path: {Path} \n";
    }
  }

  class MsWord : Document
  {
    public int NumberOfPages;

    public override string GetDocumentInfo()
    {
      return base.GetDocumentInfo() + $"Pages: {NumberOfPages} \n";
    }
  }

  class Pdf : Document
  {
    public bool IsPasswordProtected;

    public override string GetDocumentInfo()
    {
      return base.GetDocumentInfo() + $"Is document protected by a password: {IsPasswordProtected} \n";
    }
  }

  class MsExcel : Document
  {
    public int UsedCellRange;

    public override string GetDocumentInfo()
    {
      return base.GetDocumentInfo() + $"Used Cell Range: {UsedCellRange} \n";
    }
  }

  class Txt : Document
  {
    public int LineCount;

    public override string GetDocumentInfo()
    {
      return base.GetDocumentInfo() + $"Line Count: {LineCount} \n";
    }
  }

  class Html : Document
  {
    public int NumberOfTags;

    public override string GetDocumentInfo()
    {
      return base.GetDocumentInfo() + $"Number Of Tags: {NumberOfTags} \n";
    }
  }

  class DocumentManager
  {
    private static DocumentManager _instance;
    private List<Document> _documents = new List<Document>();


    public static DocumentManager Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new DocumentManager();
        }
        return _instance;
      }
    }

    public void ShowDocuments()
    {
      if (_documents.Count == 0)
      {
        Console.WriteLine("Нет документов.");
        return;
      }

      foreach (var doc in _documents)
      {
        Console.WriteLine(doc.GetDocumentInfo());
      }
    }

    public void Menu()
    {
      while (true)
      {
        Console.WriteLine("\nМеню:");
        Console.WriteLine("1. Показать все документы");
        Console.WriteLine("2. Добавить тестовые документы");
        Console.WriteLine("3. Выйти");
        Console.Write("Выберите действие: ");

        string choice = Console.ReadLine();
        switch (choice)
        {
          case "1":
            ShowDocuments();
            break;
          case "2":
            AddSampleDocuments();
            Console.WriteLine("Тестовые документы добавлены!");
            break;
          case "3":
            return;
          default:
            Console.WriteLine("Неверный ввод, попробуйте снова.");
            break;
        }
      }
    }

    private void AddSampleDocuments()
    {
      _documents.Add(new MsWord
      {
        DocumentName = "Word File",
        AuthorName = "Ivan",
        KeyWords = { "Text", "Document" },
        Theme = "Work",
        Path = "C:\\docs\\file.docx",
        NumberOfPages = 10
      });

      _documents.Add(new Pdf
      {
        DocumentName = "PDF File",
        AuthorName = "Anna",
        KeyWords = { "Report", "Finance" },
        Theme = "Finance",
        Path = "C:\\docs\\report.pdf",
        IsPasswordProtected = true
      });

      _documents.Add(new MsExcel
      {
        DocumentName = "Excel File",
        AuthorName = "Sergey",
        KeyWords = { "Data", "Table" },
        Theme = "Data Analysis",
        Path = "C:\\docs\\data.xlsx",
        UsedCellRange = 100
      });

      _documents.Add(new Txt
      {
        DocumentName = "Text File",
        AuthorName = "Olga",
        KeyWords = { "Notes", "Memo" },
        Theme = "Personal",
        Path = "C:\\docs\\notes.txt",
        LineCount = 50
      });

      _documents.Add(new Html
      {
        DocumentName = "HTML File",
        AuthorName = "Dmitry",
        KeyWords = { "Web", "Page" },
        Theme = "Web Development",
        Path = "C:\\docs\\page.html",
        NumberOfTags = 15
      });
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      DocumentManager.Instance.Menu();
    }
  }
}