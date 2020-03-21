using pdfforge.DataStorage;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clawSoft.clawPDF.Core.Settings
{
    public class ServerSetting
    {
        public ServerSetting()
        {
            Init();
        }

        public String ApiUrl { get; set; }

        private void Init()
        {
            ApiUrl = "";
        }

        public void ReadValues(Data data, string path)
        {
           
            try
            {
                ApiUrl = Data.UnescapeString(data.GetValue(@"" + path + @"ApiUrl"));
            }
            catch
            {
                ApiUrl = "";
            }
        }

        public void StoreValues(Data data, string path)
        {
            data.SetValue(@"" + path + @"ApiUrl", Data.EscapeString(ApiUrl));
        }

        public ServerSetting Copy()
        {
            var copy = new ServerSetting();
            copy.ApiUrl = ApiUrl;

            return copy;
        }

        public override bool Equals(object o)
        {
            if (!(o is ServerSetting)) return false;
            var v = o as ServerSetting;

            if (!ApiUrl.Equals(v.ApiUrl)) return false;

            return true;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("ApiUrl=" + ApiUrl);
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            // ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
            return base.GetHashCode();
        }

        // Custom Code starts here
        // START_CUSTOM_SECTION:GENERAL
        // END_CUSTOM_SECTION:GENERAL
        // Custom Code ends here. Do not edit below
    }
}
