using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace RUAP
{
    public partial class FormMain : Form
    {
        public static string text = "";
        public static double predictionResult = 0;
        public List<Patient> results;
        DBContext dbcontext;
        int doctorId;

        public FormMain()
        {
            InitializeComponent();
            dbcontext = new DBContext();
            comboBoxAge.SelectedIndex = 0;
            comboBoxCountry.SelectedIndex = 0;
            comboBoxEducation.SelectedIndex = 0;
            comboBoxEthnicity.SelectedIndex = 0;
            comboBoxGender.SelectedIndex = 0;
            this.chartResults.GetToolTipText += this.chartResults_GetToolTipText;
            foreach (Control c in this.Controls)
            {
                if (c is TrackBar)
                {

                }
            }
            results = new List<Patient>();
            comboBoxPeriod.SelectedIndex = 0;
            comboBoxShowByAge.SelectedIndex = 0;
            doctorId = FormLogin.doctorId;
        }
        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }

        public class Patient
        {
            public int PatientID { get; set; } = 0;
            public string Age { get; set; } = "12";
            public string Gender { get; set; } = "12";
            public string Education { get; set; } = "12";
            public string Country { get; set; } = "12";
            public string Ethnicity { get; set; } = "12";
            public double Nscore { get; set; } = 0;
            public double Escore { get; set; } = 0;
            public double Oscore { get; set; } = 0;
            public double Ascore { get; set; } = 0;
            public double Cscore { get; set; } = 0;
            public double Impulsive { get; set; } = 0;
            public double Ss { get; set; } = 0;
            public double Coke = 0.4;
            public DateTime Date = DateTime.Now;

            public string[,] GetValues()
            {
                return new string[,] { { Age, Gender, Education, Country, Ethnicity, Nscore.ToString(), Escore.ToString(), Oscore.ToString(), Ascore.ToString(), Cscore.ToString(), Impulsive.ToString(), Ss.ToString(), "N" } };
            }
            public string PrintValues()
            {
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                nfi.PercentDecimalDigits = 0;
                string result = "";

                result += "Patient ID: " + PatientID.ToString() + "\n";

                result += "Age: " + Age + "\n";
                result += "Gender: " + Gender + "\n";
                result += "Education: " + Education + "\n";
                result += "Country: " + Country + "\n";
                result += "Ethnicity: " + Ethnicity + "\n";

                result += "Nscore: " + (((Nscore + 3.46436) / 6.73829) * 48 + 12).ToString() + "\n";
                result += "Escore: " + (((Escore + 3.88303) / 7.30924) * 48 + 12).ToString() + "\n";
                result += "Oscore: " + (((Oscore + 5.33244) / 8.23405) * 48 + 12).ToString() + "\n";
                result += "Ascore: " + (((Ascore + 3.46436) / 6.92872) * 48 + 12).ToString() + "\n";
                result += "Cscore: " + (((Cscore + 4.28921) / 7.91854) * 48 + 12).ToString() + "\n";
                result += "Impulsive: " + (((Impulsive + 2.55524) / 5.45685) * 90 + 30).ToString() + "\n";
                result += "SS: " + ((Ss + 2.07848) / 4.00021).ToString("P", nfi) + "\n";
                result += "User: ";
                result += Coke > 0.5 ? "Y\n" : "N\n";
                result += "Date: " + Date.ToString("dd/MM/yyyy") + "\n";

                return result;
            }
        }

        static async Task InvokeRequestResponseService(Patient input)
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {"age", "gender", "education", "country", "ethnicity", "nscore", "escore", "oscore", "ascore", "cscore", "impulsive", "ss", "coke"},
                                Values = input.GetValues()
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                const string apiKey = "FimRUq4cCbXjLJF1ZEN/pLQlV/DttL3yZCs6UX131Q9XoGuS/CHjgCr71Xqlmy7G2/WNM5D1R/Q230rNpCSTAQ=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/5385e7a32da24a7a9ae7f163cdd6d948/services/0ec6c82976e9434781c99ca13bec0753/execute?api-version=2.0&details=true");

                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)


                //HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest).ConfigureAwait(false);

                HttpResponseMessage response = await client
                    .PostAsync("", new StringContent(JsonConvert.SerializeObject(scoreRequest), Encoding.UTF8, "application/json"))
                    .ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    double.TryParse(result.Substring(result.IndexOf("\",\"0.") + 3, 6), out predictionResult);
                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }
            }
        }

        private void buttonPredict_Click(object sender, EventArgs e)
        {
            var input = new Patient
            {
                Age = comboBoxAge.SelectedItem.ToString(),
                Gender = comboBoxGender.SelectedItem.ToString(),
                Education = comboBoxEducation.SelectedItem.ToString(),
                Country = comboBoxCountry.SelectedItem.ToString(),
                Ethnicity = comboBoxEthnicity.SelectedItem.ToString(),
                Nscore = -3.46436 + (trackBarN.Value - 12) / 48.0 * 6.73829,
                Escore = -3.88303 + (trackBarE.Value - 12) / 48.0 * 7.30924,
                Oscore = -5.33244 + (trackBarO.Value - 12) / 48.0 * 8.23405,
                Ascore = -3.46436 + (trackBarA.Value - 12) / 48.0 * 6.92872,
                Cscore = -4.28921 + (trackBarC.Value - 12) / 48.0 * 7.91854,
                Impulsive = -2.55524 + (trackBarI.Value - 30) / 90.0 * 5.45685,
                Ss = -2.07848 + trackBarSS.Value / 100.0 * 4.00021
            };
            InvokeRequestResponseService(input).Wait();
            dbcontext.Patients.Add(new Models.Patient(input, predictionResult, doctorId));
            dbcontext.SaveChanges();
            EditResultText();
        }

        private void EditResultText()
        {
            if (predictionResult > 0.8) labelResult.Text = "Pacient has extremely high chance of being a user or becoming one. " +
                    "I hope you didn't need this app to tell you that.";
            else if (predictionResult > 0.6) labelResult.Text = "There's a very high chance the pacient is a user or has a very high risk of becoming one.";
            else if (predictionResult > 0.5) labelResult.Text = "This pacient has decent chance for cocaine use.";
            else if (predictionResult > 0.4) labelResult.Text = "Pacient probably doesn't use, but there is some risk of becoming a user.";
            else if (predictionResult > 0.2) labelResult.Text = "Pacient has really low chance for cocaine use. There's no need for concern";
            else labelResult.Text = "Pacient has extremely low chance for cocaine use.";
        }

        private void chartResults_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            switch (e.HitTestResult.ChartElementType)
            {
                case ChartElementType.DataPoint:
                    var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                    e.Text = results[(int)dataPoint.XValue].PrintValues();
                    break;
            }
        }

        private void UpdateGraph()
        {
            chartResults.Series["Result"].Points.Clear();
            results.Clear();
            int i = 0;
            int months;
            switch (comboBoxPeriod.SelectedIndex)
            {
                case (0):
                    months = 1;
                    break;
                case (1):
                    months = 6;
                    break;
                case (2):
                    months = 12;
                    break;
                case (3):
                    months = 60;
                    break;
                default:
                    months = 0;
                    break;
            }
            DateTime date;
            if (months != 0) date = DateTime.Now.AddMonths(-months);
            else date = DateTime.MinValue;
            var age = comboBoxShowByAge.Text;
            List<Models.Patient> patients;
            if (age == "All ages") patients = dbcontext.Patients.Where(x => x.Date >= date && x.DoctorId == doctorId).ToList();
            else patients = dbcontext.Patients.Where(x => x.Date >= date && x.DoctorId == doctorId && x.Age == age).ToList();

            foreach (var a in patients)
            {
                results.Add(a.ToPatient());
                chartResults.Series["Result"].Points.AddXY(i, a.Coke);
                chartResults.Series["Result"].Points[i].Color = Color.FromArgb((int)(a.Coke * 255), (int)((1 - a.Coke) * 255), 0);
                ++i;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            toolTip1.Show(trackBar.Value.ToString(), this, point: PointToClient(System.Windows.Forms.Cursor.Position), duration: 1000);
        }

        private void buttonUpdateGraph_Click(object sender, EventArgs e)
        {
            UpdateGraph();
        }
    }
}
