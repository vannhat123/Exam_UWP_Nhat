using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public sealed partial class SaveFile : Page
    {
        public string savefile;
        public string nameFile;
        public SaveFile()
        {
            this.InitializeComponent();
        }

        private void Button_Click_SaveFile(object sender, RoutedEventArgs e)
        {
            var timeNow = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
             savefile = timeNow + ".txt";
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            try
            {
                Windows.Storage.StorageFile sampleFile = storageFolder.CreateFileAsync(savefile,
                   Windows.Storage.CreationCollisionOption.ReplaceExisting).GetAwaiter().GetResult();
                Windows.Storage.FileIO.WriteTextAsync(sampleFile, this.inputtext.Text).GetAwaiter().GetResult();
                Debug.WriteLine("URL link save: " + sampleFile.Path);
                nameFile = sampleFile.Path;
            }
            catch (Exception)
            {

                throw;
            }
               


        }

        private void Button_Click_ViewNameFile(object sender, RoutedEventArgs e)
        {
            this.namefile.Text = nameFile;
        }
    }
}
