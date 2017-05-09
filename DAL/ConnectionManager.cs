using System.Data.OleDb;

namespace DAL
{
   public static class ConnectionManager
    {
       private static OleDbConnection _con2selectunit = null;
       public static OleDbConnection GetConnection2selectunit
       {
           get
           {
               if(_con2selectunit==null)
                   _con2selectunit=new OleDbConnection(Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Visual c# step by step\CHAPTER3\n layer\n layer\bin\Debug\selectunit.accdb");
               return _con2selectunit;
           }
       }

       public static void Open_Connection2selectunit()
       {
           GetConnection2selectunitOpen();
       }
       public static void Close_Connection_From_selectunit()
       {
           if(_con2selectunit==null)
               return;
           _con2selectunit.Close();
       }
   }
}