using System.Globalization;
using System.Resources;

namespace Compu_Pos.Services
{
    public class languagesSwitch
    {
        public languagesSwitch(string lang, Type T)
        {
            rm = new ResourceManager("Compu_Pos.language.language", T.Assembly);
            culture = new CultureInfo(lang);
        }

        ResourceManager rm;
        CultureInfo culture;

        public void setLanguages(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is ToolStrip)
                {
                    var ctr = (ToolStrip)control;
                    foreach (ToolStripItem it in ctr.Items)
                    {
                        if (!string.IsNullOrEmpty(it.AccessibleName))
                        {
                            it.Text = rm.GetString(it.AccessibleName, culture);
                        }
                        if (string.IsNullOrEmpty(it.Text))
                        {
                            it.Text = it.AccessibleName;
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(control.AccessibleName))
                    {
                        control.Text = rm.GetString(control.AccessibleName, culture);
                        if (string.IsNullOrEmpty(control.Text))
                        {
                            control.Text = control.AccessibleName;
                        }
                    }
                    if (control.Controls.Count > 0)
                    {
                        setLanguages(control.Controls);
                    }
                }
            }
        }
    }
}
