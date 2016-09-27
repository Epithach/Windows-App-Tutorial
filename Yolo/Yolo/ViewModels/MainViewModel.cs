using DomoThink.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

/*--------------------------------------------------------
 * MainViewModel.cs
 * 
 * Version: 1.0
 * Author: Filipe
 * Created: 23/09/2016 15:15:29
 * 
 * Notes:
 * -------------------------------------------------------*/

namespace Yolo.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region FIELDS



        #endregion

        #region PROPERTIES

        private string text;
        public string TextYolo
        {
            get { return this.text; }
            set
            {
                this.text = value;
                this.OnPropertyChanged("TextYolo");
            }
        }

        private ICommand onButtonClick;
        public ICommand OnButtonClick
        {
            get { return this.onButtonClick; }
            set
            {
                this.onButtonClick = value;
                this.OnPropertyChanged("OnButtonClick");
            }
        }

        #endregion

        #region CONSTRUCTORS

        public MainViewModel()
        {
            //this.TextYolo = "Hello world!";
            this.OnButtonClick = new Command(this.OnButtonAction);
        }

        #endregion

        #region METHODS

        private void OnButtonAction(object param)
        {
            this.TextYolo = "Hello world!";
        }

        #endregion
    }
}
