using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.IO;
using System.Xml.Serialization;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("candidates.xml", FileMode.OpenOrCreate);
            var s1 = new Student("Alex1", new Knowledge(80));
            var s2 = new Student("Alex2", new Knowledge(0));
            var s3 = new Student("Alex3", new Knowledge(100));
            Student[] stud = new Student[] { s1, s2, s3 };
            XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
            using (fs)
            {
                formatter.Serialize(fs, stud);
            }


            var s = new Student("Alex");

            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko", new Knowledge(80)));
            university.AddStudent(new Student("Julia Veselkina", new Knowledge(70)));
            university.AddStudent(new Student("Maria Perechrest", new Knowledge(60)));
            s.SetKnowledge(new Knowledge(80));


            Internship internship = new Internship("Interlink");
            internship.candidates = university.students;
            internship.candidates.Add(s);
            internship.GetCandidatesFrom(fs = new FileStream("candidates.xml", FileMode.OpenOrCreate));
            internship.GetStudents(university, internship.candidates);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.ShowBestStudents());
            Console.ReadLine();
        }
    }
}
