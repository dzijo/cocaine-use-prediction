using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUAP.Models
{
    public class Patient
    {
        public Patient()
        {

        }
        public Patient(FormMain.Patient sendData, double coke, int doctorId)
        {
            Age = sendData.Age;
            Gender = sendData.Gender;
            Education = sendData.Education;
            Country = sendData.Country;
            Ethnicity = sendData.Ethnicity;
            Nscore = sendData.Nscore;
            Escore = sendData.Escore;
            Oscore = sendData.Oscore;
            Ascore = sendData.Ascore;
            Cscore = sendData.Cscore;
            Impulsive = sendData.Impulsive;
            Ss = sendData.Ss;
            Date = DateTime.Now;
            Coke = coke;
            DoctorId = doctorId;
        }

        public FormMain.Patient ToPatient()
        {
            return new FormMain.Patient()
            {
                PatientID = this.Id,
                Age = this.Age,
                Gender = this.Gender,
                Education = this.Education,
                Country = this.Country,
                Ethnicity = this.Ethnicity,
                Nscore = this.Nscore,
                Escore = this.Escore,
                Oscore = this.Oscore,
                Ascore = this.Ascore,
                Cscore = this.Cscore,
                Impulsive = this.Impulsive,
                Ss = this.Ss,
                Coke = this.Coke                
            };
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string Country { get; set; }
        public string Ethnicity { get; set; }
        public double Nscore { get; set; }
        public double Escore { get; set; }
        public double Oscore { get; set; }
        public double Ascore { get; set; }
        public double Cscore { get; set; }
        public double Impulsive { get; set; }
        public double Ss { get; set; }
        public DateTime Date { get; set; }
        public double Coke { get; set; }
        public int DoctorId { get; set; }
    }
}
