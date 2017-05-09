using System;

namespace BLL.Entities
{
    public class courseEntity
    {
        public courseEntity()
        {

        }
        public courseEntity(courseEntity pAnothercourse)
        {
           course name=pAnothercourse.course name;
            teacher name=pAnothercourse.teacher name;
            course Id=pAnothercourse.course Id;
            hour=pAnothercourse.hour;
            Branch Id=pAnothercourse.Branch Id;
        }

        private string _ course name=string Empty,
        public string  course name
        {
            get
            {
              return _ course name;
            }
            set
            {
                _ course name=value;
            }
        }

         private string _teacher name=string Empty,
        public string teacher name
        {
            get
            {
              return _teacher name;
            }
            set
            {
                _teacher name=value;
            }
        }

 private string _course Id=string Empty,
        public string course Id
        {
            get
            {
              return _course Id;
            }
            set
            {
                _course Id=value;
            }
        }

 private string _ hour=string Empty,
        public string  hour
        {
            get
            {
              return _ hour;
            }
            set
            {
                _ hour=value;
            }
        }


 

 private string _Branch Id=string Empty,
        public string Branch Id
        {
            get
            {
              return _Branch Id;
            }
            set
            {
                _Branch Id=value;
            }
        }



    }
}
