using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EGovProject
{
   

        [Table("Student", Schema = "dbo")]
        public class Student
        {
            // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          
        [Key]
        public int StudentId { get; set; }
        [DisplayName("Full Name")]
        public string StudentName { get; set; }
        public string Semester { get; set; }
        [DisplayName("Symbol Number")]
        public int StudentRoll { get; set; }
     
        public string Address { get; set; }
   
        public string Batch { get; set; }
        [DisplayName("Mobile No.")]
        public string ContactNumber { get; set; }
    
        public string Email { get; set; }

        [DisplayName("Photo")]

        public string StudentPhoto { get; set; }
    
        public string Nationality { get; set; }

        [DisplayName("Date of Birth")]

        public DateTime DOB { get; set; }

  

        public string Sex { get; set; }
        [DisplayName("Father's Name")]
        public string FatherName { get; set; }
        [DisplayName("Mother's Name")]
        public string MotherName { get; set; }

        [DisplayName("Registration No.")]

        public string RegistrationNumber { get; set; }
        [DisplayName("College")]
        public string CollegeName { get; set; }
   
        public int Age { get; set; }

    }

    public class Teacher
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int TeacherId { get; set; }
        [DisplayName("Full Name")]
        public string TeacherName { get; set; }
        [DisplayName("Citizenship No.")]
        public string CtzNo { get; set; }
        public string Address { get; set; }
        [DisplayName("Mobile No.")]
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        [DisplayName("Photo")]
        public string TeacherPhoto { get; set; }
        [DisplayName("Teaching Subject")]
        public string Subject { get; set; }
        [DisplayName("Working Experience")]
        public string Experience { get; set; }
        public string Nationality { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DOB { get; set; }
        public string Sex { get; set; }
        [DisplayName("Father's Name")]
        public string FatherName { get; set; }
        [DisplayName("Mother's Name")]
        public string MotherName { get; set; }
       public string MaritalStatus { get; set; }
        public string Qualification { get; set; }
        [DisplayName("Involved College/Campus")]
        public string CollegeName { get; set; }
        public int Age { get; set; }

    }






    public class Exam
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public string StudentId { get; set; }
    }
    public class Class
        {
            public int ClassId { get; set; }
            public string ClassName { get; set; }
            public string ClassTeacher { get; set; }
        }
        public class Subject
        {
        public string SubjectId { get; set; }
      
        public string SubjectName { get; set; }
        public string Semester { get; set; }
        }
       



        public class FirstSem_Mark
    {
      [Key]
        public int MarkId { get; set; }
        public int StudentId { get; set; }
        public double CTheory { get; set; }
        public double C_Practical { get; set; }
        public double C_Ass { get; set; }
        public string C_Code { get; set; }
        public double Maths1_Theory { get; set; }
   
        public double Maths1_Ass { get; set; }
        public string Maths1_Code { get; set; }
        public double IIT_Theory { get; set; }
        public double IIT_Practical { get; set; }
        public double IIT_Ass { get; set; }
        public string IIT_Code { get; set; }
        public double Physics_Theory { get; set; }
        public double Physics_Practical { get; set; }
        public double Physics_Ass { get; set; }
        public string Physics_Code { get; set; }
        public double DL_Theory { get; set; }
        public double DL_Practical { get; set; }
        public double DL_Ass { get; set; }
        public string DL_Code { get; set; }

    }





    [Table("Marks")]

    public class Mark
        {
            public int MarkId { get; set; }
            public int StudentId { get; set; }
            public double TheoryMark { get; set; }
        public double PracticalMark { get; set; }
        public double InternalMark { get; set; }
        public string SubjectId { get; set; }

        }
    public class FileDetails
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Display(Name = "What's on your mind?")]
        [Required(ErrorMessage = "Please enter what's on your mind")]
        public string Description { get; set; }
    public string ProfilePicture { get; set; }
        [DisplayName("Upload File")]
        public string FileContent { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime FileDate { get; set; }
    }
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }


        public string Email{ get; set; }
      
        public string Message { get; set; }
        public DateTime ContactDate { get; set; }




    }
    public class PortfolioContact
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Subject { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }


        public string Email { get; set; }

        public string Message { get; set; }
        public DateTime ContactDate { get; set; }
    }
   

}
