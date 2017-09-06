namespace Async
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Net.Http;
    using System.Diagnostics;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // You need to add a reference to System.Net.Http to declare client.  
            var client = new HttpClient();

            // GetStringAsync returns a Task<string>. That means that when you await the  
            // task you'll get a string (urlContents).  
            var getStringTask = client.GetStringAsync("http://msdn.microsoft.com");
            Debug.WriteLine($"getStringTask.Result.Substring(0, 50): {getStringTask.Result.Substring(0, 50)}");

            // You can do work here that doesn't rely on the string from GetStringAsync.
            DoIndependentWork(getStringTask);
            Debug.WriteLine($"getStringTask.Result.Substring(0, 50): {getStringTask.Result.Substring(0, 50)}");

            // The await operator suspends AccessTheWebAsync.  
            //  - AccessTheWebAsync can't continue until getStringTask is complete.  
            //  - Meanwhile, control returns to the caller of AccessTheWebAsync.  
            //  - Control resumes here when getStringTask is complete.   
            //  - The await operator then retrieves the string result from getStringTask.  
            var urlContents = await getStringTask;
            Debug.WriteLine($"getStringTask.Result.Substring(0, 50): {getStringTask.Result.Substring(0, 50)}");

            // The return statement specifies an integer result.  
            // Any methods that are awaiting AccessTheWebAsync retrieve the length value.  
            //return urlContents.Length;
        }

        private void DoIndependentWork(Task<string> taskRes)
        {
            Debug.WriteLine($"taskRes.Result.Substring(0, 50): {taskRes.Result.Substring(0, 50)}");
        }
    }
}
