using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Web;

namespace Form_9_PM.Classes
{
    public class User
    {
        string? _name;
        public string? Name 
        {
            get { return _name; }
            set 
            {
                if(value == "Введите имя")
                {
                    _name = "None";
                }
                else _name = value ?? "None";
            }
        }
        string? _lastName;
        public string? LastName 
        { 
            get { return _lastName; }
            set 
            {
                if (value == "Введите фамилию")
                {
                    _lastName = "None";
                }
                else _lastName = value ?? "None";
            } 
        }
        string? _patronymic;
        public string? Patronymic 
        { 
            get { return _patronymic; }
            set 
            {
                if (value == "Введите отчество")
                {
                    _patronymic = "None";
                }
                else _patronymic = value ?? "None";
            }
        }
        int? _age;
        public int? Age 
        { 
            get { return _age; }
            set 
            {
                _age = value ?? 0;
            }
        }

        Gender _gender;
        public Gender GenderChoice 
        {
            get { return _gender; }
            set
            {
                _gender = value;
            }
        }
        public enum Gender
        {
            None,
            Мужчина,
            Женщина
        }

        Grade _grade;
        public Grade GradeChoice 
        {
            get { return _grade; }
            set
            {
                _grade = value;
            }
        }
        public enum Grade
        {
            None,
            Среднее,
            Высшее, 
            Магистратура,
            Аспирантура
        }

        bool _work;
        public bool Work 
        { 
            get { return _work; }
            set
            {
                _work = value;
            } 
        }

        public override string ToString()
        {
            string? WorkInfo = "";
            if (Work) 
            {
                WorkInfo = "Да";
            }
            else
            {
                WorkInfo = "Нет";
            }

            return $"Имя: {Name}\nФамилия: {LastName}\nОтчество: {Patronymic}\nВозраст: {Age}\nПол: {GenderChoice}\nОбразование: {GradeChoice}\nНаличие работы: {WorkInfo}";
        }

    }
}
