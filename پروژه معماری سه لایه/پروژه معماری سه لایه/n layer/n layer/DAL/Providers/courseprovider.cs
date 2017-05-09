using System;
using System.Collections.Generic;
using BLL.Entities;
using BLL.Providers;
using DAL;

namespace BLL.Providers
{
    public class courseProvider:IProvider<courseEntity,string>
    {
        private courseProvider_courseAdapter;

        public courseProvider()
        {
            _courseAdapter=new courseAdapter;
        }

        public bool Add(courseEntity pcourse5Add)
        {
            return _courseAdapter.Insert(pcourse5Add.branch id,pcourse5Add.teacher name,pcourse5Add.course ID,pcourse5Add.course name,pcourse5Add.hour
            );
        }

         public bool Update(courseEntity pcourse5Update,string pcourse Id5Compare)
        {
            return _courseAdapter.Update_By_course Id(pcourse5Update.branch id,pcourse5Update.teacher name,pcourse5Update.course name,pcourse5Update.hour
                ,pcourse5Update.course Id);
        }

     public bool delete(string pcourse Id5Compare)
       
            return _courseAdapter.Delete_By_course Id(pcourse Id5Compare);
        }
      public List<courseEntity>Get_All-Item()
{
List<courseEntity>retList=new List<courseEntity>();
foreach(var course in _courseAdapter.Select_Allcourse())
{
courseEntity x=new courseEntity();
x.course name=course.course name;
x.teacher name=course.teacher name;
x.course Id=course.course Id;
x.hour=course.hour;
x.Branch Id=course.Branch Id;
retList.Add(X);
}
return retList;
}
public List<courseEntity>Get_Item_By_courseId(string pcourse Id)
{
List<courseEntity>retList=new List<courseEntity>();
foreach(varcourse in _courseAdaptor.Select_Allcourse_By_course Id(pcourse Id))
{
courseEntity x=new courseEntity();
x.course name=course.course name;
x.teacher name=course.teacher name;
x.course Id=course.course Id;
x.hour=course.hour;
x.Branch Id=course.Branch Id;
retList.Add(X);
}
return retList;
}

public List<courseEntity>Get_Item_like_By(string pFieldName,string Pvalue)
{
List<courseEntity>retList=new List<courseEntity>();
foreach(var course in _courseAdaptor.Select_Allcourse_Like_By(pFieldName,Pvalue))
{
courseEntity x=new courseEntity();
x.Name=course.Name;

}









    }
}
