using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyceumPupil
{
    public class LyceumPupil
    {
        public class YouCantExpelMeTwice : Exception
        {
            public YouCantExpelMeTwice()
            { }
        }

        static ushort howManyPupilsAlreadyExists = 0;
        int grade, group;
        string birthDate;
        bool isExpelled;
        string FavouriteProgrammingLanguage;
        bool isCommunist;
        Dictionary<string, Dictionary<ulong, byte>> Marks;
        public LyceumPupil()
        {
            this.isCommunist = true;
            this.FavouriteProgrammingLanguage = "C++";
            this.Marks = new Dictionary<string, Dictionary<ulong, byte>>();
            this.grade = 3;
            this.group = 1;
            ++howManyPupilsAlreadyExists;
        }
        public LyceumPupil(int grade, int group)
        {
            this.grade = grade;
            this.group = group;
            this.isCommunist = true;
            this.FavouriteProgrammingLanguage = "C++";
            this.Marks = new Dictionary<string, Dictionary<ulong, byte>>();
            ++howManyPupilsAlreadyExists;
        }
        public LyceumPupil(int grade, int group, string FavouriteProgrammingLanguage, bool isCommunist)
        {
            this.grade = grade;
            this.group = group;
            this.isCommunist = true;
            this.FavouriteProgrammingLanguage = FavouriteProgrammingLanguage;
            this.Marks = new Dictionary<string, Dictionary<ulong, byte>>();
            ++howManyPupilsAlreadyExists;
        }
        public LyceumPupil(int grade, int group, string FavouriteProgrammingLanguage, bool isCommunist, Dictionary<string, Dictionary<ulong, byte>> Marks)
        {
            this.grade = grade;
            this.group = group;
            this.isCommunist = isCommunist;
            this.FavouriteProgrammingLanguage = FavouriteProgrammingLanguage;
            this.Marks = Marks;
            ++howManyPupilsAlreadyExists;
        }
        public LyceumPupil(LyceumPupil other)
        {
            this.grade = other.grade;
            this.group = other.group;
            this.isCommunist = other.isCommunist;
            this.FavouriteProgrammingLanguage = other.FavouriteProgrammingLanguage;
            this.Marks = other.Marks;
            ++howManyPupilsAlreadyExists;
        }
        public void Expel()
        {
            if (isExpelled)
            {
                throw new YouCantExpelMeTwice();
            }
            isExpelled = true;
        }
        public void Reestablish()
        {
            isExpelled = false;
        }

    }
}
