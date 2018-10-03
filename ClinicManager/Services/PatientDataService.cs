using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManager.Model;
using Newtonsoft.Json;

namespace ClinicManager.Services
{
    class PatientDataService
    {
        public List<Patient> GetAllPateints()
        {
            return LoadFromFile().ToList();
        }

        public void DeletePatient(Patient toBeDeleted)
        {
            
        }

        public void UpdatePatient(Patient toBeUpdated)
        {

        }

        private Patient[] LoadFromFile()
        {
            var allText = File.ReadAllText("samplePatients.json");
            var jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings()
            {
                DateFormatString = "dd/MM/yyyy"
            });
            var patients = jsonSerializer.Deserialize<List<Patient>>(new JsonTextReader(new StringReader(allText)));
            for (var i = 0; i < patients.Count; i++)
            {
                var patient = patients[i];
                patient.Photo = GetPhotoForUser(patient);
            }

            return patients.ToArray();
        }

        private static string GetPhotoForUser(Patient patient)
        {
            return patient.InsuranceNumber.Last() % 2 == 0 ? "Photos/male.png" : "Photos/female.png";
        }
    }
}
