﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyceumPupil
{
    class LyceumPupil
    {
        public class YouCantExpelMeTwice : Exception
        {
            public YouCantExpelMeTwice()
            { }
        }
        public class SubjectDoesNotExist : Exception
        {
            public SubjectDoesNotExist()
            { }
        }
        static ushort howManyPupilsAlreadyExists = 0;
        int grade, group;
        bool isExpelled;
        string favouriteProgrammingLanguages;
        bool isCommunist;
        string MainOS;
        Dictionary<string, Dictionary<ulong, byte>> Marks;
        public LyceumPupil()
        {
            this.isCommunist = true;
            this.favouriteProgrammingLanguages = "C++";
            this.Marks = new Dictionary<string, Dictionary<ulong, byte>>();
            this.group = 5;
            ++howManyPupilsAlreadyExists;
            this.MainOS = "Windows10";
        }
        public LyceumPupil(int grade, int group)
        {
            this.grade = grade;
            this.group = group;
            this.isCommunist = true;
            this.favouriteProgrammingLanguages = "C++";
            this.Marks = new Dictionary<string, Dictionary<ulong, byte>>();
            ++howManyPupilsAlreadyExists;
            this.MainOS = "Windows10";
        }
        public LyceumPupil(int grade, int group, string FavouriteProgrammingLanguage, bool isCommunist, string OS)
        {
            this.grade = grade;
            this.group = group;
            this.isCommunist = true;
            this.favouriteProgrammingLanguages = FavouriteProgrammingLanguage;
            this.Marks = new Dictionary<string, Dictionary<ulong, byte>>();
            ++howManyPupilsAlreadyExists;
            this.MainOS = OS;
        }
        public LyceumPupil(int grade, int group, string FavouriteProgrammingLanguage, bool isCommunist, string OS, Dictionary<string, Dictionary<ulong, byte>> Marks)
        {
            this.grade = grade;
            this.group = group;
            this.isCommunist = isCommunist;
            this.favouriteProgrammingLanguages = FavouriteProgrammingLanguage;
            this.Marks = Marks;
            ++howManyPupilsAlreadyExists;
            this.MainOS = OS;
        }
        public LyceumPupil(LyceumPupil other)
        {
            this.grade = other.grade;
            this.group = other.group;
            this.isCommunist = other.isCommunist;
            this.favouriteProgrammingLanguages = other.favouriteProgrammingLanguages;
            this.Marks = other.Marks;
            ++howManyPupilsAlreadyExists;
            this.MainOS = other.MainOS;
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
        public void AddMark(string subject, ulong date, byte mark)
        {
            if (!(Marks.ContainsKey(subject)))
            {
                Marks.Add(subject, new Dictionary<ulong, byte>());
            }
            Marks[subject].Add(date, mark);
        }
        public void RemoveMark(string subject, ulong date)
        {
            if (!(Marks.ContainsKey(subject)))
            {
                throw new SubjectDoesNotExist();
            }
            Marks[subject].Remove(date);
        }
        public List<byte> GetSubjectMarks(string subject) => Marks[subject].Values.ToList();
        public List<byte> GetAllMarks()
        {
            List<byte> result = new List<byte>();
            foreach(var x in Marks.Values.ToList())
            {
                result.AddRange(x.Values.ToList());
            }
            return result;
        }
        public bool IsPetrushka
        {
            get
            {
                foreach(var mark in Marks["PE"])
                {
                    if (mark.Value <= 2)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public bool IsNikolayRekut
        {
            get => (isCommunist == false && favouriteProgrammingLanguages == "JavaScript" && Marks["History"].ContainsValue(5));
        }
        public bool IsTrueProgger
        {
            get => "C++, Assembly language, Bash".Contains(FavouriteProgrammingLanguage) && MainOS == "Linux" && IsCommunist && grade >= 9 && !(isExpelled);
        }
        public void ChangeOS(string newSO)
        {
            MainOS = newSO;
        }
        public bool IsCommunist
        {
            get => isCommunist;
            set => isCommunist = value;
        }
        public string FavouriteProgrammingLanguage
        {
            get => favouriteProgrammingLanguages;
            set => favouriteProgrammingLanguages = value;
        }
        public int CountMarks
        {
            get
            {
                int result = 0;
                foreach(var subj in Marks)
                {
                    ++result;
                }
                return result;
            }
        }
        public int CountSubjects
        {
            get => Marks.Count;
        }
        public int Group
        {
            get => group;
            set => group = value;
        }
        public int Grade
        {
            get => grade;
            set => grade = value;
        }
        public static ushort CountPupils()
        {
            return howManyPupilsAlreadyExists; 
        }
    }
}
