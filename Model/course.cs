using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class course
    {
       private int _course_id;
        /// <summary>
        /// 课程ID
        /// </summary>
        public int id
        {
            get { return _course_id; }
            set { _course_id = value; }
        }

        private string _course_name;
        /// <summary>
        /// 课程名称
        /// </summary>
        public string course_name
        {
            get { return _course_name;  }
            set { _course_name = value; }
        }

        private int _course_termid;
        /// <summary>
        /// 学期ID
        /// </summary>
        public int course_termid
        {
            get { return _course_termid; }
            set { _course_termid = value;}
        }

        private DateTime _course_examDate;
        /// <summary>
        /// 考试时间
        /// </summary>
        public DateTime course_examDate
        {
            get { return _course_examDate;  }
            set { _course_examDate = value; }
        }

        private DateTime _course_gradeDate;
        /// <summary>
        /// 成绩发布日期
        /// </summary>
        public DateTime course_gradeDate
        {
            get { return _course_gradeDate;  }
            set { _course_gradeDate = value; }
        }

        private double _course_fullGrade;
        /// <summary>
        /// 该课程满分成绩
        /// </summary>
        public double course_fullGrade
        {
            get { return _course_fullGrade; }
            set { _course_fullGrade = value; }
        }

        private string _course_explain;
        /// <summary>
        /// 关于该课程的注释，length < 50
        /// </summary>
        public string course_explain
        {
            get { return _course_explain;  }
            set { _course_explain = value; }
        }
    }
}
