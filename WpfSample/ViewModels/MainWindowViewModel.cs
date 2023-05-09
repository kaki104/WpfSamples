using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Input;

namespace WpfSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManeger;
        private string _title = "다중 레파지토리 사용법";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        /// <summary>
        /// 네비게이트 메뉴 커맨드
        /// </summary>
        public ICommand NavigateMenuCommand { get; set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManeger = regionManager;
            Init();
        }
        private void Init()
        {
            NavigateMenuCommand = new DelegateCommand<string>(OnNavigateMenu);
        }
        /// <summary>
        /// 네비게이트 메뉴
        /// </summary>
        /// <param name="viewName"></param>
        private void OnNavigateMenu(string viewName)
        {
            if (string.IsNullOrEmpty(viewName))
            {
                return;
            }
            _regionManeger.RequestNavigate("ContentRegion", viewName);
        }
    }
}
