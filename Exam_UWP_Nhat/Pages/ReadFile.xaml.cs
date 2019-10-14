using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Exam_UWP_Nhat.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReadFile : Page
    {
        public ReadFile()
        {
            this.InitializeComponent();
            SaveFile saveFile = new SaveFile();
           

            readFileFromSave(saveFile.savefile);
        }

        private void readFileFromSave(string saveFile)
        {
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = storageFolder.GetFileAsync(saveFile).GetAwaiter().GetResult();
            var text = Windows.Storage.FileIO.ReadTextAsync(sampleFile).GetAwaiter().GetResult();
            this.label1.Text = text;
        }

    }
}
