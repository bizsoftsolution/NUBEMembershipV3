using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.App.Services
{
    public class MessageBox
    {
        public bool MsgBoxShow { get; set; } = false;
        public bool MsgBoxIsConfirm { get; set; } = false;
        public string MsgBoxTitle { get; set; } = "";
        public string MsgBoxMessage { get; set; } = "";
        public Func<bool> MsgOnOk { get; set; } = () => { return false; };
        public Func<bool> MsgOnCancel { get; set; } = () => { return false; };

        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();

        public void ShowMessage(string Title, string Message, Func<bool> MsgOk = null, Func<bool> MsgCancel = null)
        {
            MsgBoxTitle = Title;
            MsgBoxMessage = Message;
            MsgBoxShow = true;
            MsgBoxIsConfirm = (MsgOk != null || MsgCancel != null);
            MsgOnOk = (MsgOk != null) ? MsgOk : OkMessage;
            MsgOnCancel = (MsgCancel != null) ? MsgCancel : HideMessage;
            NotifyStateChanged();
        }

        public bool HideMessage()
        {
            MsgBoxShow = false;
            NotifyStateChanged();
            return MsgBoxShow;
        }
        bool OkMessage()
        {
            return HideMessage();
        }
    }
}
