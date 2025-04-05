using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRTN_UI.Forms;
using SRTN_UI.Logic;

namespace SRTN_UI
{
    public class ViewManager
    {

        public ViewManager() { }

        public void ShowMainView() 
        {
            MainView mainView = new MainView();

            ((Form)mainView).Show();
        }

        public void ShowProcessTableView(KryptonPanel panelContainer)
        {
            //IPatientRecordsView patientRecordsView = PatientRecordsView.GetInstance(panelContainer);
            //IPatientRecordsRepository patientRecordsRepository = new PatientRecordsQuery(_dbManager);
            //IPatientRecordsPresenter patientRecordsPresenter = new PatientRecordsPresenter(patientRecordsView, patientRecordsRepository);
            //patientRecordsView.Presenter = patientRecordsPresenter;
            ProcessTableView processTable = ProcessTableView.GetInstance(panelContainer);

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add((Control)processTable);
            ((Control)processTable).Dock = DockStyle.Fill;
        }


    }
}
