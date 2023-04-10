using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace LibraryCatalogueSQL
{
    public class DataAcces
    {
        public List<Book> GetBooks(string title, string author, string language, string targetAudience, string genre)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helpers.CnnValue("LibraryCatalogueDB")))
            {
                var bookListParam = new DynamicParameters();
                bookListParam.Add("@Title", title);
                bookListParam.Add("@Author", author);
                bookListParam.Add("@Language", language);
                bookListParam.Add("@TargetAudience", targetAudience);
                bookListParam.Add("@Genre", genre);

                return connection.Query<Book>("dbo.Books_GetByDetails", bookListParam, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public void InsertBook(string title, string author, int nrPages, string language, string targetAudience, string genre)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helpers.CnnValue("LibraryCatalogueDB")))
            {
                List<Book> bookList = new List<Book>();
                bookList.Add( new Book { Title = title
                                        , Author = author
                                        , NrPages = nrPages
                                        , Language = language
                                        , TargetAudience = targetAudience
                                        , Genre = genre });
                connection.Execute("dbo.Books_Insert @Title, @Author, @NrPages, @Language, @TargetAudience, @Genre", bookList);
            }
        }
        public void ModifyBook(int id, string title, string author, int nrPages, string language, string targetAudience, string genre)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helpers.CnnValue("LibraryCatalogueDB")))
            {
                List<Book> bookList = new List<Book>();
                bookList.Add( new Book { Id = id
                                        ,Title = title
                                        , Author = author
                                        , NrPages = nrPages
                                        , Language = language
                                        , TargetAudience = targetAudience
                                        , Genre = genre });
                connection.Execute("dbo.Books_ModifyById @Id, @Title, @Author, @NrPages, @Language, @TargetAudience, @Genre", bookList);
            }
        }
        public void DeleteBook(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helpers.CnnValue("LibraryCatalogueDB")))
            {
                connection.Execute("dbo.Books_DeleteById @Id", new {Id = id});
            }
        }
    }
}
