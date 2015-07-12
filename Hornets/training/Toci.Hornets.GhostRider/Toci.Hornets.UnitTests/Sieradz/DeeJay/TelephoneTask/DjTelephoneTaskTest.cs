using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.DeeJay.TelephoneTask;

namespace Toci.Hornets.UnitTests.Sieradz.DeeJay.TelephoneTask
{
    [TestClass]
    public class DjTelephoneTaskTest
    {
        private const string PhotoCommunication = "PhotoCommunication for 1";
        private const string SmsCommunication = "SmsCommunication for 2";
        private const string VoiceCommunication = "VoiceCommunication for 3";
        private const string Null = ":D  for 4";

        private DjTelephoneCommunication _djTelephoneCommunication;
        private TextBox _textBox;
        private TraceListener _debugListener;

        [TestInitialize]
        public void Init()
        {
            _djTelephoneCommunication = new DjTelephoneCommunication();
            _textBox = new TextBox();
            _debugListener = new DjTraceListener(_textBox);
            Debug.Listeners.Add(_debugListener);
        }

        [TestCleanup]
        public void Clean()
        {
            Debug.Listeners.Remove(_debugListener);
        }

        [TestMethod]
        public void Option1ReturnsPhotoCommTest()
        {
            _djTelephoneCommunication.GetUserChoice(1);

            Assert.IsTrue(IsChosenMediumInOputput(PhotoCommunication));
        }

        [TestMethod]
        public void Option2ReturnsSmsCommTest()
        {
            _djTelephoneCommunication.GetUserChoice(2);

            Assert.IsTrue(IsChosenMediumInOputput(SmsCommunication));
        }

        [TestMethod]
        public void Option3ReturnsVoiceCommTest()
        {
            _djTelephoneCommunication.GetUserChoice(3);

            Assert.IsTrue(IsChosenMediumInOputput(VoiceCommunication));
        }

        [TestMethod]
        public void Option4ReturnsNullTest()
        {
            _djTelephoneCommunication.GetUserChoice(4);

            Assert.IsTrue(IsChosenMediumInOputput(Null));
        }

        private bool IsChosenMediumInOputput(string specificText)
        {
            return _textBox.Text.Contains(specificText);
        }
    }
}
