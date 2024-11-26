using System;
using System.Collections.Generic;
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

            if (sender.Equals(GetForm("studio")))
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

        public Form GetForm(string id)
        {
            return openForms[id];
        }

        public T GetForm<T>(string id) where T : Form, new()
        {
            return openForms[id] as T;
        }

        /// <summary>
        /// Creates a Form (does not display it to the user)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="k"></param>
        /// <returns>Created Form, if Form already exists, finds the Form and returns it</returns>
        public T CreateForm<T>(string k) where T : Form, new()
        {
            T ret = new T();

            if (!openForms.ContainsValue(ret) && !openForms.ContainsKey(k))
            {
                openForms.Add(k, ret);
                ret.FormClosed += OnFormClosed;
                return ret;
            }

            ret = GetForm<T>(k);
            ret.BringToFront();
            ret.Focus();
            return ret;
        }
    }
}
