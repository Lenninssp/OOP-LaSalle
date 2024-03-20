using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIdterm.bus
{
    [Serializable]
    public class Film
    {
        private int code;
        private string title;
        private EnumCategory category;
        private EnumLanguage language;
        private Time duration;
        private Person actor;

        public int Code
        { get { return code; } 
          set { code = value; } 
        }
        public string Title
        { get { return title; } 
          set { title = value; } 
        }
        public EnumCategory Category
        { get { return category; } 
          set { category = value; } 
        }
        public EnumLanguage Language
        { get { return language; } 
          set { language = value; } 
        }
        public Time Duration
        { get { return duration; } 
          set { duration = value; } 
        }
        public Person Actor
        {
            get { return actor; }
            set { actor = value; }
        }

        public Film()
        {
            code = 0;
            title = string.Empty;
            category = EnumCategory.None;
            language = EnumLanguage.None;
            duration = new Time();
            actor = new Person();
        }

        public Film(int code)
        {
            this.code = code;
            this.title = string.Empty;
            this.category = EnumCategory.None;
            this.language = EnumLanguage.None;
            this.duration = new Time();
            this.actor = new Person();
        }

        public Film(int code, string title)
        {
            this.code = code;
            this.title = title;
            this.category = EnumCategory.None;
            this.language = EnumLanguage.None;
            this.duration = new Time();
            this.actor = new Person();
        }


        public Film(int code, string title, EnumCategory category)
        {
            this.code = code;
            this.title = title;
            this.category = category;
            this.language = EnumLanguage.None;
            this.duration = new Time();
            this.actor = new Person();
        }

        public Film(int code, string title, EnumCategory category, EnumLanguage language)
        {
            this.code = code;
            this.title = title;
            this.category = category;
            this.language = language;
            this.duration = new Time();
            this.actor = new Person();
        }

        public Film(int code, string title, EnumCategory category, EnumLanguage language, Time duration)
        {
            this.code = code;
            this.title = title;
            this.category = category;
            this.language = language;
            this.duration = duration;
            this.actor = new Person();
        }
        public Film(int code, string title, EnumCategory category, EnumLanguage language, Time duration, Person actor)
        {
            this.code = code;
            this.title = title;
            this.category = category;
            this.language = language;
            this.duration = duration;
            this.actor = actor;
        }
        public string GetState()
        {
            return $"{code} \n {title} \n {category} \n {language} \n {duration.GetState()} \n {actor.GetState()}";
        }
    }
}
