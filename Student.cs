namespace PolyMorphysm
{
    public class Student : Person
    {
        private static int counter = 0;  //הוספת מונה סטודנטים
        private int studentNum;

        private int studentClass;
        private string studentTrend;
        private double mathMark;
        private int mathGroup;
        private double englishMark;
        private int englishGroup;
        private double hisMark;
        private int hisGroup;

        public Student(int studentNum, int studentClass, string studentTrend, double mathMark, int mathGroup, double englishMark, int englishGroup, double hisMark, int hisGroup, string first_name, string last_name, int age, int id) : base(first_name, last_name, age, id)
        {
            {
                this.studentNum = studentNum;
                this.studentClass = studentClass;
                this.studentTrend = studentTrend;
                this.mathMark = mathMark;
                this.mathGroup = mathGroup;
                this.englishMark = englishMark;
                this.englishGroup = englishGroup;
                this.hisMark = hisMark;
                this.hisGroup = hisGroup;

                base.first_name = first_name;
                base.last_name = last_name;
                base.age = age;
                base.id = id;
            }
        }
        public override string ToString()
        {
            return $"name {this.first_name}, last {this.last_name}, age {this.age}, id {this.id}";
        }
    }
}
