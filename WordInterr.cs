using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop;

namespace wordInter
{
    class WordInter
    {
        private FileInfo _fileInfo;

        public WordInter(string FileName)
        {
            if(File.Exists(FileName)) 
            {
                _fileInfo = new FileInfo(FileName);
            }
            else
            {
                throw new ArgumentException("File is not found!");
            }
        }

        internal bool Process(Dictionary<string, string> items)
        {
            Word.Word.Application app = null;
            try 
            {
                app = new Microsoft.Office.Interop.Word.Application();
                Object file = _fileInfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach(var item in items ) 
                {
                    Microsoft.Office.Interop.Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);    
                }

                object newFileName = Path.Combine(_fileInfo.DirectoryName, (DateTime.Now.ToString("yyyy.MM.dd")+"  Otpusk.docx"));
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                app.Quit();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                if(app!=null)
                app.Quit();
            }

            return false;
        }
    }
}
