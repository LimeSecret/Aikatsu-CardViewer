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
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1
    {
        private void MiseLoad()
        {
            string miseurl1 = "http://az416740.vo.msecnd.net/static-images/particulate_matter/";
            string miseurl2 = "/japan_detail/large.jpg";
            string dir = AppDomain.CurrentDomain.BaseDirectory + @"\resources\";
            try
            {
                using (WebClient client = new WebClient())
                {
                    try { client.DownloadFile(miseurl1 + MiseCurr + miseurl2, dir + "mise" + MiseCurr % 2); }
                    catch { MessageBox.Show(" 이미지를 다운로드하는데 실패했습니다."); }

                }
                MisePicture.Load(dir + "mise" + MiseCurr % 2);
            }
            catch
            {
                MessageBox.Show(" 이미지를 불러오는데 실패했습니다.");
            }
        }
    }
}
