using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SDILReader;

namespace MSIL
{
    public partial class frmAssemblies : Form
    {
        private Assembly assembly;
        private List<Type> types = new List<Type>();
        private Dictionary<Type, IEnumerable<MethodInfo>> methods = new Dictionary<Type, IEnumerable<MethodInfo>>();

        public frmAssemblies()
        {
            InitializeComponent();
            gvILInstructions.AutoGenerateColumns = false;
            tbAssemblyName.Text = @"C:\temp\mscorlib.dll";
            ReadAndShowAssemblyInfo(tbAssemblyName.Text);
            cbTypes.SelectedIndex = 2577;
            cbMethods.SelectedIndex = 20;
            cbMethods_SelectedIndexChanged(null, null);
        }

        private void tbAssemblyName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAssemblyName.Text)) return;
            ReadAndShowAssemblyInfo(tbAssemblyName.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog _openFileDialog = new OpenFileDialog() { DefaultExt = ".dll" })
                {
                    if ((!string.IsNullOrWhiteSpace(tbAssemblyName.Text)) && Directory.Exists(Path.GetDirectoryName(tbAssemblyName.Text)))
                    {
                        _openFileDialog.InitialDirectory = tbAssemblyName.Text;
                    }
                    if (_openFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(_openFileDialog.FileName)) return;
                    tbAssemblyName.Text = _openFileDialog.FileName;
                    ReadAndShowAssemblyInfo(tbAssemblyName.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("A problem occured while loading assembly {0}.{1}Exception data:{1}{2}", tbAssemblyName.Text, Environment.NewLine, ex.ToString()),
                                "Problem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void ReadAndShowAssemblyInfo(string inAssemblyFileName)
        {
            Cursor _currentCursor = Cursor.Current;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.types.Clear();
                this.methods.Clear();
                this.assembly = Assembly.LoadFrom(inAssemblyFileName);
                this.types = MethodsHelper.GetTypes(this.assembly);
                ShowTypes();
            }
            finally
            {
                Cursor.Current = _currentCursor;
            }
        }

        private void ShowTypes()
        {
            cbTypes.DisplayMember = "mTypeName";
            cbTypes.ValueMember = "mType";
            cbTypes.DataSource = this.types.Select(t => new { mTypeName = t.Name, mType = t }).ToList();
            cbTypes.AutoCompleteCustomSource.AddRange(this.types.Select(t => t.Name).ToArray());
        }

        public void ShowMethods(Type selectedType)
        {
            if (!this.methods.ContainsKey(selectedType))
            {
                this.methods.Add(selectedType, MethodsHelper.GetMethodInfos(selectedType));
            }
            cbMethods.ValueMember = "mMethodInfo";
            cbMethods.DisplayMember = "mMethodName";
            var _ds  = this.methods[selectedType].Select(m => new { mMethodInfo = m, mMethodName = m.ToString() }).ToList();
            cbMethods.DataSource = _ds;
            cbMethods.AutoCompleteCustomSource.AddRange(_ds.Select(s => s.mMethodName).ToArray());
        }

        private void Show_ILInstructions(MethodInfo inMethodInfo)
        {
            gvILInstructions.DataSource = MethodsHelper.GetILInstructions(inMethodInfo);
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = cbTypes.SelectedIndex.ToString();
            if (!(cbTypes.SelectedValue is Type)) return;
            try
            {
                ShowMethods(cbTypes.SelectedValue as Type);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("A problem occured while displaying IL instuctions.{0}Assembly: {1}{0}Type: {2}{0}Exception data: {3}",
                    Environment.NewLine, this.assembly.FullName, cbTypes.Text, ex.ToString()),
                "Problem",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }

        private void cbMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbMethods.SelectedValue is MethodInfo)) return;
            try
            {
                MethodInfo _methodInfo = cbMethods.SelectedValue as MethodInfo;
                if (_methodInfo.IsGenericMethod)
                {
                    Type _type = _methodInfo.DeclaringType;
                    _methodInfo = _type.GetMethod(_methodInfo.Name, _methodInfo.GetGenericArguments());
                }
                Show_ILInstructions(_methodInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("A problem occured while displaying IL instuctions.{0}Assembly: {1}{0}Type: {2}{0}Method: {3}{0}Exception data:{4}",
                    Environment.NewLine, this.assembly.FullName, cbTypes.Text, cbMethods.Text, ex.ToString()),
                "Problem",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnSearchTypeAndMethod_Click(object sender, EventArgs e)
        {
            Cursor _currentCursor = Cursor.Current;
            string _className = string.Empty;
            string _methodName = string.Empty;
            Type _type = null;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var _words = tbManualEntry.Text.Split(new char[] { '.' });
                if (_words.Length != 2)
                {
                    throw new ArgumentException("The manual entry pattern should be [ClassName.Method]!");
                }
                _className = _words[0];
                _methodName = _words[1];
                _type = this.types.Single(t => t.Name == _className);
                MethodInfo _methodInfo = _type.GetMethod(_methodName);
                if (_methodInfo == null)
                {
                    throw new NullReferenceException(string.Format("The type {0} doesn't have a method named {1}", _className, _methodName));
                }
                Show_ILInstructions(_methodInfo);
            }
            catch (InvalidOperationException iopex)
            {
                MessageBox.Show(string.Format("The assembly {0} doesn't have a type named {1}", this.assembly.FullName, _className),
                                "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AmbiguousMatchException ambex)
            {
                cbTypes.SelectedValue = _type;
                MessageBox.Show(string.Format("The type {0} contains more than one method named {1}. Please, use the combobox to select the exact method.",
                                              _className, _methodName), "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMethods.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = _currentCursor;
            }
        }
    }
}
