using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject
{
    public class User
    {
        public int id { get; set; }
        private string surname { get; set; }
        private string name { get; set; }
        private string patronymic { get; set; }
        private string job { get; set; }
        private string gender { get; set; }
        private DateTime bday { get; set; }
        private string phone { get; set; }
        private string email { get; set; }
        private string login { get; set; }
        private string password { get; set; }
        public bool isExaminer { get; set; }

        public User(int id, string surname, string name, string patronymic, string job, string gender, DateTime bday, string phone, string email, string login, string password, bool is_examiner) 
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.patronymic = !String.IsNullOrEmpty(patronymic) ? patronymic : "";
            this.job = !String.IsNullOrEmpty(job) ? job : "";
            this.gender = gender;
            this.bday= bday;
            this.phone = phone;
            this.email = email;
            this.login = login;
            this.password = password;
            this.isExaminer= is_examiner;
        }

        public string getFIO()
        {
            if (!String.IsNullOrEmpty(this.patronymic))
            {
                return this.surname + " " + this.name.ToUpper()[0] + "." + this.patronymic.ToUpper()[0] + ".";
            }
            else 
            {
                return this.surname + " " + this.name.ToUpper()[0] + ".";
            }
        }


    }
}
