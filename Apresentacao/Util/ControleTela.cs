using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Util
{
    static public class ControleTela
    {
       
        static internal void LimpaCampos(ContainerControl _form)
        {
            foreach (var textBox in _form.Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<TextBox>()))
            {
                textBox.Text = "";
            }
            foreach (var checkBox in _form.Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<CheckBox>()))
            {
                checkBox.Checked = false;
            }
        }
    }
}
