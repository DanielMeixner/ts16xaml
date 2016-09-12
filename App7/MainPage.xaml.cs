using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SetFocusInLoogAsync();
        }

        private async Task SetFocusInLoogAsync()
        {
            await Task.Delay(2000);

            int i = 0;
            while (i++ < 40)
            {
                await Task.Delay(1000);
                switch (i%6)
                {
                    case 0:
                        tb1.Focus(FocusState.Programmatic);
                        break;
                    case 1:
                        HiddenElement.Focus(FocusState.Programmatic);
                        break;
                    case 2:
                        tb3.Focus(FocusState.Programmatic);
                        break;
                    case 3:
                        tb4.Focus(FocusState.Programmatic);
                        break;
                    case 5:
                        tb5.Focus(FocusState.Programmatic);
                        break;

                    default:
                        tb6.Focus(FocusState.Programmatic);
                        break;
                }
                
            }
        }

        private void tb3_Click(object sender, RoutedEventArgs e)
        {
            SetFocusInLoogAsync();
        }
    }
}
