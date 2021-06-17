using GeekAssistant.Forms;
using System;
using System.Windows.Forms;

namespace GeekAssistant.Modules.General {
    class Update_GUI {

        private void progressBar(int percent = 0) {
            ObjectInForm<Home, ProgressBar, int>(c.Home, c.Home.bar, nameof(c.Home.bar.Value), percent);
        }
        private void ObjectInForm<formType, objType, propType>(formType form, objType obj, string propName, propType value) where formType : Form {
            var propInfo = obj.GetType().GetProperty(propName);
            propInfo.SetValue(propName, value);

            form.Invoke(new Action(() => {
                var propInfo = obj.GetType().GetProperty(propName);
                propInfo.SetValue(propName, value);
            }));
        }

    }
}
