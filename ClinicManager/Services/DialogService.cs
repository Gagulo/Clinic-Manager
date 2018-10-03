using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Services
{
    class DialogService
    {
        private PatientDetailView _patientsDetailView;

        public void ShowPatientsDetailDialog()
        {
            _patientsDetailView = new PatientDetailView();
            _patientsDetailView.ShowDialog();
        }

        public void ClosePatientsDetailDialog()
        {
            _patientsDetailView.Close();
        }
    }
}
