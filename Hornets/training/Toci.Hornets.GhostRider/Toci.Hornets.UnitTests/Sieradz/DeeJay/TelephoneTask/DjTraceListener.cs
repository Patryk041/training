using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Toci.Hornets.UnitTests.Sieradz.DeeJay.TelephoneTask

/* StackOverflow, Trace listener to write to a text box (WPF application)
 * http://stackoverflow.com/a/1389347
 */
{
    public class DjTraceListener : TraceListener
    {
        private TextBoxBase output;

        public DjTraceListener(TextBoxBase output)
        {
            this.Name = "Trace";
            this.output = output;
        }

        public override void Write(string message)
        {
            Action append = delegate()
            {
                output.AppendText(string.Format("[{0}] ", DateTime.Now.ToString()));
                output.AppendText(message);
            };
            if (output.InvokeRequired)
            {
                output.BeginInvoke(append);
            }
            else
            {
                append();
            }
        }

        public override void WriteLine(string message)
        {
            Write(message + Environment.NewLine);
        }
    }
}