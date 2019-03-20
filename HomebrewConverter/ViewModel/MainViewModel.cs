using System.Windows.Input;
using HomebrewConverter.ViewModel.Converters;
using HomebrewConverter.ViewModel.CreateNew;

namespace HomebrewConverter.ViewModel
{
    /// This class contains properties that the main View can data bind to.
 
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>

        // The Current View
        private ViewModelBase _currentViewModel;

        // Static instances of each of the view models
        private static readonly HomebreweryViewModel HomebreweryViewModel = new HomebreweryViewModel();
        private static readonly CreateNewMonsterViewModel CreateNewMonsterViewModel = new CreateNewMonsterViewModel();


        // CurrentView property. If View is changed, a property changed event is raised
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                if (_currentViewModel == value)
                {
                    return;
                }

                _currentViewModel = value;
                OnPropertyChanged();
            }
        }


        // Properties to hold view commands. When executed it will change current view to own view
        public ICommand HomeBreweryViewCommand { get; private set; }
        public ICommand CreateNewMonsterViewCommand { get; private set; }

        // Set initial view-model to FirstViewModel
        // Associates the commands with their execution actions
        public MainViewModel()
        {
            CurrentViewModel = HomebreweryViewModel;
            HomeBreweryViewCommand = new RelayCommand(_ => ExecuteHomeBreweryViewCommand());
            CreateNewMonsterViewCommand = new RelayCommand(_ => ExecuteCreateNewMonsterViewCommand());
        }


        // Set CurrentViewModel to name-specific ViewModel
        private void ExecuteHomeBreweryViewCommand()
        {
            CurrentViewModel = HomebreweryViewModel;
        }

        private void ExecuteCreateNewMonsterViewCommand()
        {
            CurrentViewModel = CreateNewMonsterViewModel;
        }
    }
}