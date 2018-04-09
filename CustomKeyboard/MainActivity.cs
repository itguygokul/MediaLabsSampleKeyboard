using Android.App;
using Android.Widget;
using Android.OS;
using Android.InputMethodServices;
using Java.Lang;
using Android.Runtime;
using Android.Views;
using Android.Media;

namespace CustomKeyboard
{

    [Service(Permission = "android.permission.BIND_INPUT_METHOD", Label = "MEDIA LABS SAMPLE")]
    [MetaData("android.view.im", Resource = "@xml/method")]
    [IntentFilter(new string[] { "android.view.InputMethod" })]
    public class MainActivity : InputMethodService, KeyboardView.IOnKeyboardActionListener
    {

        private KeyboardView keyboardView;
        private Keyboard Keyboard;
        private bool isCaps = false;

        public override View OnCreateInputView()
        {
            keyboardView = (KeyboardView)LayoutInflater.Inflate(Resource.Layout.keyboard, null);
            Keyboard = new Keyboard(this, Resource.Xml.qwerty);
            keyboardView.Keyboard = Keyboard;
            keyboardView.OnKeyboardActionListener = this;
            return keyboardView;
            //return null;
        }




        public void OnKey([GeneratedEnum] Android.Views.Keycode primaryCode, [GeneratedEnum] Android.Views.Keycode[] keyCodes)
        {
           
        }

        public void OnPress([GeneratedEnum] Android.Views.Keycode primaryCode)
        {
           
        }

        public void OnRelease([GeneratedEnum] Android.Views.Keycode primaryCode)
        {
            
        }

        public void OnText(ICharSequence text)
        {
            
        }

        public void SwipeDown()
        {
           
        }

        public void SwipeLeft()
        {
           
        }

        public void SwipeRight()
        {
            
        }

        public void SwipeUp()
        {
           
        }

        //private void playClick(int keyCode)
        //{
        //    AudioManager am = (AudioManager)GetSystemService(AudioService);
        //    switch (keyCode)
        //    {
        //        case 32:
        //            am.PlaySoundEffect(SoundEffect.Spacebar);
        //            break;
        //        //case Keyboard.Keys.:
        //        case 10:
        //            am.playSoundEffect(SoundEffect.Return);
        //            break;
        //        case Keyboard.KEYCODE_DELETE:
        //            am.playSoundEffect(SoundEffect.Delete);
        //            break;
        //        default: am.playSoundEffect(SoundEffect.Standard);
        //    }
        //}
    }
}

