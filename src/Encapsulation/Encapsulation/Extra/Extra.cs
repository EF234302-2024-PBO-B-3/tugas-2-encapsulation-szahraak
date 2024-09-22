using System;
using System.Runtime.CompilerServices;

namespace Encapsulation.Extra
{



    /*
     * Tuliskan spesifikasi soal Anda disini. 
     * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
     */

    // Tulis disini
    /* Buatlah sebuah kelas bernama Student yang menyimpan atribut private, yaitu _name (string), _studentID (string), dan _finalGrade (double).
     * Sediakan properti publik dengan metode set dan metode get untuk masing-masing atribut Name, StudentID, dan FinalGrade. Properti FinalGrade tidak boleh menerima nilai negatif dan bernilai antara 0 - 100. Jika input tidak memenuhi syarat, set nilainya ke 0.0.
     * Sediakan sebuah konstruktor yang menginisialisasi ketiga atribut tersebut. Di konstruktor, pastikan parameter name dan studentID divalidasi tidak null atau string kosong. Jika input tidak valid, atur nilainya menjadi "Unknown".
     * Buat metode CalculateGrade dengan parameter midtermScore dan finalExamScore (keduanya bertipe double). Metode ini harus menghitung nilai akhir sebagai rata-rata dari nilai UTS dan nilai UAS, dan menetapkan hasilnya ke atribut _finalGrade. Pastikan nilai midtermScore dan finalExamScore berada dalam rentang 0 - 100. Jika salah satu nilainya tidak valid, maka nilai akhir tidak boleh dihitung, dan set _finalGrade menjadi 0.0.
     * Buat metode DisplayStudentInfo yang menampilkan informasi mahasiswa dalam format "Nama: {Nama}, NRP: {StudentID}, Nilai: {FinalGrade}"..
     */

    /*
     * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
     */

    // Tulis disini

    public class Student
    {
        private string _name;
        private string _studentID;
        private double _finalGrade;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }
        public double FinalGrade
        {
            get { return _finalGrade; }
            set
            {
                if (value < 0 || value > 100)
                {
                    _finalGrade = 0;
                }
                else
                {
                    _finalGrade = value;
                }
            }
        }

        public Student(string name, string studentID, double finalGrade)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            } else
            {
                Name = "Unknown";
            }
            if (!string.IsNullOrEmpty(studentID))
            {
                StudentID = studentID;
            } else
            {
                StudentID = "Unknown";
            }
            if (finalGrade < 0 || finalGrade > 100)
            {
                _finalGrade = 0;
            } else
            {
                _finalGrade = finalGrade;
            }
        }

        public double CalculateGrade(double midtermScore, double finalExamScore)
        {
            if (midtermScore < 0 || midtermScore > 100 || finalExamScore < 0 || finalExamScore > 100)
            {
                _finalGrade = 0;
                return 1;
            }
            else
            {
                _finalGrade = (midtermScore + finalExamScore) / 2;
                return 0;
            }
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Nama: {Name}, NRP: {StudentID}, Nilai: {FinalGrade}");
        }
    }
}