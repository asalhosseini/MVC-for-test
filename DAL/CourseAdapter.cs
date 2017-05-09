using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using N_Layer_selectunit;


namespace DAL
{
     public class CourseAdapter:BaseAdapter<daselectunit.CourseDataTable>
     {
         const string _QUERY_SELECTALL_Course = @"SELECT*FROMCourse";
         const string _QUERY_SELECTALL_Course_Like_By = @"SELECT*FROM Course WHERE";
         const string _QUERY_INSERT_Course = @"INSERT INTO Course(course id,course name,branch id,teacher name,hour)VALUES(pcourse id,pcourse name,pbranch id,pteacher name,phour)";
         const string _QUERY_DELETE_Course_BY_course id=@"DELETE FROM Course WHERE Course id=pcourse id";
         const string _QUERY_UPDATE_Course_By_Course id=@"UPDATE Course SET course name=pNewcourse name,branch id=pNewbranch id,teacher name=pNewteacher name,hour=pNewhour WHERE Course id=pOldcourse id";
         const string _QUERY_SELECTALL_Course_By_Course id=@"SELECT*FROM Course WHERE Course id=pCourse id";

         public bool Insert(string pcourse Id,string pcourse name,string pbranch id,string pteacher id,string phour)
     {
         OleDbParameter[]p=new OleDbParameter[]{new OleDbParameter("pcourse id",pcourse id),new OleDbParameter("pcourse name",pcourse name),new OleDbParameter("pbranch id",pbranch id),new OleDbParameter("pteacher name",pteacher name),new OleDbParameter("phour",phour)};
    return base.execute_Command_NonQuery(_QUERY_INSERT_Course,person,p);
}

public bool Update_By_Course id(string pOldcourse id5Compare,string pNewcourse name,string pNewbranch id,string pNewteacher id,string pNewhour);
{
 OleDbParameter[]p=new OleDbParameter[]{new OleDbParameter("pOldcourse id",pOldcourse id5Compare),new OleDbParameter("pcourse name",pNewcourse name),new OleDbParameter("pbranch id",pNewbranch id),new OleDbParameter("pteacher name",pNewteacher name),new OleDbParameter("phour",pNewhour)};
    return base.execute_Command_NonQuery(_QUERY_UPDATE_Course_By_course id,p);
}

 public bool Delete_By_course id(string pcourse id)
     {
         OleDbParameter[]p=new OleDbParameter[]{new OleDbParameter("pcourse id",pcourse id)};
    return base.execute_Command_NonQuery(_QUERY_DELETE_Course_By_course id,p);
}

public daselectunit.courseDataTable Select_AllCourse()
{
return base.select_All(_QUERY_SELECTALL_course);
}

public daselectunit.courseDataTable Select_Allcourse_By_course id(string pcourse id)
     {
         OleDbParameter[]p=new OleDbParameter[]{new OleDbParameter("pcourse id",pcourse id)};
    return base.select_By(_QUERY_SELECTALL_course_By_course id,p);
}

public daselectunit.courseDataTable selet_AllCourse_Like_By;
{
string temp=_QUERY_SELECTALL_Course_Like_By;
temp=temp+pcourse name+"like pvalue";
OleDbParameter[]p=new OleDbParameter[]{new OleDbParameter("pvalue",pvalue)};
return base.select_By(temp,p);
}
}
}



    
    }
}
 