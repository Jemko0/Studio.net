using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioDotNet
{
    class FormManager : ApplicationContext
    {
        //When each form closes, close the application if no other open forms
        private void OnFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }

        public Dictionary<string, Form> openForms = new Dictionary<string, Form>();

        public void CreateMainForm()
        {
            Form mainForm = Program.formManager.CreateForm<StudioForm>("studio");
            mainForm.Show();
        }

        public T CreateForm<T>(string k) where T : Form, new()
        {
            var ret = new T();
            openForms.Add(k, ret);
            ret.FormClosed += OnFormClosed;
            return ret;
        }
    }
}
