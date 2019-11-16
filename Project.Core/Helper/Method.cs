using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Helper
{
    public class Method
    {
        public static int store_ID { get; set; }
        public static List<Entities.Genders> GetGender() {
            List<Entities.Genders> _gender = new List<Entities.Genders>() {
                new Entities.Genders{ID=1,Name="Kadın"},
                new Entities.Genders{ID=2,Name="Erkek"},
            };
            return _gender;
        }
        public static List<Entities.Job> GetJobs() {
            List<Entities.Job> _jobs = new List<Entities.Job>()
            {
                new Entities.Job{ID=1,Name="Mühendis (Engineer"},
                new Entities.Job{ID=2,Name="Öğretmen (Teacher)"},
                new Entities.Job{ID=3,Name="Sporcu (Sportsman)"},
                new Entities.Job{ID=4,Name="Serbest Meslek (Self-Employed)"},
                new Entities.Job{ID=5,Name="İç/Dış Görevli (SoldierOrPoliceOrOfficer)"},
                new Entities.Job{ID=6,Name="Sağlık Görevlisi (Health Officer)"},
                new Entities.Job{ID=7,Name="Sanatçı (Artist)"},
                new Entities.Job{ID=8,Name="Uzman (Expert)"},
                new Entities.Job{ID=9,Name="Çalışmıyor (Unemployed)"},
                new Entities.Job{ID=11,Name="Şirket Sahibi (Company Owner)"},
                new Entities.Job{ID=12,Name="Diğer (Other)"}
            };
            return _jobs;
        }
    }
}
